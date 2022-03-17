using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class Configuracion
    {
        string Nombre;


        public Configuracion(string Nombre)
        {
            this.Nombre = Nombre;
        }


        public void ConfigurarNombre()
        {
            Console.WriteLine("Ingresa El Nombre de la Empresa: ");
            Nombre = Console.ReadLine();
        }
    }
}
