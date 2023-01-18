using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class Conexion
    {
        private string @base;
        private string servidor;
        private string usuario;
        private string clave;
        private bool seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.@base = "dbsistema";
            this.servidor = "DESKTOP-N7SQCT8";
            this.usuario = "Steve";
            this.clave = "pony123"; 
            this.seguridad = true;
        }

        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.servidor + ";Database=" + this.@base + ";";

                cadena.ConnectionString += this.seguridad ? 
                    "Integrated Security = SSPI;":
                    "User Id=" + this.usuario + ";Password=" + this.clave + ";";

                /*
                if (this.seguridad)
                {
                    cadena.ConnectionString += "Integrated Security = SSPI;";
                }
                else
                {
                    cadena.ConnectionString += "User Id=" + this.usuario + ";Password=" + this.clave + ";";
                }
                */
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null) 
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
