using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosClase2;

namespace EjerciciosClase2
{
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool resultado = false;

            if (valor >= min && valor <= max)
            {
                Console.WriteLine("INGRESO AL IF");
                resultado = true;
            }
            else
            {
                Console.WriteLine("NO INGRESO AL IF!!!");
            }

            return resultado;
        }

        public static bool ValidarNumeroTipoInt(string dataIngresada)
        {
            bool resultado = false;
            //int numeroIngresado = int.TryParse(dataIngresada);
            int numeroIngresado;

            if (int.TryParse(dataIngresada, out numeroIngresado))
            {
                Console.WriteLine($"\nSe ingreso el numero: {numeroIngresado}");
                resultado = true;
            }
            else
            {
                Console.WriteLine($"\nError! Lo ingresado no e un numero entero. Se ingreso esto: {dataIngresada}");
            }

            return resultado;
        }

        public static bool ValidarRespuesta(string dataIngresada)
        {
            bool resultado = false;

            if (!string.IsNullOrEmpty(dataIngresada) && dataIngresada.Length == 1)
            {
                if(dataIngresada == "s" || dataIngresada == "S")
                {
                    Console.WriteLine($"Se ingreso una respuesta correcta! Respuesta: {dataIngresada}");
                }
                resultado = true;
            }
            else
            {
                Console.WriteLine($"ERROR! Se ha ingresado un valor invalido como respuesta.\nRespuesta ingresada: {dataIngresada}");
            }

            return resultado;
        }
    }
}
