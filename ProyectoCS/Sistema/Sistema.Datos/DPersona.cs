using System;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DPersona
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_listar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable ListarProveedores()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_listar_proveedores", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable ListarClientes()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_listar_clientes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon= Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_buscar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable BuscarProveedores(string Valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon= Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_buscar_proveedores", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable BuscarClientes(string Valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon= Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_buscar_clientes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string Existe(string Valor)
        {
            string respuesta = "";
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon= Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_existe", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;
        }

        public string Insertar(Persona obj)
        {
            string respuesta = "";
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon= Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_insertar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = obj.tipoPersona;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = obj.tipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = obj.numDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                sqlCon.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;
        }

        public string Actualizar(Persona obj)
        {
            string respuesta = "";
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon= Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_actualizar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = obj.idPersona;
                comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = obj.tipoPersona;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = obj.tipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = obj.numDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                sqlCon.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;
        }

        public string Eliminar(int Id)
        {
            string respuesta = "";
            SqlConnection sqlCon= new SqlConnection();
            try
            {
                sqlCon= Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("persona_eliminar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Id;
                sqlCon.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;
        }
    }
}
