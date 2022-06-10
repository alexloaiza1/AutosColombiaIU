<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AutosColombia.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table  style="width: 100%;">
         <tr>
                    <td class="auto-style11">Usuario<asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 77px; margin-bottom: 1px" Width="230px"></asp:TextBox>
                    </td>
                    <td class="auto-style10"></td>
                  
                </tr>
                <tr>
                    <td class="auto-style12">Contraseña<asp:TextBox ID="txtContraseña" runat="server" style="margin-left: 56px;" CssClass="auto-style3" Width="228px" Height="24px"
                        type="password"></asp:TextBox>
                    </td>
                    <td class="auto-style6"></td>
                    
                </tr>
            <tr>
                <td class="auto-style4">
                  <input name="Ingresar" type="button" onclick="valida()" class="style2" value="Ingresar"/>

                </td>
           </tr>
            </table>
        </div>
    </form>
</body>
</html>
