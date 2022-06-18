using System;

namespace AutosColombia.Models
{
    public class GESTOR
    {
        private int cedula;
        private String nombre;
        private String apellidos;
        private String telefono;
        private String cargo;
        private String email;
        private String contrasena;

        public GESTOR(int cedula, string nombre, string apellidos, string telefono, string cargo, string email, string contrasena)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.cargo = cargo;
            this.email = email;
            this.contrasena = contrasena;
        }




        public GESTOR()
        {
            this.cedula = 0;
            this.nombre = "";
            this.apellidos = "";
            this.telefono = "";
            this.email = "";
            this.contrasena = "";


        }


        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Email { get => email; set => email = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}