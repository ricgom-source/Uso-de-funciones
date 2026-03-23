using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Ejercicio_ocho_de_funciones
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
            int MostrarCuadrado(int n)

            {
                return n * n;

            }

            Console.Write("Ingrese un número entero positivo:_ ");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"El cuadrado de el número ingresado es: {MostrarCuadrado(num)}");









        }
    }
}
