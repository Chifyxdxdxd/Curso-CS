using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    //Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00.
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            double num;

            //recolección de información
            Console.WriteLine("Cuantos minutos ha permanecido en el parqueadero?");
            num = Convert.ToDouble(Console.ReadLine());

            //Solución del problema

            if (num >= 0)
            {
                if (num > 60)
                {
                    if (num > 120)
                    {
                        Console.WriteLine("El saldo a pagar es de $40.00");
                    }
                    else
                    {
                        Console.WriteLine("El saldo a pagar es de $15.00");
                    }
                }
                else
                {
                    Console.WriteLine("El saldo a pagar es de $5.00");
                }
            }
            else
            {
                Console.WriteLine("Número no valido");
            }
        }
    }
}
