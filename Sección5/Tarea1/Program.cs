using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    //Crear un método para transformar de grados a radianes
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double grad;

            Console.WriteLine("Cuál es el angulo en grados?");
            grad = double.Parse(Console.ReadLine());

            Console.WriteLine("El angulo {0} en grados equivale a {1} radianes", grad, Cambiar(grad));

        }

        static double Cambiar (double grad)
        {
            double rad = grad * 3.1415926535897931 / 180;;     
            return rad;
        }
    }
}
