using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class Producto
    {
        public Producto()
        {
            Nombre = "No espesificado";
            Precio = 0;
            Cantidad = 0;
            Codigo = "No espesificado";
        }

        public Producto(String Nombre, float Precio, int Cantidad, String Codigo)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Codigo = Codigo;
        }

        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public string Codigo { get; set; }
    }
}
