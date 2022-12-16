using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._2
{
    //Hacer un programa que transfome de grados Centigrados a grados Fahrenheit
    internal class Program
    {
        static void Main(string[] args)
        {//Declaración de variables
            double cel;

            //recopilación de la información
            Console.WriteLine("Cual es la cantidad en grados Celcius?");
            cel = Convert.ToDouble(Console.ReadLine());

            //Resolviendo el problema 

            Console.WriteLine("El equivalente en grados fahrenheit son: {0}", (cel * 9 / 5) + 32);
            Console.ReadLine();

        }
    }
}