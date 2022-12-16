using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    //Crear un programa que calcule el perimetro de cualquier poligono regular
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int numL;
            double longL;

            //recopilación de la información
            Console.WriteLine("Cúántos lados tiene el poligono regular?");
            numL = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuál es la longitud de los lados del poligono?");
            longL = Convert.ToDouble(Console.ReadLine());

            //Resolviendo el problema 

            Console.WriteLine("\nEl perimero del poligono con {0} lados de longitud {1} es: {2}", numL, longL, numL * longL);

        }
    }
}