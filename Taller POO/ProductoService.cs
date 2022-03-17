using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class ProductoService
    {
        static List<Producto> Listproducto = new();
      
        public int indice;

        public void CrearProducto()
        {
            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Precio");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Codigo");
            string codigo = Console.ReadLine();

            Producto Producto1 = new(nombre, precio, cantidad, codigo);



            Console.WriteLine("Registro exitoso del producto\n");


            Listproducto.Add(Producto1);
            Console.Clear();
        }

        public void BuscarProducto()
        {
            Console.WriteLine("Ingrese el codigo del producto");
            string opcion = Console.ReadLine();
            int indice = Listproducto.FindIndex(x => x.Codigo.Equals(opcion));
            if (indice > -1)
            {
                Console.WriteLine($"Nombre: {Listproducto[indice].Nombre} \n" +
                    $"Precio: {Listproducto[indice].Precio}\n" +
                    $"Cantidad: {Listproducto[indice].Cantidad}\n" +
                    $"Codigo: {Listproducto[indice].Codigo}\n");
            }

            else
            {
                Console.WriteLine("El Producto no existe, porfavor ingrese de nuevo el codigo\n");
            }

        }

        public void ModificarProducto()
        {
            Console.WriteLine("Ingrese el codigo del producto a modificar, solo puedes modificar el Precio");
            string opcion = Console.ReadLine();

            Console.WriteLine("ingrese el nuevo precio del producto\n" +
                "-->");
            float nuevoPrecio = float.Parse(Console.ReadLine());

            int indice = Listproducto.FindIndex(x => x.Codigo.Equals(opcion));
            Listproducto[indice].Precio = nuevoPrecio;

            if (indice > -1)
            {
                Console.WriteLine($"Los cambios se han guardado a la perfeccion.\n" +
                    $"Nuevo Precio: {Listproducto[indice].Precio}\n");
            }

            else
            {
                Console.WriteLine("El Producto no existe, porfavor ingrese de nuevo el codigo\n");
            }

        }

        public void DeshabilitarProducto()
        {
            
            Console.WriteLine("Ingrese el codigo del producto que desea eliminar.");
            string opcion = Console.ReadLine();
            int indice = Listproducto.FindIndex(x => x.Codigo.Equals(opcion));
            Listproducto.RemoveAt(indice);
            if (indice > -1)
            {
                Console.WriteLine("Se a eliminado correctamente el producto\n");
            }

            else
            {
                Console.WriteLine("El Producto no existe, porfavor ingrese de nuevo el codigo\n");
            }
        }

        public void EncabezadoFactura()
        {
            List<Cliente> Listcliente = new();
            Cliente ListCliente = new();
            Venta venta = new();
            int contadorAuto = 1;
            venta.NumeroFactura = contadorAuto;
            contadorAuto++;
            Console.WriteLine($"Numero de factura: {venta.NumeroFactura}");
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("Fecha: " + Date);

            foreach (var x in Listcliente)
            {
                Console.WriteLine($"Numero de Cedula {ListCliente.Cedula}");
            }
        }

        public void DetalleFactura()
        {
            Servicios_Cliente servicios_Cliente = new();
            ProductoService productoService = new();
            Venta venta = new();
            Console.WriteLine("Codigo: ");
            string opcion = Console.ReadLine();
            int indice = Listproducto.FindIndex(x => x.Codigo.Equals(opcion));
            if (indice > -1)
            {
                Console.WriteLine($"Nombre: {Listproducto[indice].Nombre} \n");
            }

            else
            {
                Console.WriteLine("El Producto Nunca Existio..");
            }

            Console.WriteLine("Cuando Cantidad del Producto deseas llevar: ");
            var cantidadEscogida  = int.Parse(Console.ReadLine());
            if (cantidadEscogida > Listproducto[indice].Cantidad)
            {
                Console.WriteLine("Lo siento pero no contamos con esa Cantidad");
            }

            else
            {
                int total = Listproducto[indice].Cantidad - cantidadEscogida;
                float valorTotal = Listproducto[indice].Precio * cantidadEscogida;

                Console.WriteLine("La cantidad ha sido pedida con exito");
                Console.WriteLine("El total a Paga es de " + valorTotal);
                Console.WriteLine("Cantidad disponible del Producto: " + total);
            }

            
            
            
        }
        public void ListaProducto()
        {
            Console.WriteLine("Listado de Producto");
            foreach (Producto Producto1 in Listproducto)
            {
                Console.WriteLine($"Nombre: {Producto1.Nombre}\n" +
                    $"Cedula: {Producto1.Precio}\n" +
                    $"Telefono: {Producto1.Cantidad}\n" +
                    $"Direccion: {Producto1.Precio}\n");
            }
        }
    }
}
