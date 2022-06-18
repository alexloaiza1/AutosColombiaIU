<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AutosColombia.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700" rel="stylesheet"/>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="css/estilos.css"/>

    <script type="text/javascript" src="js/ValidacionesLogin.js" ></script>


    <title>Login</title>
</head>
<body>
     <div class="login-form">

         <h2 class="text-center">Servicio Parking AutosColombia S.A</h2>
    <form id="form1" runat="server">
         <div class="avatar">
			    <img src="/avatar2.png" alt="Avatar"/>
		    </div>  

   
        <asp:ScriptManager runat="server"></asp:ScriptManager>
       
                    <div class="form-group">
                        Usuario<asp:TextBox ID="txtUsuario" runat="server" style="margin-bottom: 1px" Width="230px" CssClass="auto-style1" Height="33px"></asp:TextBox>
                            
                        </div>
                    
                   
                  <div class="form-group">
                      Contraseña<asp:TextBox ID="txtContraseña" runat="server" style="margin-left: 56px;" CssClass="auto-style3" Width="228px" Height="32px"
                        type="password"></asp:TextBox>
                      <br />
                      <br />
                      <br />


                      </div>
            <div class="form-group">
                 <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="Button1_Click3"  class="btn btn-primary btn-lg btn-block login-btn" Height="55px" />

                </div>

        <div class="form-group">
        <a href="frmGestor.aspx">Registrarme</a>
        </div>
                
    </form>
     </div> 
</body>
</html>
