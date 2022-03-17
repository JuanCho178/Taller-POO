using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class Reporte
    {
        public void TodosCliente()
        {
            Servicios_Cliente servicios_Cliente = new();
            servicios_Cliente.ListaCliente();
        }

        public void TodosProdutos()
        {
            ProductoService productoService = new();
            productoService.ListaProducto();
        }
    }
}
