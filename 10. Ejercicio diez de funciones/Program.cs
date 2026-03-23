using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ejercicio_diez_de_funciones
{
    internal class Program
    {
        static void Main(string[] args)

        {
            void ImprimirRepetido(string texto, int veces)

            {
                for (int i = 0; i < veces; i++)

                {
                    Console.WriteLine($"{texto}");

                    Console.WriteLine();


                }

            }

            Console.Write("Escriba lo que quiera:_ ");

            string ingreso = Console.ReadLine();

            Console.WriteLine();

            Console.Write("¿Cuantas veces quiere que se repita el texto?");

            Console.WriteLine();

            Console.Write(":_ ");

            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Su texto repetido es:_");

            Console.WriteLine();

            ImprimirRepetido(ingreso, cantidad);



















        }
    }
}
