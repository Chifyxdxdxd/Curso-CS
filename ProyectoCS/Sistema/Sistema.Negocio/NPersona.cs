using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona datos = new DPersona();
            return datos.Listar();
        }
        public static DataTable ListarProveedores()
        {
            DPersona datos = new DPersona();
            return datos.ListarProveedores();
        }

        public static DataTable ListarClientes()
        {
            DPersona datos = new DPersona();
            return datos.ListarClientes();
        }

        public static DataTable Buscar(string valor)
        {
            DPersona datos = new DPersona();
            return datos.Buscar(valor);
        }
        public static DataTable BuscarProveedores(string valor)
        {
            DPersona datos = new DPersona();
            return datos.BuscarProveedores(valor);
        }
        public static DataTable BuscarClientes(string valor)
        {
            DPersona datos = new DPersona();
            return datos.BuscarClientes(valor);
        }
        public static string Insertar(string tipoPersona, string nombre, string tipoDocumento, string numDocumento, string direccion, string telefono, string email)
        {
            DPersona datos = new DPersona();

            string Existe = datos.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "La persona ya existe.";
            }
            else
            {
                Persona obj = new Persona();
                obj.tipoPersona = tipoPersona;
                obj.nombre = nombre;
                obj.tipoDocumento = tipoDocumento;
                obj.numDocumento = numDocumento;
                obj.direccion = direccion;
                obj.telefono = telefono;
                obj.email = email;
                return datos.Insertar(obj);
            }
        }

        public static string Actualizar(int Id, string TipoPersona,string NombreAnt, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona datos = new DPersona();
            Persona obj = new Persona();

            if (NombreAnt.Equals(Nombre))
            {
                obj.idPersona = Id;
                obj.tipoPersona = TipoPersona;
                obj.nombre = Nombre;
                obj.tipoDocumento = TipoDocumento;
                obj.numDocumento = NumDocumento;
                obj.direccion = Direccion;
                obj.telefono = Telefono;
                obj.email = Email;
                return datos.Actualizar(obj);
            }
            else
            {
                string Existe = datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "Una persona con ese nombre ya existe.";
                }
                else
                {
                    obj.idPersona = Id;
                    obj.tipoPersona = TipoPersona;
                    obj.nombre = Nombre;
                    obj.tipoDocumento = TipoDocumento;
                    obj.numDocumento = NumDocumento;
                    obj.direccion = Direccion;
                    obj.telefono = Telefono;
                    obj.email = Email;
                    return datos.Actualizar(obj);
                }
            }

        }

        public static string Eliminar(int Id)
        {
            DPersona datos = new DPersona();
            return datos.Eliminar(Id);
        }
    }
}
