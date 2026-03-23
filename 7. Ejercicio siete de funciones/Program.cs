using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Ejercicio_siete_de_funciones
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int MostrarDoble(int n)

            {
                return n + n;

            }

            Console.Write("Ingrese un numero entero positivo:_ ");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"El doble del número ingresado es: {MostrarDoble(num)}");

            














        }
    }
}
