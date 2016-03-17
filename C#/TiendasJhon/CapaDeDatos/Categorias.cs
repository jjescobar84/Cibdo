using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
   public class Categorias
    {
        int codCategoria;
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int CodCategoria
        {
            get { return codCategoria; }
            set { codCategoria = value; }
        }
        
        //Constructor valio

        public Categorias()
        { }

        // Constructor con parámetros
        public Categorias(int codigo, string des)
        {
            codCategoria = codigo;
            descripcion = des;
        }

        // Obtener todas las categorias
        public DataTable obtenerCategoria()
        {
            DataTable categorias = new DataTable("TablaCategoria");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cadenaconexion;
                SqlCommand sqlCmdCat = new SqlCommand();
                // Asignamos al comando en string de conexion
                sqlCmdCat.Connection = sqlCon;
                //Asignamos el del SP
                sqlCmdCat.CommandText = "Mostrar_Categoria";
                // le decimos al comando que será un procedimiento almacenado
                sqlCmdCat.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlAdat = new SqlDataAdapter(sqlCmdCat);
                sqlAdat.Fill(categorias);
            }
            catch (Exception)
            {
                
                throw;
            }

            return categorias;
        }

       //Actualizar categorias
       public string ActualizarCategoria(Categorias CatCons)
        {
            string mensaje = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = Conexion.cadenaconexion;
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = conn;
                sqlCmd.CommandText = "Actualizar_Categorias";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //Parámetros
                SqlParameter parCod = new SqlParameter();
                parCod.ParameterName = "@codCategoria";
                parCod.SqlDbType = SqlDbType.Int;
                parCod.Value = CatCons.CodCategoria;
                sqlCmd.Parameters.Add(parCod);

                SqlParameter parDes = new SqlParameter();
                parDes.ParameterName = "@descripcionCat";
                parDes.SqlDbType = SqlDbType.VarChar;
                parDes.Size = 50;
                parDes.Value = CatCons.Descripcion;
                sqlCmd.Parameters.Add(parDes);

                mensaje = sqlCmd.ExecuteNonQuery() == 0 ? "OK" : "No se actualizo";
            }
            catch (Exception exc)
            {

                mensaje += exc.Message;
            }
           finally
            { if (conn.State == ConnectionState.Open) conn.Close(); }
            return mensaje;     
	{
		 
	}
        }

       // insertar datos
       public string InsertarCategoria (Categorias Cat)
       {
           string mensaje = "";
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = Conexion.cadenaconexion;
               con.Open();
               SqlCommand sqlCo = new SqlCommand();
               sqlCo.Connection = con;
               sqlCo.CommandText = "Insertar_Categorias";
               sqlCo.CommandType = CommandType.StoredProcedure;

               SqlParameter parCat = new SqlParameter();
               parCat.ParameterName = "@descripcionCat";
               parCat.SqlDbType = SqlDbType.VarChar;
               parCat.Size = 50;
               parCat.Value = Cat.Descripcion;
               sqlCo.Parameters.Add(parCat);

               mensaje = sqlCo.ExecuteNonQuery() == 0 ? "OK" : "No se pudo guardar";

           }
           catch (Exception Exc)
           {
               mensaje += Exc.Message;
           }
           finally
           { if (con.State == ConnectionState.Open) con.Close(); }
           return mensaje;
       }

       /*Eliminar Categorias

       public string EliminarCategoria (Categorias CatCon)
       {
           string mensaje = "";
           SqlConnection conn = new SqlConnection();
           try
           {
               conn.ConnectionString = Conexion.cadenaconexion;
               conn.Open();
               SqlCommand sqlCo = new SqlCommand();
               sqlCo.Connection = conn;
               sqlCo.CommandText = "Eliminar_Categoria";
               sqlCo.CommandType = CommandType.StoredProcedure;

               SqlParameter parCod = new SqlParameter();
               parCod.ParameterName = "@codCategoria";
               parCod.SqlDbType = SqlDbType.Int;
               parCod.Value = CatCon.CodCategoria;
               sqlCo.Parameters.Add(parCod);

               mensaje = sqlCo.ExecuteNonQuery() == 0 ? "OK" : "No se elimino correctamente";
           }
           catch (Exception exc)
           {
               mensaje += exc.Message;
           }
           finally
            { if (conn.State == ConnectionState.Open) conn.Close(); }
            return mensaje;  
       }*/
    }
}
