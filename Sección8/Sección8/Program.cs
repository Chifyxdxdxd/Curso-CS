using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sección8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Object
             * 
             * La clase object permite almacenar cualquier tipo de variable en él, tiene una particularidad y es que los objetos en caso de ser numero no podremos sumarlos de una forma tan sencilla.
             * Ya que no es posible sumar un número con un objeto .
             * Existe la conversíón de datos de forma implicita y explicita.
             * Hay una lista de valores que podremos convertir de forma implicita (sin especificar la conversión) y otros que podemos convertir de forma explicita (escribiendo el tipo al cual realizaremos la conversión.
             * https://learn.microsoft.com/es-mx/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions
             * 
             * conversión tipo Boxing [tipo de valor -> object]
             * conversión tipo unboxing [object -> tipo de valor]
             */

            /* Genericos
             * 
             * los genéricos son clases, estructuras, interfaces y m''etodos que tienen parámetros de tipo
             * 
             * caracteristicas:
             *  - Maximizamos la reutilización de código
             *  - Un mejor rendimiento
             *  - Podemos crear nuestras propias interfaces, clases, métodos, eventos y delegados genéricos
             *  - Creación de colecciones
             *  - Parecidas a las plantillas de C++
             */

            /* list <T>
             *  es una lista de elementos genericos, es decir, sin tipo especificado, se almacenan como un tipo objeto.
             *  para agregar un objeto usaremos el metodo .add(tipo objeto) este será agregado al final de la lista.
             *  con el metodo Count obtenemos el número de elementos incluidos en list<T>
             *  el el ciclo foreach (el último que faltaba ver) se repite para cada uno de los elementos de una agrupación de datos, bien sea una matriz (no tengo claro si unidimencional solamente) o una lista.
             *  otra forma de agragar objetos a la lista y escoger la ubicación dónde es colocado es el método Insert(index, item) Hay que tener en cuenta que los lugares comienzan desde el 0.
             *  otros metodos estan en la página https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
             */

            /* Stack <T>
             * 
             * Stack es otra colección genérica con sus propias caracteristicas.
             * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-7.0
             */

            /* Queue <T>
             * 
             * otra colección genérica.
             * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-7.0
             */

            //la propiedad item[] no me quedo clara ni leyendo la api ni con el video

            /* Dictionary <Tkey,Tvalue>
             * otra colección genérica
             * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-7.0
             */
        }
    }
}
