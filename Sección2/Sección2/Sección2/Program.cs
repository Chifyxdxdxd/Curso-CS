using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sección2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Precalentar el horno");
            Console.WriteLine("2. Mezclar la harina y mantequilla");
            Console.WriteLine("3. Agregar azúcar y 1 huevo");
            Console.WriteLine("4. Amasar la mezcla");
            Console.WriteLine("5. Darles forma y colocar en la bandeja");
            Console.WriteLine("6. Hornear duarante 10 minutos");

            //C# por defecto deja "null" en las variables no inicializadas

            int numerosLibros, librosNiños, LibrosMatenáticas;

            double promedioFinal = 9.8;

            numerosLibros = 500;

            char salon;
            salon = 'A';

            String saludo = "Hola";

            decimal promedioExamenes = 8.5m;

            // Los comentarios son iguales a otros idiomas (java)

            // Para imprimir uan cadena de texto junto con unas variables usaremos los parentesis {} y el número de la variable que usaremos, esto inicia desde 0.

            double precioCamisa = 399;
            String colorCamisa = "Azul";

            Console.WriteLine("El precio de la camisa es: {0} y su color es: {1}", precioCamisa, colorCamisa);

            //opreaciones binearias y unitarias, necesitan de uno o dos operadores para poder realizarse. Igual que en el resto de lenguajes.

            // Se pueden crear operaciones en las ejecuciones de consola.
            int num1 = 4, num2 = 5;

            Console.WriteLine(num1 + num2);

            //Tambien se pueden concatenar cadenas, combinar (sumar) cadenas de texto.
            String nombre = "Santiago", apellido = "Rojas";

            Console.WriteLine(nombre + apellido + " cómo estas?");// al igual que en los otros lenguajes no crea un espacio entre la suma de las cadenas de texto.

            // El operador de modulo(resto) % es el resultado que sobra de la divición.

            // Las prioridades de las opreaciones aritméticas se manejan de la misma manera que en Java, Parentesis, gerarquia, orden (izq a derecha).

            //Para leer la información que nos da el usuario usaremos Console.ReadLine(), esta información sera leida como una cadena de texto.

            //La diferencia entre Console.Write y Console.WriteLine es la misma que System.Out.Print() y System.Out.Println() respectivamente. Completa la linea y realiza la siguiente escritura/lectura en otra linea.

            //Si queremos convertir un string qe leermos por la consola a un numero u otro tipo de variable usaremos la clase 'Convert'y alguno de sus metodos dependiendo del tipo de variable que se necesitemos.

            //Existe otra manera de hacer una conserión y es con el metodo Parse. La diferencia entre estos dos métodos es que el parse creara una excepción cuando no se pueda realizar la conversión y la clase Convert pondrá un 0 cuando no se pueda realiar la conversión.

            //Para ver todos los metodos e informacíon de los métodos y parametros que se quieren podemos consultar la documentación en la página https://learn.microsoft.com/es-es/dotnet/api/

            //El uso de los diagramas de flujo facilitan la escritura del codigo ya que permiten analizar el problema de forma gráfica para su posterior desarollo.
        }
    }
}