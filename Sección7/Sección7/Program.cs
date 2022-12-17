using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sección7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Entre los miembros de la clase tenemos
             * Datos:
             *  - Campos, son variables que se ubican en la clase, no en los métodos
             *  - Constantes
             * Comportamiento:
             *  - Propiedades
             *  - Métodos
             *  - Constructores
             *  - Finalizadores
             */

            /* Además de los miembros de clase tenemos los tipos de clase.
             * De valor:
             *  - Estructura 
             *  - Enumeración
             *  - Némericos integrales
             *  - Númericos de tipo flotante
             *  - Booleanos
             *  - Char
             *  - Tuplas
             * De referencia:
             *  - Clases
             *  - Interfaces
             *  - Delegados
             *  - Record
             */

            //Las clases tienen niveles de accesibilidad, las cuales permiten usar o madificar los valores o usa los metodos.
            /* Entre los niveles de accesibilidiad tenemos 4 moddificadores y 6 niveles de accesibilidad.
             * Modificadores:
             *  - Public
             *  - Protected
             *  - internal
             *  - Private
             * Niveles de accesibilidad:
             *  - Public
             *  - Protected
             *  - internal
             *  - Private
             *  - Protected internal
             *  - Private Protected
             */

            //Para este curso veremos private y publico, por ahora

            //El uso de static cambia los valores del objeto a la clase, es decir, ese método no es especifico de los objetos y estos no pueden usarlos, es la clase la que debe usar los métodos estaticos

            // Hay dos tipos de memoria, stack y heap. Ejemplo de las cajas amontonadas o puestas en forma de torre.

            // el uso de metodos getters an setters para modificar los campos de un objeto y mantener la privacidad de este.

            // Los metodos get y set si cambias en su escritura comparado con Java. Es posible poner el get y set en el mismo método de la clase. 

            /* MIEMBROS EN FORMA DE EXPRESIÓN 
             * Es una forma de escribir los set y get de una clase. 
             * de la forma normal tendremos que usar:
             * 
             *          set {campo = value;} 
             *          get {return campo;}
             *          
             * Mientras que de la forma de expresión usaremos:
             *          
             *          set => campo = value;
             *          get => campo;
             *          
             * solo hay una expresión para modificar es mejor usar esta forma, mientras que si hay que modificar varios campos es mejor usar la primera forma (bloque de codigo) para que no marque error.
             */
            
            // El método ToString transforma un objeto en una cadena de texto. Al igual que en Java existe el override, pero se usa diferente, no se usa con un @ y encima dle método.

            /* en Java
             *          @override 
             *          privacidad tipo nombre (parametros){
             *              bloque de codigo
             *              return; de ser necesario
             *          }
             * 
             * en C#
             *          privacidad override tipo nombre (parametros)
             *          {
             *              bloque de código
             *          }
             */
            
            //La sobre carga de métodos no cambia
        }

        

    }
}
