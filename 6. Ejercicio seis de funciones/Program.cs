using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Ejercicio_seis_de_funciones
{
    internal class Program
    {
        static void Main(string[] args)

        {
            void Saludar(string nombre)

            {

                Console.WriteLine($"Hola {nombre}");

            }

            Console.Write("Ingrese su nombre:_ ");

            string persona = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Presione la tecla enter para ver lo que pasa");

            Console.ReadKey();

            Console.WriteLine();

            Saludar(persona);












        }
    }
}
