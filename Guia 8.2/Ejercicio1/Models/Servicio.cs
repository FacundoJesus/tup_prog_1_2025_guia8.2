using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Servicio
    {
        public int cantidadEncuestados = 0;

        static int contadorBici = 0;
        static int contadorMoto = 0;
        static int contadorAuto = 0;
        static int contadorPublico = 0;

        static double acumuladorDistanciaBici = 0;
        static double acumuladorDistanciaMoto = 0;
        static double acumuladorDistanciaAuto = 0;
        static double acumuladorDistanciaPublico = 0;


        public void RegistrarEncuesta(int tipoTransporte, double distancia)
        {
            switch (tipoTransporte)
            {
                case 1:
                    contadorBici++;
                    acumuladorDistanciaBici += distancia;
                    break;
                case 2:
                    contadorMoto++;
                    acumuladorDistanciaMoto += distancia;
                    break;
                case 3:
                    acumuladorDistanciaAuto += distancia;
                    contadorAuto++;
                    break;
                case 4:
                    contadorPublico++;
                    acumuladorDistanciaPublico += distancia;
                    break;
            }
            if (tipoTransporte > 0 && tipoTransporte < 5)
            {
                cantidadEncuestados++;
            }
        }
        public void CalcularPromedioPorTipo()
        {

            double promedioDistanciaBici = acumuladorDistanciaBici / contadorBici;
            double promedioDistanciaMoto = acumuladorDistanciaMoto / contadorMoto;
            double promedioDistanciaAuto = acumuladorDistanciaAuto / contadorAuto;
            double promedioDistanciaPublico = acumuladorDistanciaPublico / contadorPublico;
            Console.WriteLine($"Promedio de Distancia Recorrida en bici: {promedioDistanciaBici:f2} km");
            Console.WriteLine($"Promedio de Distancia Recorrida en Moto: {promedioDistanciaMoto:f2} km");
            Console.WriteLine($"Promedio de Distancia Recorrida en Auto: {promedioDistanciaAuto:f2} km");
            Console.WriteLine($"Promedio de Distancia Recorrida en T.Público: {promedioDistanciaPublico:f2} km");


            Console.WriteLine("No hubo registro de encuestados.");

        }
    }
}
