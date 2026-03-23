using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Ejercicio_nueve_de_funciones
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int SumarMostrar(int a, int b)

            {
                return a + b;


            }

            Console.Write("Ingrese primer operando:_ ");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Ingrese segundo operando:_ ");

            int y = int.Parse(Console.ReadLine());  

            Console.WriteLine();

            Console.WriteLine($"El resultado de la suma es:_ {SumarMostrar(x,y)}");
            






        }
    }
}
