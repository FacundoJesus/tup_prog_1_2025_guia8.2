using System.ComponentModel;
using Ejercicio1.Models;
namespace Ejercicio1
{

    internal class Program
    {

        static Servicio servicio = new Servicio();
        
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("---MENU---");
            Console.WriteLine("Elija la opcion deseada:");
            Console.WriteLine("1 - Iniciar encuesta (inicializar variables)");
            Console.WriteLine("2 - Registrar una encuesta ");
            Console.WriteLine("3 - Registrar varias encuestas");
            Console.WriteLine("4 - Mostrar los promedios en distancia recorrida por cada tipo de transporte (tipo de transporte -1)");
            Console.WriteLine("5 - Mostrar el total de encuestados");
            Console.WriteLine("-1 Para Salir de la Aplicación... ");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;
        }

        static void MostrarPantallaInicializarVariables()
        {
            Console.Clear();
            servicio = new Servicio();
            Console.WriteLine("Variables inicializadas.");
            Console.WriteLine("\nPresione Enter para volver al Menu Principal");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarEncuesta()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tipo de vehículo o (-1 Para volver al Menú Principal):");
            Console.WriteLine("1 - Bicicleta");
            Console.WriteLine("2 - Motocicleta");
            Console.WriteLine("3 - Automóvil");
            Console.WriteLine("4 - Transporte Público");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion > 0 && opcion < 5)
            {
                Console.Clear();
                Console.WriteLine("Ingrese la distancia recorrida:");
                double distanciaRecorrida = Convert.ToDouble(Console.ReadLine());
                servicio.RegistrarEncuesta(opcion, distanciaRecorrida);
            }
            else
            {
                Console.WriteLine("Tipo de transporte no  válido");
            }
            Console.WriteLine("\nPresione Enter para volver al Menu Principal");
            Console.ReadKey();
        }
        static void MostrarPantallSolicitarVariasEncuestas()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tipo de vehículo o -1 Para volver al Menú Principal");
            Console.WriteLine("1 - Bicicleta");
            Console.WriteLine("2 - Motocicleta");
            Console.WriteLine("3 - Automóvil");
            Console.WriteLine("4 - Transporte Público");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion <= 0 || opcion >= 5)
            {
                Console.WriteLine("Tipo de transporte no válido");
            }
            else
            {
                while (opcion != -1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese la distancia recorrida:");
                    double distanciaRecorrida = Convert.ToDouble(Console.ReadLine());
                    servicio.RegistrarEncuesta(opcion, distanciaRecorrida);
                    Console.WriteLine("Ingrese el tipo de vehículo o -1 Para volver al Menú Principal");
                    Console.WriteLine("1 - Bicicleta");
                    Console.WriteLine("2 - Motocicleta");
                    Console.WriteLine("3 - Automóvil");
                    Console.WriteLine("4 - Transporte Público");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
            }
                
            Console.WriteLine("\nPresione Enter para volver al Menu Principal");
            Console.ReadKey();
        }
        static void MostrarPantallaPromediosResultados()
        {
            Console.Clear();
            if (servicio.cantidadEncuestados > 0)
            {
                servicio.CalcularPromedioPorTipo();
                
            }
            else
            {
                Console.WriteLine("No hubo encuestados");
                
            }
            Console.WriteLine("\nPresione Enter para volver al Menu Principal");
            Console.ReadKey();

        }
        static void MostrarPantallaTotalEncuestados()
        {

            Console.Clear();
            if (servicio.cantidadEncuestados > 0)
            {
                Console.WriteLine($"Cantidad Total de encuestados: {servicio.cantidadEncuestados}");
            }
            else
            {
                Console.WriteLine("No hubo encuestados");
            }

            Console.WriteLine("\nPresione Enter para volver al Menu Principal");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();
            while (opcion != -1)
            {
                switch(opcion) {
                    case 1:
                        MostrarPantallaInicializarVariables();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEncuesta();
                        break;
                    case 3:
                        MostrarPantallSolicitarVariasEncuestas();
                        break;
                    case 4:
                        MostrarPantallaPromediosResultados();
                        break;
                    case 5:
                        MostrarPantallaTotalEncuestados();
                        break;
                    default:
                        opcion = -1;
                        break;
                }

                if (opcion != -1)
                {
                    opcion = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
    }
}
