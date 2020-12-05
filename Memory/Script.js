"use strict";

var v = new Array(36);
var carta = 0;
var sec = 0;
var min;
var secondi;
var minuti;
var cronometro;

window.onload = function () {
    

    //inizializzazione vettore a 0
    for (var i = 0; i < 36; i++) {
        v[i] = 0;
    }
    //alert("inizio...");

    //creazione bottone "inizia"
    let btn = $("<input>");
    $("form").append(btn);
    $(btn).prop("type", "button");
    $(btn).addClass("btn btn-primary");
    $(btn).prop("value", "INIZIA!");

    //qunado premi sul bottone parte la funzione inizia()
    $(btn).on("click", function () {
        inizio();
    });
    /*
    //creazione pulsante "inizio"
    var start = $("<input>");
    $(start).prop("type", "submit");
    $(start).prop("value", "INIZIA!");
    $(start).prop("id", "start");
    $(start).on("click", function () {
        inizio();
        $(this).hide();
    })
    $("#wrapper").append(start);
*/
}


function inizio() {

    //alert("Gioco inziato!");

    cronometro=true;

    var nick=document.getElementById("name").value;
    //alert(nick);
    var personaggio = document.forms.MyForm.personaggio.value;
    //alert(personaggio);
    

    document.getElementsByTagName("body")[0].innerHTML = " ";

    var titolo=$("<h1>Memory</h1>");
    $("body").append(titolo);
    $(titolo).css({
        "text-align":"center",
        "margin-bottom":"5%",
        "color":"rgb(255, 15, 223)"
    });

    
    let row = $("<div></div>");
    $("body").append(row);
    $(row).addClass("row");

    let sx = $("<div></div>");
    $(row).append(sx);
    $(sx).addClass("col-sm-2");

    let divCarte = $("<div></div>");
    $(divCarte).prop("id","carte");
    $(row).append(divCarte);
    $(divCarte).addClass("col-sm-3");

    let avatar = $("<div></div>");
    $(avatar).prop("id","avatar");
    $(avatar).css({
        //"height":"100px",
        //"background-color":"blue"
    });
    $(row).append(avatar);
    $(avatar).addClass("col-sm-5");

    let row2 = $("<div></div>");
    $(row2).prop("id","row2");
    $(avatar).append(row2);
    $(row).addClass("row");
    let img = $("<img>");
    $(img).addClass("avatar");
    $(img).prop("id","foto");
    //$(img).addClass("avatar");
    $(row2).append(img);
    $(img).css({
        "height":"300px",
        //"background-color":"red"
        //"width":"50%"
    });
    $(img).addClass("col-sm-8");


    if(personaggio=="Max"){
        //$(img).prop("src","img/Falco.jpg");
        document.getElementById("foto").src="img/Falco.jpg"
    }

    if(personaggio=="Pier"){
        //$(img).prop("src","img/Falco.jpg");
        document.getElementById("foto").src="img/Morano.jpg"
    }

    if(personaggio=="Giampy"){
        //$(img).prop("src","img/Falco.jpg");
        document.getElementById("foto").src="img/Maggiore.jpg"
    }

    if(personaggio=="Oscar"){
        //$(img).prop("src","img/Falco.jpg");
        document.getElementById("foto").src="img/Cambieri.jpg"
    }

    let NomePersonaggio = $("<p></p>");
    if(nick==""){
        $(NomePersonaggio).html(personaggio)
    }else{
        $(NomePersonaggio).html(nick)
    }
    $(NomePersonaggio).appendTo(row2);
    $(NomePersonaggio).addClass("font-italic font-weight-light");
    $(NomePersonaggio).css({
        "font-size":"20pt",
        "background-color":"rgb(255, 15, 223)",
        "display":"inline-block",
        "margin-left":"20px"
    });

    let Tempo = $("<p></p>");
    $(Tempo).appendTo(row2);
    $(Tempo).prop("id","tempo");
    $(Tempo).addClass("font-italic font-weight-bold");
    $(Tempo).css({
        "font-size":"20pt",
        "background-color":"rgb(255, 15, 223)",
        "margin-top":"20px",
        "text-align":"center"
    });

    //tempo();
    //cronometro();

    let dx = $("<div></div>");
    $(row).append(dx);
    $(dx).addClass("col-sm-2");


    /*========================================================================================================*/
    
    var id = 0;
    //creazione celle di gioco
    for (var i = 0; i < 6; i++) {
        for (var j = 0; j < 6; j++) {
            var cella = $("<button></button>");
            $(divCarte).append(cella);
            $(cella).addClass("cellaGrigia");
            $(cella).prop("id", id);
            id++;
        }
        var br = $("<br>");
        $(divCarte).append(br);
    }

    /*========================================================================================================*/
    //alert("Gioco inziato!");
    for (var i = 0; i < 18; i++) {
        var occupato = true;
        do {
            var indice = Math.floor((35) * Math.random());
            //alert(indice);
            if (v[indice] == 0)
                occupato = false;

        } while (occupato);
        v[indice] = i;

        var occupato = true;
        do {
            var indice = Math.floor((35) * Math.random());
            //alert(indice);
            if (v[indice] == 0)
                occupato = false;

        } while (occupato);
        v[indice] = i;
    }

    for (var i = 0; i < 36; i++) {
        document.getElementById(i).innerHTML = v[i];
    }


    //scopre la carta premuta
    $(".cellaGrigia").on("click", function () {
        //alert($(this).prop("class"));
        
        //evita di poter premere una carta rossa o blu controllandone la classe
        if ($(this).prop("class") != "cellaRossa"&&$(this).prop("class") != "cellaBlu")
            giraCarta(this);
    });
}


