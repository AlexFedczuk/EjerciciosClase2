using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase2
{
    internal class ClassEjemplo
    {
        public static int PedirNumeroInt(string mensaje)
        {
            string dataIngresada;
            int resultado;
            Console.WriteLine(mensaje);
            do
            {
                dataIngresada = Console.ReadLine();                
                if (Validador.ValidarNumeroTipoInt(dataIngresada))
                {
                    resultado = int.Parse(dataIngresada);
                    break;
                }
                Console.WriteLine("Intenta otra vez");
            }while (true);

            return resultado;
        }
    }
}
