using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutosColombia.Controller;
using AutosColombia.Models;

namespace AutosColombia
{
    public partial class frmGestor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarE_Click(object sender, EventArgs e)
        {

            int cedula =int.Parse(txtCedula.Text);
            GESTOR objGes = new GESTOR(cedula,txtNombreE.Text,txtApellidos.Text,txtTelefono.Text,txtCargo.Text,txtEmail.Text,txtContrasena.Text);
            gestor objControlGestor = new gestor(objGes);
            Label2.Text = objControlGestor.guardar();
        }

        
    }
}