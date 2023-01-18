using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NCategoria
    {

        public static DataTable Listar() 
        { 
            DCategoria datos = new DCategoria();
            return datos.Listar(); 
        }

        public static DataTable Buscar(string val)
        {
            DCategoria datos = new DCategoria();
            return datos.Buscar(val);
        }

        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria datos = new DCategoria();
            string existe  = datos.Existe(nombre);

            if (existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.nombre = nombre;
                obj.descripcion = descripcion;
                return datos.Insertar(obj);
            }
            
        }

        public static string Actualizar(int id, string nombre, string descripcion)
        {
            DCategoria datos = new DCategoria();
            string existe = datos.Existe(nombre);

            if (existe.Equals("0"))
            {
                return "La categoría no existe";
            }
            else
            {

                Categoria obj = new Categoria();
                obj.idCategoria = id;
                obj.nombre = nombre;
                obj.descripcion = descripcion;
                return datos.Actualizar(obj);
            }
        }

        public static string Eliminar(int id)
        {
            DCategoria datos = new DCategoria();
            return datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DCategoria datos = new DCategoria();
            return datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DCategoria datos = new DCategoria();
            return datos.Desactivar(id);
        }
    }
}
