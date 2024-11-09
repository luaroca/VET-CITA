using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LogicaVeterinario logicaVeterinario = new LogicaVeterinario();
            //RegistrarVeterinario(logicaVeterinario);

            
           LogicaCliente logicaCliente = new LogicaCliente();
            Cliente cliente = new Cliente();

            string accion;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Gestión de Clientes");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Modificar Cliente");
                Console.WriteLine("3. Eliminar Cliente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        accion = "1"; // Registrar
                        Console.WriteLine("Registrar Cliente");
                        break;

                    case 2:
                        accion = "2"; // Modificar
                        Console.WriteLine("Modificar Cliente");
                        break;

                    case 3:
                        accion = "3"; // Eliminar
                        Console.WriteLine("Eliminar Cliente");
                        break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                }

                // Solicitar datos del cliente
                Console.Write("Ingrese CC del Cliente: ");
                cliente.CC_Cliente = int.Parse(Console.ReadLine());

                Console.Write("Ingrese Nombre del Cliente: ");
                cliente.Nombre = Console.ReadLine();

                Console.Write("Ingrese Dirección del Cliente: ");
                cliente.Direccion = Console.ReadLine();

                Console.Write("Ingrese Teléfono del Cliente: ");
                cliente.Telefono = Console.ReadLine();

                // Asignar acción y llamar al método de mantenimiento
                cliente.Accion = accion;
                string mensaje = logicaCliente.N_mantenimiento_cliente(cliente);

                // Mostrar el mensaje de resultado
                Console.WriteLine(mensaje);

                // Pausar para mostrar el mensaje
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);




        }

        //static void RegistrarVeterinario(LogicaVeterinario logicaVeterinario)
        //{
        //    Veterinario veterinario = ObtenerDatosVeterinario();
        //    veterinario.Accion = "1"; // Acción 1 para registro, este parámetro se pasa al método
        //    string mensaje = logicaVeterinario.N_mantenimiento_veterinario(veterinario);
        //    Console.WriteLine(mensaje);
        //}

        //static Veterinario ObtenerDatosVeterinario()
        //{
        //    Veterinario veterinario = new Veterinario();

        //    Console.Write("Ingrese el ID del Veterinario: ");
        //    veterinario.ID_Veterinario = int.Parse(Console.ReadLine());
        //    Console.Write("Ingrese el Nombre del Veterinario: ");
        //    veterinario.Nombre = Console.ReadLine();
        //    Console.Write("Ingrese la Especialidad del Veterinario: ");
        //    veterinario.Especialidad = Console.ReadLine();
        //    Console.Write("Ingrese el Teléfono del Veterinario: ");
        //    veterinario.Telefono = Console.ReadLine();
        //    Console.Write("Ingrese el Horario del Veterinario: ");
        //    veterinario.Horario = Console.ReadLine();

        //    // El parámetro 'Accion' se establece como "1" por defecto para registro
        //    veterinario.Accion = "1"; // Este es el parámetro que se utilizará para el registro
        //    return veterinario;
        //}


    }
}
