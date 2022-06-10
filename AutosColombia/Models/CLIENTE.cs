using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutosColombia.Models
{
    public class CLIENTE
    {
        private int cedula;
        private  String nombre;
        private String apellidos;
        private String telefono;
        private String direccion;



        public CLIENTE(int cedula, string nombre, string apellidos, string telefono, string direccion)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public CLIENTE()
        {
            this.cedula = 0;
            this.nombre = "";
            this.apellidos = "";
            this.telefono = "";
            this.direccion = "";

        }


        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }



    }







}