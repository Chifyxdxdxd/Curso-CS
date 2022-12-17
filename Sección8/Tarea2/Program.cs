using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tarea2
{
    /*Crear un programa que simule una app bancaria sencilla, y que nos permita tres cosas:

       - Ingresar un gasto

       - Mostrarnos todos los gastos que hemos hecho, empezando por el último

       - Sumar todos los gastos hechos y mostrarnos el monto que debemos pagar (pago para no generar intereses)

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables necesarias
            int opcion;

            //Instanciamos a la colección
            Dictionary<string, double> cBancaria = new Dictionary<string, double>();

            do
            {
                Console.Clear();//limpiar la consola

                //Menú
                Console.WriteLine("1. Agregar gasto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Sumar gastos");

                Console.Write("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();//limpiar la consola

                switch (opcion)
                {
                    case 1:
                        AgregarGasto(ref cBancaria);
                        VolverMenu();
                        break;
                    case 2:
                        MostrarGastos(cBancaria);
                        VolverMenu();
                        break;
                    case 3:
                        SumarGastos(cBancaria);
                        VolverMenu();
                        break;
                }
            } while(opcion<=3 && opcion>=1);
        }

        private static void SumarGastos(Dictionary<string, double> cBancaria)
        {
            double sumaGastos = 0;
            foreach (KeyValuePair<string, double> elemento in cBancaria)
            {
                sumaGastos += elemento.Value;
            }
            Console.WriteLine("El total a pagar es: ${0}", sumaGastos);
        }

        static void AgregarGasto(ref Dictionary<string, double> cBancaria)
        {
            string gasto;
            double monto;
            Console.Write("Nombre del gasto: ");
            gasto = Console.ReadLine();

            Console.Write("Monto: ");
            monto = Convert.ToDouble(Console.ReadLine());

            cBancaria.Add(gasto, monto);
            Console.WriteLine("\n({0}) se ha agregado con exito", gasto);
        }

        static void MostrarGastos(Dictionary<string, double> cBancaria) 
        {
            int i = 1;
            Console.WriteLine("Gastos hasta el momento:\n");
            foreach (KeyValuePair<string, double> elemento in cBancaria)
            {
                Console.WriteLine("{0}. {1}: ${2}",i++, elemento.Key, elemento.Value);
            }
        }

        static void VolverMenu()
        {
            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
            Console.ReadKey();
        }
    }
}
