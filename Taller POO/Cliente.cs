using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class Cliente
    {
        public Cliente()
        {
            Nombre = "No especificado";
            Direccion = "No especificado";
            Telefono = "No especificado";
            Cedula = "No especificado";
        }

        public string getcliente()
        {
            return $"este es el cliente que se encuentra registrado\n" +
                $"Nombre: {Nombre}\n" +
                $"Direccion: {Direccion}\n" +
                $"Telefono: {Telefono}\n" +
                $"Cedula: {Cedula}";



        }

        public Cliente(String Nombre, String Direccion, String Telefono, String Cedula)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Cedula = Cedula;
        }
        
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }

    }
}
