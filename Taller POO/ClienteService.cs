using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class Servicios_Cliente
    {
        //Lista cliente
        static List<Cliente> Listcliente = new();

        public void CrearCliente()
        {
            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Cedula");
            string cedula = Console.ReadLine();
            Console.WriteLine("Telefono");
            string telefono = Console.ReadLine();
            Console.WriteLine("Direccion");
            string direccion = Console.ReadLine();

            Cliente cliente1 = new(nombre, direccion, telefono, cedula);

            Console.WriteLine("Registro exitoso de cliente\n");

           Listcliente.Add(cliente1);
            Console.Clear();
        }

        public void BuscarCliente()
        {
            Console.WriteLine("Ingrese el documento del cliente");
            string opcion = Console.ReadLine();
            int indice = Listcliente.FindIndex(x => x.Cedula.Equals(opcion));
            if (indice > -1)
            {          
                    Console.WriteLine($"Nombre: {Listcliente[indice].Nombre} \n" +
                        $"Direccion: {Listcliente[indice].Direccion}\n" +
                        $"Telefono: {Listcliente[indice].Telefono}\n" +
                        $"Cedula: {Listcliente[indice].Cedula}\n");
            }

            else
            {
                Console.WriteLine("El usuario no existe, porfavor ingrese de nuevo\n");
            }
        }

        public void ModificarCliente()
        {
            Console.WriteLine("Ingrese la cedula del cliente a modificar, solo puedes modificar el numero telefonico");
            string opcion = Console.ReadLine();

            Console.WriteLine("ingrese el nuevo numero telefonico\n" +
                "-->");
            string numeorTelel = Console.ReadLine();

            int indice = Listcliente.FindIndex(x => x.Cedula.Equals(opcion));
            Listcliente[indice].Telefono = numeorTelel;

            if (indice > -1)
            {
                Console.WriteLine($"Los cambios se han guardado a la perfeccion.\n" +
                    $"Nuevo numero: {Listcliente[indice].Telefono}\n");
            }

            else
            {
                Console.WriteLine("El Usuario no existe, porfavor ingrese de nuevo el documento\n");
            }

        }

        public void DeshabilitarCliente()
        {
            Console.WriteLine("Ingrese el numero de cedula del cliente que desea eliminar.");
            string opcion = Console.ReadLine();
            int indice = Listcliente.FindIndex(x => x.Cedula.Equals(opcion));
            Listcliente.RemoveAt(indice);
            if (indice > -1)
            {
                Console.WriteLine("Se a eliminado correctamente el usuario\n");
            }

            else
            {
                Console.WriteLine("El usuario no existe, porfavor ingrese de nuevo el documento\n");
            }
        }

        public void solicitarCliente()
        {
           
            Console.WriteLine("Ingrese el documento del cliente");
            string opcion = Console.ReadLine();
            int indice = Listcliente.FindIndex(x => x.Cedula.Equals(opcion));
            if (indice > -1)
            {
                Console.WriteLine($"Nombre: {Listcliente[indice].Nombre} \n" +
                    $"Cedula: {Listcliente[indice].Cedula}\n");
            }

            else
            {
                Console.WriteLine("El usuario no existe, porfavor ingrese de nuevo\n");
            }

        }

        public void ListaCliente()
        {
            Console.WriteLine("Listado de clientes");
            foreach (Cliente cliente1 in Listcliente)
            {
                Console.WriteLine($"Nombre: {cliente1.Nombre}\n" +
                    $"Cedula: {cliente1.Cedula}\n" +
                    $"Telefono: {cliente1.Telefono}\n" +
                    $"Direccion: {cliente1.Direccion}\n");
            }
            
        }
    }
}
