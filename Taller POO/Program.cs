using System;
using System.Collections.Generic;

namespace Taller_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Configuracion> configuracions = new();
            
            while (true)
            {
                Console.WriteLine($"Hola buenvenido a la Empresa \n" +
                    "--> 1. Modulo de Clientes \n" +
                    "--> 2. Modulo de Productos \n" +
                    "--> 3. Modulo de Ventas \n" +
                    "--> 4. Modulo de Reportes \n" +
                    "--> 5. Modulo de Configuracion \n" +
                    "--> ");

                string opcion = Console.ReadLine();
                Console.Clear();

                // Este Es El Modulo Cliente..
                if (opcion == "1")
                {
                    Servicios_Cliente servicios_Cliente = new();

                    
                    while (true)
                    {
                        Console.WriteLine(" Elige una Opcion \n" +
                       "--> 1. Crear Cliente \n" +
                       "--> 2. Buscar El Cliente \n" +
                       "--> 3. Modificar Cliente \n" +
                       "--> 4. Deshabilitar Cliente \n" +
                       "--> 5. Salir del modulo cliente\n" +
                       "--> ");

                        var opcion2 = Console.ReadLine();
                        Console.Clear();

                        if (opcion2 == "1")
                        {
                            servicios_Cliente.CrearCliente();
                        }

                        else if (opcion2 == "2")
                        {
                            servicios_Cliente.BuscarCliente();
                        }

                        else if (opcion2 == "3")
                        {
                            servicios_Cliente.ModificarCliente();
                        }

                        else if (opcion2 == "4")
                        {
                            servicios_Cliente.DeshabilitarCliente();
                        }
                        
                        else break;

                    }   
                    
                }

                else if (opcion == "2")
                {
                    //Este es el modulo producto

                    ProductoService productoService = new();
                    while (true)
                    {
                        Console.WriteLine(" Elige una Opcion \n" +
                        "--> 1. Crear Producto \n" +
                        "--> 2. Buscar Producto \n" +
                        "--> 3. Modificar Producto \n" +
                        "--> 4. Deshabilitar Producto \n" +
                        "--> 5. Salir del Modulo Producto \n" +
                        "--> ");

                        var opcion3 = Console.ReadLine();
                        Console.Clear();

                        if (opcion3 == "1")
                        {
                            productoService.CrearProducto();
                        }

                        else if (opcion3 == "2")
                        {
                            productoService.BuscarProducto();
                        }

                        else if (opcion3 == "3")
                        {
                            productoService.ModificarProducto();
                        }

                        else if (opcion3 == "4")
                        {
                            productoService.DeshabilitarProducto();
                        }
                        else break;
                    }
                }

                //Este es el modulo venta

                else if (opcion == "3")
                {



                    while (true)
                    {
                        FacturaService factura = new();
                        Servicios_Cliente servicios_Cliente = new();

                        Console.WriteLine(" Elige una Opcion \n" +
                        "--> 1. Ventas \n" +
                        "--> 2. Buscar Factura \n" + 
                        "--> 3. Salir del Modulo Venta \n" +
                        "--> ");
                        string opcion3 = Console.ReadLine();

                        if (opcion3 == "1")
                        {
                            factura.Venta();
                        }

                        else if (opcion3 == "2")
                        {
                            factura.BuscarFactura();
                        }
                        else break;

                    }

                }

                else if (opcion == "4")
                {
                    while (true)
                    {
                        Reporte reporte = new();
                        Servicios_Cliente servicios_Cliente = new();

                        Console.WriteLine($"Eliga una opcion \n" +
                            $"--> 1. Listar clientes \n" +
                            $"--> 2. Listar Productos \n" +
                            $"--> 3. Listar Encabezados de factura \n" +
                            $"--> 4. Salir del Modulo Reporte \n" +
                            "--> ");

                        string opcion4 = Console.ReadLine();

                        if (opcion4 == "1")
                        {
                            reporte.TodosCliente();
                        }

                        else if (opcion4 == "2")
                        {
                            reporte.TodosProdutos();
                        }
                        else break;
                    }
                }
            }
        }
    }
}
