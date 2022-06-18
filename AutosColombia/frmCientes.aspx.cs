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
    public partial class frmCientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarE_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(txtCedula.Text);
            string Gestor = DropDownList2.Items[DropDownList2.SelectedIndex].ToString();
            int idGestor = int.Parse(Gestor);
            CLIENTE objClie = new CLIENTE(cedula, txtNombreE.Text, txtApellidos.Text, txtTelefono.Text, txtDireccion.Text,idGestor );
            cliente objControlGestor = new cliente(objClie);
            Label2.Text = objControlGestor.guardar();
        }
    }
}