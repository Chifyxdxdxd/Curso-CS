using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    //Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int num, exp;
            double res = 1;
            Boolean neg = false;

            //Recopilación de datos
            Console.WriteLine("Cual es la base?");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es el exponente?");
            exp = Convert.ToInt32(Console.ReadLine());

            //Desarollo del problema
            if (exp < 0) 
            {
                exp *= -1;
                neg = true;
            }
            if (exp != 0)
            {
                for (int i = 1; i <= exp; i++)
                {
                    res *= num;
                }
            }
            if (neg) {
                exp *= -1;
                Console.WriteLine("la potencia {0} ^ {1} es igual a 1/{2}", num, exp, res);
            }
            else
            {
                Console.WriteLine("la potencia {0} ^ {1} es igual a {2}", num, exp, res);
            }

            
        }
    }
}
