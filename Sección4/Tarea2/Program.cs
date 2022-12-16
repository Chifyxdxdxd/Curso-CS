using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        //Hacer un programa que calcule los números primos que existen entre el 1 y el 100.
        static void Main(string[] args)
        {
            //Declaración de variables
            int numDiv = 0;

            for (int num = 2; num <= 100; num++)//no es necesario crear el iterador fuera del cliclo
            {

                for (int div = 1; div <= num; div++)
                {
                    if ((num % div) == 0)
                    {
                        numDiv += 1;
                    }
                }

                if (numDiv <= 2)
                {
                    Console.WriteLine("numero primo: {0}", num);
                }
                numDiv = 0;
            }
        }
    }
}
