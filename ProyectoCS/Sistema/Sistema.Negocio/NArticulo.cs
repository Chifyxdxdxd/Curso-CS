using Sistema.Datos;
using Sistema.Entidades;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema.Negocio
{
    public class NArticulo
    {
        public static DataTable Listar()
        {
            DArticulo datos = new DArticulo();
            return datos.Listar();
        }

        public static DataTable Buscar(string val)
        {
            DArticulo datos = new DArticulo();
            return datos.Buscar(val);
        }

        public static string Insertar(int idCategoria, string codigo, string nombre, decimal precioVenta, int stock, string descripcion, string imagen)
        {
            DArticulo datos = new DArticulo();
            string existe = datos.Existe(nombre);

            if (existe.Equals("1"))
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo obj = new Articulo();
                obj.idCategoria = idCategoria;
                obj.codigo = codigo;
                obj.nombre = nombre;
                obj.precioVenta = precioVenta;
                obj.stock = stock;
                obj.descripcion = descripcion;
                obj.imagen = imagen;
                return datos.Insertar(obj);
            }

        }

        public static string Actualizar(int id, int idCategoria, string codigo, string nombre, decimal precioVenta, int stock, string descripcion, string imagen)
        {
            DArticulo datos = new DArticulo();

            Articulo obj = new Articulo();
            obj.idArticulo = id;
            obj.idCategoria = idCategoria;
            obj.codigo = codigo;
            obj.nombre = nombre;
            obj.precioVenta = precioVenta;
            obj.stock = stock;
            obj.descripcion = descripcion;
            obj.imagen = imagen;
            return datos.Actualizar(obj);
        }

        public static string Eliminar(string id)
        {
            DArticulo datos = new DArticulo();
            return datos.Eliminar(id);
        }

        public static string Activar(string id)
        {
            DArticulo datos = new DArticulo();
            return datos.Activar(id);
        }

        public static string Desactivar(string id)
        {
            DArticulo datos = new DArticulo();
            return datos.Desactivar(id);
        }
    }
}
