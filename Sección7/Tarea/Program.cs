using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //campos
            double monto, saldoInicial;
            int opcion = 0;
            string nombre, apellidos, direccion, rfc;


            //mensaje de cuenta nueva
            Console.WriteLine("Está a punto de crear una cuenta nueva, por favor precione cualquier tecla para continuar");
            Console.ReadKey();

            //creando una cuenta nueva
            Console.WriteLine ("\nIngrese la información que se solicita a continuación: \nNombre:");
            nombre = Console.ReadLine ();
            Console.WriteLine("Apellidos: ");
            apellidos = Console.ReadLine ();
            Console.WriteLine("Dirección: ");
            direccion = Console.ReadLine ();
            Console.WriteLine("RFC: ");
            rfc = Console.ReadLine ();
            Console.WriteLine("Ingrese su deposito inicial");
            saldoInicial = Convert.ToDouble(Console.ReadLine());

            //mensajes de confirmación
            CuentaBancaria cuenta1 = new CuentaBancaria(nombre,apellidos, direccion, rfc, saldoInicial);
            Console.WriteLine("Felicidades, su cuenta ha sido creada con exito, presione cualquier tecla para continuar");
            Console.ReadKey();

            //mostrar opciones de menú
            do
            {
                Console.WriteLine("\n1. Deposito\n2. Retiro\n3. Consultar Saldo\n4. Mostrar Información de la cuenta\n5. Salir");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("cuanto desea ingresar?");
                        monto= Convert.ToDouble(Console.ReadLine());
                        cuenta1.Deposito(monto);
                        cuenta1.ConsultaSaldo();
                        break;
                    case 2:
                        Console.WriteLine("cuanto desea retirar?");
                        monto = Convert.ToDouble(Console.ReadLine());
                        cuenta1.Retiro(monto);
                        cuenta1.ConsultaSaldo();
                        break;
                    case 3:
                        cuenta1.ConsultaSaldo();
                        break;
                    case 4:
                        Console.WriteLine(cuenta1.ToString());
                        break;

                }

            } while (opcion>=1 && opcion<=4);
                
            
            


        }
    }

    public class CuentaBancaria
    {
        //campos
        private string nombre, apellidos, direccion, rfc;
        private double saldo;

        //Métodos
        public CuentaBancaria(string nombre, string apellidos, string direccion, string rfc, double saldo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.rfc = rfc;
            this.saldo = saldo;
        }

        public double Deposito (double monto)
        {
            this.saldo+= monto;
            return saldo;
        }

        public double Retiro(double monto)
        {
            if (this.saldo > monto) 
            {
                this.saldo -= monto;
            }
            else
            {
                Console.WriteLine("El saldo es insuficiente");
            }
            return saldo;
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("El saldo de tu cuenta es: {0}", this.saldo);
        }

        public override string ToString()
        {
            string mensaje = "";
            mensaje = "\nTitular: " + this.nombre + " " + this.apellidos + "\nRFC:" + this.rfc + "\nDirección: " + this.direccion + "\nSaldo: $" + this.saldo;
            return mensaje;
        }
    }
}
