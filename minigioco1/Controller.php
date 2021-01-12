<?php

//Verifico la action
$action = filter_input(INPUT_GET, "servizio", FILTER_SANITIZE_FULL_SPECIAL_CHARS);
if(!$action){
   $action = filter_input(INPUT_POST, "servizio", FILTER_SANITIZE_FULL_SPECIAL_CHARS);
}

$contesto = "Sito/minigiochi/minigioco1/Sito/";
$gameObjs = [];
//SWITCH
switch($action){
    case "servizio1":
        $ret = [];
        $ret["codice"] = 1;
        $ret["descrizione"] = "servizio 1 minigioco 1 raggiunto";
        echo json_encode($ret);
        break;
    case "getOggetti":
        $gameObjs = json_decode(file_get_contents("gameObjs.json"));
        if(!$gameObjs/* || count($gameObjs)==0*/){
            generateObjs();
        }else{
            gestObjMov();
        }
        echo json_encode($gameObjs);
        break;
    case "gameEnded":
        $gameObjs = [];
        echo json_encode($gameObjs);
        break;
        
    default:
        include("Sito/index.php");  
}

function generateObjs(){
    $ASTEROIDS_MIN = 3;
    $ASTEROIDS_MAX = 7;
    $ASTEROIDS_AMOUNT = rand($ASTEROIDS_MIN,$ASTEROIDS_MAX);
    $RUBBISH_MIN = 3;
    $RUBBISH_MAX = 5;
    $RUBBISH_AMOUNT = rand($RUBBISH_MIN,$RUBBISH_MAX);

    $gameObjs["asteroids"] = [];
    $gameObjs["rubbish"] = [];

    for($i=0;$i<$ASTEROIDS_AMOUNT;$i++){
        $inAst = [];
        $inAst["position"] = [];

        $inAst["position"]["x"] = rand(-20,120);
        $inAst["position"]["y"] = rand(-120,-20);

        array_push($gameObjs["asteroids"],$inAst);
    }
    for($i=0;$i<$RUBBISH_AMOUNT;$i++){
        $inRub = [];
        $inRub["position"] = [];
        
        $inRub["position"]["x"] = rand(5,95);
        $inRub["position"]["y"] = rand(5,95);
        
        array_push($gameObjs["rubbish"],$inRub);
    }
    file_put_contents("gameObjs.json",json_encode($gameObjs));
}

function gestObjMov(){

}

function startWebsocket(){
    error_reporting(E_ALL);
    set_time_limit(0);
    ob_implicit_flush();

    $host = "127.0.0.1";
    $port = 25003;
    set_time_limit(1110);
    $socket = socket_create(AF_INET, SOCK_STREAM, 0) or die("Creazione socket fallita\n");
    $result = socket_bind($socket, $host, $port) or die("Fallito inizializzazione porta su socket\n");
    $result = socket_listen($socket, 3) or die("Start ascolto socket fallito\n");
    file_put_contents("debug.txt","Socket Listening"."\n",FILE_APPEND);
    $spawn = socket_accept($socket) or die("Inizializzazione connessione con client fallita\n");
    $input = socket_read($spawn, 1024) or die("Errore Non riesco a leggere l'input\n");
    $input = trim($input);
    echo "Messaggio Client : ".$input;

    $output = strrev($input) . "\n";
    socket_write($spawn, $output, strlen ($output)) or die("Errore di scrittura su output\n");
    socket_close($spawn);
    socket_close($socket);
    file_put_contents("debug.txt","Socket Closed"."\n",FILE_APPEND);
}