using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class FacturaService
    {
        private ProductoService productoService = new();
        List<Venta> ventas = new();

        public void Venta()
        {
            ProductoService productoService = new();
            Servicios_Cliente servicios_Cliente = new();
            servicios_Cliente.solicitarCliente();
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("Fecha: " + Date);

            productoService.EncabezadoFactura();

            productoService.DetalleFactura();
        }

        public void BuscarFactura()
        {
            Console.WriteLine("Ingrese el codigo del producto");
            string opcion = Console.ReadLine();
            int indice = ventas.FindIndex(x => x.NumeroFactura.Equals(opcion));
            if (indice > -1)
            {
                productoService.DetalleFactura();
            }

            else
            {
                Console.WriteLine("La Factura no existe, porfavor ingrese de nuevo el codigo\n");
            }
        }
    }
}
