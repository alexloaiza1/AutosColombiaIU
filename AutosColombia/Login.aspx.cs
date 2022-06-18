using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using AutosColombia.Controller;

namespace AutosColombia
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnIngresar_Click()
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {

        }


        protected void Button1_Click3(object sender, EventArgs e)
        {
            try
            {
                DataSet objDs = null;
               String usu;
                String contra;
                int cedula = int.Parse(txtUsuario.Text);
                String sql = "SELECT * FROM USUARIOS WHERE FKGESTOR='" + cedula + "'AND CONTRASEÑA='" + txtContraseña.Text + "'";
                conexion objConexion = new conexion();
                objConexion.abrirBd();
                objDs = objConexion.ejecutarConsultaSql(sql);
                usu = objDs.Tables[0].Rows[0][1].ToString();
                contra = objDs.Tables[0].Rows[0][0].ToString();
                objConexion.cerrarBd();
                Session["usuario"] = contra;
                ScriptManager.RegisterStartupScript(this, GetType(), "MiFuncion", "abrirHref();", true);

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "MiFuncion", "mirarUsuario();", true);
            }



        }
    }
}