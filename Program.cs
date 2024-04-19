using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ------------------------- MAIN -------------------------------
namespace EjerciciosClase2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // EJERCICIO 1
            /*string mensaje = "Ingrese un numero entero: ";
            int numeroIngresado;
            const int MAX = 100;
            const int MIN = -100;
            bool resultado;

            Console.WriteLine("*** Ingrese 10 numeros entero! ***");
            for (int i = 0; i < 2; i++)
            {
                do
                {
                    numeroIngresado = ClassEjemplo.PedirNumeroInt(mensaje);
                    resultado = Validador.Validar(numeroIngresado, MIN, MAX);
                    if (resultado)
                    {
                        Console.WriteLine("Exitoso!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error! Ha ingresado un numero por fuera del rango.");
                    }
                } while (true);                
            }*/

            // EJERCICIO 2
            int acumulador = 0;
            string respuesta;
            int numeroIngresado;

            do
            {
                numeroIngresado = ClassEjemplo.PedirNumeroInt("Ingrese un numero de tipo entero: ");
                acumulador = acumulador + numeroIngresado;

                Console.WriteLine("Quiere continuar? Ingrese S para Continuar: ");
                respuesta = Console.ReadLine();
                if (!Validador.ValidarRespuesta(respuesta))
                {
                    break;
                }
                Console.WriteLine($"El acumulador tiene el siguiente valor: {acumulador}");
            } while (true);

            Console.WriteLine("\nOprima enter para cerrar este programa...");
            Console.ReadKey();
        }
    }
}
