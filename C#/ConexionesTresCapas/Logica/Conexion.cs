using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Conexion
    {
        string mensaje; //Para guardar la respuesta de la base de datos
        //Almacenar la conexion
        SqlConnection conexion;
        // SqlTransaction
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        //Conexion a Sql
        public Conexion()
        {
            string cadenaconexion = "Data Source=P7AULA4-PC06; Initial Catalog= db_proyecto; Integrated Security= true";
            conexion = new SqlConnection(cadenaconexion);
        }
        //Consultas
        public DataSet ConsultasSQL(string SentenciaSQL)
        {
            try
            {
                conexion.Open();//Abrimos la conexion
                SqlDataAdapter objRes = new SqlDataAdapter(SentenciaSQL,conexion);// Parametros para ejecutar SQL
                //REcibir resultado de la consulta
                DataSet datos = new DataSet();
                //Transferir lo que generó SQL a mi DataSet
                objRes.Fill(datos, "TablaConsultada");
                mensaje = "La consulta de datos fue exitosa";
                return datos;
            }
            catch (Exception exc)
            {
                DataSet datos2 = new DataSet();
                mensaje = "ERROR: " + exc.Message;
                return datos2;
            }
            finally { conexion.Close(); }
        }
        //Alteracion de las tablas (Insert,Delete,Update)
        public bool EjecutarSQL(string SentanciaSQL)
        {
            try
            {
                conexion.Open();
                SqlCommand miComando = new SqlCommand();
                miComando.Connection = conexion;
                miComando.CommandText = SentanciaSQL;
                miComando.ExecuteNonQuery();
                mensaje = "Proceso ejecutado correctamente";
                return true;
            }
            catch (Exception Exc)
            {
                mensaje = "ERROR: " + Exc.Message;
                return false;
               
            }
            finally { conexion.Close(); }
        }
    }
}
