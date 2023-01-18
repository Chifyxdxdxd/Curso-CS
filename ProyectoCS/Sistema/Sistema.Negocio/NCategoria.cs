﻿using Sistema.Datos;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Negocio
{
    public class NCategoria
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

        public static string Insertar(string nombre, string descripcion)
        {
            DArticulo datos = new DArticulo();
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
            DArticulo datos = new DArticulo();
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
            DArticulo datos = new DArticulo();
            return datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DArticulo datos = new DArticulo();
            return datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DArticulo datos = new DArticulo();
            return datos.Desactivar(id);
        }
    }
}
