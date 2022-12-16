using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    //Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo. Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos.
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num;
            Console.WriteLine("de cual figura quiere calcular el area?\n1. círculo\n2. cuadrado\n3. triangulo");
            num = Convert.ToByte(Console.ReadLine());

            switch (num)
            {
                case 1:
                    aCirculo();
                    break;
                case 2:
                    aCuadrado();
                    break;
                case 3:
                    aTriangulo();
                    break;
                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }
}

        static void aCirculo()
        {
            double diametro;
            Console.WriteLine("Cuál es el radio del círculo");
            diametro= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEl área del circulo es: {0}", diametro * diametro * 3.1415926535897931);
        }

        static void aTriangulo()
        {
            double ladob, altura;
            Console.WriteLine("Cuál es la base del triangulo?");
            ladob = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cuál es la altura del triangulo?");
            altura= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEl área del cuadrado es: {0}", ladob*altura/2);
        }

        static void aCuadrado()
        {
            double lado;
            Console.WriteLine("Cuál es el area del cuadrado?");
            lado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEl área del cuadrado es: {0}", lado * lado);
        }
    }
}
