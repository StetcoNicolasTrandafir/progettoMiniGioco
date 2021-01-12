<!DOCTYPE html>
<html>
    <head>
        <title>Minigioco1</title>

        <meta name="viewport" content="width=device-width, initial-scale=1">
	    <link rel="stylesheet" href="<?php echo $contesto; ?>CSS/index.css">
	    <link rel="stylesheet" href="Sito/Libreria/bootstrap.css">
        <script src="Sito/Libreria/jquery.js"></script>
	    <script src="Sito/Libreria/bootstrap.js"></script>
        <script src="Sito/Libreria/libreria.js"></script>
        <script src="<?php echo $contesto; ?>JS/index.js"></script>
    </head>
    <body>
        <h1 class="text-center">Siamo nella pagina iniziale di Minigioco1</h1>

        <div class="container-fluid">
            <div class="row" >
                <div class="col-sm-2"></div>
                <div class="col-sm-8 text-center" id="campoGioco">
                    <button type="button" id="startGame"  class="btn btn-primary">Primary</button>
                    <div id="avatar"  style="height: 20px; width: 20px; background-color: purple;"></div>
                    <div id="containerAvatar"></div>
                </div>
                <div class="col-sm-2"></div>
                
            </div>
        </div>
    </body>
</html>