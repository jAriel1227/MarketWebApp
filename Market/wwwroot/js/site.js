// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Usuarios registrer
function soloLetras(letra) {

    tecla = letra.keyCode || letra.which;

    teclado = String.fromCharCode(tecla).toLowerCase();

    letras = "áéíóúabcdefghijklmnñopqrstuvwxyz"

    especial = [8, 32, 37, 39, 46];

    tecla_especial = false;

    for (var i in especial) {
        if (tecla == especial[i]) {
            tecla_especial = true;
            break;
        }
    }
    if (letras.indexOf(teclado) == -1 && !tecla_especial) {
        return false;
    }
}

function formatear() {
    var num_sf = document.getElementById('tel').value;
    var num_cf = '';

    num_cf = num_sf.substring(0, 3) + ")-";
    num_cf += num_sf.substring(3, 6) + "-";
    num_cf += num_sf.substring(6, 10);
    document.getElementById('tel').value = "(" + num_cf;
}
//Fin Usuarios registrer