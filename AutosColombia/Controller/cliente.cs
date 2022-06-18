using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutosColombia.Controller;
using AutosColombia.Models;

namespace AutosColombia.Controller
{
    public class cliente
    {
        CLIENTE objCliente;

        public cliente(CLIENTE objCliente)
        {
            this.objCliente = objCliente;
        }

        public String guardar()
        {
            String msg;
            int cedula = objCliente.Cedula;
            String nombre = objCliente.Nombre;
            String apellidos = objCliente.Apellidos;
            String telefono = objCliente.Telefono;
            String Direccion = objCliente.Direccion;
            int idGestor=objCliente.IdGestor;
           
            String comandoSql = "INSERT INTO CLIENTES VALUES('" + cedula + "','" + nombre + "','" + apellidos + "','" + telefono + "', '" + Direccion + "','" + idGestor + "')";
            
            conexion objConexion = new conexion();
            objConexion.abrirBd();
            msg = objConexion.ejecutarComandoSql(comandoSql);
            objConexion.cerrarBd();
            return msg;
        }

    }
}