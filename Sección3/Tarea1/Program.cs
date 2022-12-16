using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    //Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            byte mes;

            //recolección de información
            Console.WriteLine("Escriba un número del 1 al 12");
            mes = Convert.ToByte(Console.ReadLine());

            //Solución del problema
            switch (mes)
            {
                case 1:
                    Console.WriteLine("el número corresponde al mes de Enero");
                    break;
                case 2:
                    Console.WriteLine("el número corresponde al mes de Febrero");
                    break;
                case 3:
                    Console.WriteLine("el número corresponde al mes de Marzo");
                    break;
                case 4:
                    Console.WriteLine("el número corresponde al mes de Abril");
                    break;
                case 5:
                    Console.WriteLine("el número corresponde al mes de Mayo");
                    break;
                case 6:
                    Console.WriteLine("el número corresponde al mes de Junio");
                    break;
                case 7:
                    Console.WriteLine("el número corresponde al mes de Julio");
                    break;
                case 8:
                    Console.WriteLine("el número corresponde al mes de Agosto");
                    break;
                case 9:
                    Console.WriteLine("el número corresponde al mes de Septiembre");
                    break;
                case 10:
                    Console.WriteLine("el número corresponde al mes de Octubre");
                    break;
                case 11:
                    Console.WriteLine("el número corresponde al mes de Noviembre");
                    break;
                case 12:
                    Console.WriteLine("el número corresponde al mes de Diciembre");
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}
