﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGestor.aspx.cs" Inherits="AutosColombia.frmGestor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link href="https://fonts.googleapis.com/css?family=Roboto:400,700" rel="stylesheet"/>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="css/estilos3.css"/>
    
    
    
    <title>Registro de Gestor</title>
</head>
<body>
    <div class="signup-form">
    <form id="form1" runat="server" method="post" class="auto-style17">
        
        <h2 class="auto-style16"><span class="auto-style14"><strong>Registro de Gestor</strong></span>&nbsp;<br />
        </h2>

			<p class="auto-style15">


            
					<a href="Login.aspx">Atrás</a>
					<br />


            
					<br />
					<br />
			


			</p>
			


         <div class="form-group">

            Cedula<asp:TextBox ID="txtCedula" runat="server" CssClass="auto-style12" Width="380px" Height="41px"></asp:TextBox>
         </div>
         <div class="form-group">
            Nombre<asp:TextBox ID="txtNombreE" runat="server" CssClass="auto-style6" Width="380px" Height="44px"> </asp:TextBox>
        </div>
         <div class="form-group">
            Apellidos<asp:TextBox ID="txtApellidos" runat="server" CssClass="auto-style6" Width="366px" Height="44px"></asp:TextBox>
        </div>
         <div class="form-group">
            Telefono<asp:TextBox ID="txtTelefono" runat="server" CssClass="auto-style7" Width="380px" Height="42px"></asp:TextBox>
        </div>
         <div class="form-group">
            Cargo<asp:TextBox ID="txtCargo" runat="server" CssClass="auto-style8" Width="380px" Height="44px"></asp:TextBox>
        </div>
         <div class="form-group">
            Email<asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style9" Width="380px" Height="45px"></asp:TextBox>
        </div>
         <div class="form-group">
           Contraseña<asp:TextBox ID="txtContrasena" runat="server" CssClass="auto-style10" Width="380px" Height="46px"></asp:TextBox>
            </div>
                   
                    <div class="auto-style1">
                   </div>
         <div class="auto-style2">
             </div>  
        <div class="auto-style4">
            </div>
        <div class="auto-style5">
            <asp:Button ID="btnGuardarE" runat="server" Text="Guardar" OnClick="btnGuardarE_Click" CssClass="btn btn-success btn-lg btn-block" Height="44px" Width="212px" OnClientClick="return valida();"/>
            </div>    
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
             







      
    </form>
</div>
</body>
</html>
