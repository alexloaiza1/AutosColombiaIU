function valida() {
    var usua = document.getElementById('txtUsuario').value
    var contra = document.getElementById('txtContraseña').value


    var m = "";


    if (usua == "") {
        m = m + "► Debe ingresar un Usuario  \n"

    }

    if (contra == "") {
        m = m + "► Debe ingresar una contraseña  \n"
    }

    if (m != "") {
        alert(m);
    }




}
function mirarUsuario() {
    alert("Usuario o contraseña incorrectos")
}
function abrirHref() {
    window.location.href = 'MenuBienvenido.aspx';
}
