<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuBienvenido.aspx.cs" Inherits="AutosColombia.MenuBienvenido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/> <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<link href="https://fonts.googleapis.com/css?family=Roboto:400,700" rel="stylesheet"/>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
<link rel="stylesheet" href="css/estilos2.css"/>



    <title>Bienvenido</title>



</head>
<body>
    <div>

     <h1 class="text-center">BIENVENIDO </h1>

    <form id="form1" runat="server">
        
        <div class="container">
                <div class="overlay">
                       <a href="FrmCientes.aspx"><img src="AgregarCliente.png" alt="Avatar" class="auto-style7" id="gestionCliente" runat="server"/></a>
                </div>
            <div>
                <h2>Registrar Cliente</h2>
            </div>

        </div>
        <br />


    </form>


  </div>





</body>
</html>