function giraCarta(sender) {
    //alert("carta girata!");

    carta++;
    $(sender).removeClass("cellaGrigia");
    $(sender).addClass("cellaRossa");
    //$(sender).html("PROVA");

    if (carta % 2 == 0) {
        //il primo elemento con la classe .cartaRossa
        var cardOne = $(".cellaRossa:first").html();

        //l'ultimo elemento con la classe .cartaRossa 
        var cardTwo = $(".cellaRossa:last").html();
        //alert(cardOne);
        //alert(cardTwo);
        if (cardOne == cardTwo) {
            //alert("Carte uguali, hai indovinato");
            $(".cellaRossa").addClass("cellaBlu");
            $(".cellaRossa").removeClass("cellaRossa");
            controlloVittoria();
        } else {
            //alert("Sbagliato");
            attesa();
        }
    }

}

//funzione delay
function attesa() {
    setTimeout("cambio()", 1000);

    //tolgo a tutte le carte coperte l'evento click
    $(".cellaGrigia").off("click");
}

function cambio() {
    //cambio la classe della cella
    $(".cellaRossa").addClass("cellaGrigia");
    $(".cellaRossa").removeClass("cellaRossa");

    //rendo nuovamente premibili le carte coperte
    $(".cellaGrigia").on("click", function () {
        //alert($(this).prop("class"));
        
        //evita di poter premere una carta rossa o blu controllandone la classe
        if ($(this).prop("class") != "cellaRossa"&&$(this).prop("class") != "cellaBlu")
            giraCarta(this);
    });
}

/*function attesa() {
    //alert("attesa...")
    sec++;
    do {
        setTimeout("attesa()", 1000);
    } while (sec < 3);
    clearTimeout();
}*/

function controlloVittoria() {

    //alert("Sto controllando...");

    //var vittoria = false;

    var blu = document.getElementsByClassName("cellaBlu");
    //alert(blu.length);
    if (blu.length == 36) {

        alert(blu.length);
        //creazione del <p> che notifica la vittoria
        var esito = $("<p>Hai vinto</p>");
        $(esito).css({
            "background-color":"rgb(255, 15, 223)",
            "text-align":"center",
            "font-size":"15pt",
            "margin-top":"10px"
        });
        $(esito).addClass("lead")
        $("#row2").append(esito);
        cronometro=false;

       // $("#start").on("click",inizio());
    }

    /*var btnGrigi=$("button").not("cellaBlu");
    alert(btnGrigi);*/

    /*if($(".cellaBlu").length()==36){
        var esito=$("<p>Hai vinto</p>");
        $("#wrapper").append(esito);
    }*/
}

function Personaggio(sender){
    document.forms.MyForm.personaggio.value=sender.id;
}
/*
function tempo()
{
    if(Cronometro)
    {
        if(secondi==60)
        {
            sec=0;
            min++;
        }

        sec++;
        
        document.getElementById("tempo").innerHTML=min+":"+sec;
        setTimeout("tempo()", 1000);
    }
}*/
