using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    //Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            int num;

            //recolección de información
            Console.WriteLine("Escriba un número");
            num = Convert.ToInt32(Console.ReadLine());

            //Solución del problema

            if ((num % 2) == 0)
            {
                Console.WriteLine("El numero {0} es par", num);
            }
            else
            {
                Console.WriteLine("El numero {0} es impar", num);
            }
        }
    }
}
