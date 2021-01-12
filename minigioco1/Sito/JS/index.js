"use strict"

var contesto = "Sito/minigiochi/minigioco1/";

$(document).ready(function () {
    creaAvatar();
    $("#btnProva").on("click", function () {
        send_request((contesto + "Controller.php"), "POST", { servizio: "servizio1" }, function (response) {
            let data = JSON.parse(response);
            console.log(data);
        });
    });

    $("#startGame").on("click", function () {


        //TODO controllo sulla scelta avatar: non si potrà iniziare il gioco senza aver effettuato la scelta
        // if(!avatar)
        //     alert("Scegli prima l'avatar");

        console.log($("#campoGioco")[0].offsetWidth);

        send_request((contesto + "Controller.php"), "POST", { servizio: "getOggetti" }, function (response) {
            console.log(response);
            let oggetti = JSON.parse(response);
            // console.log(oggetti);

            for (var key in oggetti) {
                var val = oggetti[key];

                console.log(key, val);

                val.forEach(oggetto => {
                    let obj = $("<div></div>");
                    obj.addClass(key);

                    $("#campoGioco").append(obj);
                    obj.css({ top: oggetto.position.x + "%", left: oggetto.position.y + "%" });
                });
            }

        });
    });

    $("#campoGioco").on("mousedown",campoMouseClick);

});

function campoMouseClick(event){
    //console.log(event.clientX-this.offsetLeft, event.clientY-this.offsetTop);
    $("#avatar").css({left: (event.clientX-this.offsetLeft - ($("#avatar")[0].offsetWidth/2)) + "px", top: (event.clientY-this.offsetTop - ($("#avatar")[0].offsetHeight/2)) + "px"});
    $("#avatar").css("transition", "all 1s ease-in-out");
}

document.addEventListener('keydown', function (e) {

    let positionLeft = $("#avatar").css("left");
    let positionTop = $("#avatar").css("top");

    console.log(positionLeft+" || "+ positionTop);


    switch (e.keyCode) {
        case 37:
            //alert("left");{top: 200, left: 200}
            $("#avatar").css({top: positionTop, left: positionLeft-5});
            break;
        case 38:
            //alert("up");
            $("#avatar").css({top: positionTop-5, left: positionLeft});
            break;
        case 39:
            //alert("right");
            $("#avatar").css({top: positionTop, left: positionLeft+5});
            break;
        case 40:
            //alert("down");
            $("#avatar").css({top: positionTop+5, left: positionLeft});
            break;
    }
});

function creaAvatar() {
    console.log("cciao");
    /*for(let i=0;i<5;i++){
        <div class="card" style="width:400px">
                        <img class="card-img-top" alt="Card image">
                        <div class="card-body">
                            <h4 class="card-title">John Doe</h4>
                            <p class="card-text">Some example text.</p>
                            <a href="#" class="btn btn-primary">See Profile</a>
                        </div>
        </div>
    }
    */
}


