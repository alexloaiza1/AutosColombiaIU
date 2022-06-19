using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using AutosColombia.Models;

namespace AutosColombia.Controller
{
    public class gestor
    {
        GESTOR objGestor;

        public gestor(GESTOR objGestor)
        {
            this.objGestor = objGestor;
        }



        public String guardar()
        {
            String msg;
            int cedula = objGestor.Cedula;
            String nombre = objGestor.Nombre;
            String apellidos = objGestor.Apellidos;
            String telefono = objGestor.Telefono;
            String cargo = objGestor.Cargo;
            String email = objGestor.Email;
            String contrasena = objGestor.Contrasena;
            String comandoSql = "INSERT INTO GESTORES VALUES('" + cedula + "','" + nombre + "','" + apellidos + "','" + telefono + "', '" + cargo + "', '" + email + "','" + contrasena + "')" ;
            String comandoSql2 = "INSERT INTO USUARIOS VALUES('" + cedula + "','" + contrasena + "')";
            conexion objConexion = new conexion();
            objConexion.abrirBd();
            msg = objConexion.ejecutarComandoSql(comandoSql+comandoSql2);
            objConexion.cerrarBd();
            return msg;
        }
    }
}