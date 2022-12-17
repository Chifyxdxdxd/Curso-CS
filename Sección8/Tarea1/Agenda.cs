using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    //Al igual que en otro ejercicío voy a copiar el codigo dado por el profesor y agregar lo requerido para la tarea.

    //Agregar la opción (5. Actualizar contacto) al ejercicio con "Dictionary" de la agenda telefónica haciendo uso de la propiedad "Item[ ]".
    internal class Agenda
    {
        static void volverMenu()
        {
            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Variables necesarias
            int opcion;
            string nombre;
            long numero;

            //Instanciamos a la colección
            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();//limpiar la consola

                //Menú
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar contactos");
                Console.WriteLine("5. Actualizar contacto");

                Console.Write("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();//limpiar la consola

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);
                        Console.WriteLine("\n({0}) se ha agregado con exito", nombre);

                        volverMenu();
                        break;
                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\n¡Contacto encontrado!");

                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

                            volverMenu();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            volverMenu();
                        }
                        break;
                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);

                            Console.WriteLine("\n({0}) ha sido eliminado con exito", nombre);

                            volverMenu();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            volverMenu();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");

                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine("{0}: {1}", elemento.Key, elemento.Value);
                        }

                        volverMenu();
                        break;
                    case 5:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\n¡Contacto encontrado!");

                            Console.WriteLine("\nNuevo Numero para {0}:", nombre);
                            numero = Convert.ToInt64(Console.ReadLine());

                            contactos[nombre] = numero;

                            Console.WriteLine("\n({0}) se ha actualizado con exito", nombre);

                            volverMenu();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            volverMenu();
                        }
                        break;
                }

            } while (opcion >= 1 && opcion <= 5);
        }
    }
}
