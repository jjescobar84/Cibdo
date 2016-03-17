using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Productos
    {
        int codProducto;
        string nombreProducto;
        decimal precioUnit;
        int catProducto;

        public int CatProducto
        {
            get { return catProducto; }
            set { catProducto = value; }
        }

        public decimal PrecioUnit
        {
            get { return precioUnit; }
            set { precioUnit = value; }
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public int CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }

         //Constructor valio

        public Productos()
        { }

        // Constructor con parámetros
        public Productos(int codigo, string nombre, decimal precio, int categorias)
        {
            codProducto = codigo;
            nombreProducto = nombre;
            precioUnit = precio;
            catProducto = categorias;
        }

        // Obtener todas los productos
        public DataTable obtenerProductos()
        {
            DataTable productos = new DataTable("tablaProductos");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cadenaconexion;
                SqlCommand sqlCmdCat = new SqlCommand();
                // Asignamos al comando en string de conexion
                sqlCmdCat.Connection = sqlCon;
                //Asignamos el del SP
                sqlCmdCat.CommandText = "Asociar_Categoria";
                // le decimos al comando que será un procedimiento almacenado
                sqlCmdCat.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlAdat = new SqlDataAdapter(sqlCmdCat);
                sqlAdat.Fill(productos);
            }
            catch (Exception)
            {

                throw;
            }

            return productos;
        }

        //Actualizar Productos
        public string ActualizarProductos(Productos ActProc)
        {
            string mensaje = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = Conexion.cadenaconexion;
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = conn;
                sqlCmd.CommandText = "Actualizar_Productos";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //Parámetros

                SqlParameter parCod = new SqlParameter();
                parCod.ParameterName = "@codProductos";
                parCod.SqlDbType = SqlDbType.Int;
                parCod.Value = ActProc.CodProducto;
                sqlCmd.Parameters.Add(parCod);


                SqlParameter parNom = new SqlParameter();
                parNom.ParameterName = "@nombre_producto";
                parNom.SqlDbType = SqlDbType.VarChar;
                parNom.Size = 50;
                parNom.Value = ActProc.nombreProducto;
                sqlCmd.Parameters.Add(parNom);

                SqlParameter parPre = new SqlParameter();
                parPre.ParameterName = "@precio_unitVenta";
                parPre.SqlDbType = SqlDbType.Decimal;
                parPre.Precision = 8;
                parPre.Scale = 0;
                parPre.Value = ActProc.PrecioUnit;
                sqlCmd.Parameters.Add(parPre);

                SqlParameter parCat = new SqlParameter();
                parCat.ParameterName = "@descripcionCat";
                parCat.SqlDbType = SqlDbType.Int;
                parCat.Value = ActProc.CatProducto;
                sqlCmd.Parameters.Add(parCat);


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
        public string InsertarProductos(Productos Proc)
        {
            string mensaje = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.cadenaconexion;
                con.Open();
                SqlCommand sqlCo = new SqlCommand();
                sqlCo.Connection = con;
                sqlCo.CommandText = "Insertar_Productos";
                sqlCo.CommandType = CommandType.StoredProcedure;

                SqlParameter parNom = new SqlParameter();
                parNom.ParameterName = "@nombre_producto";
                parNom.SqlDbType = SqlDbType.VarChar;
                parNom.Size = 50;
                parNom.Value = Proc.nombreProducto;
                sqlCo.Parameters.Add(parNom);

                SqlParameter parPre = new SqlParameter();
                parPre.ParameterName = "@precio_unitVenta";
                parPre.SqlDbType = SqlDbType.Decimal;
                parPre.Precision = 8;
                parPre.Scale = 0;
                parPre.Value = Proc.precioUnit;
                sqlCo.Parameters.Add(parPre);

                SqlParameter parCat = new SqlParameter();
                parCat.ParameterName = "@codCategoria";
                parCat.SqlDbType = SqlDbType.Int;
                parCat.Value = Proc.catProducto;
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

        //Eliminar Productos
        public string EliminarProductos(Productos proc)
        {
            string mensaje = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = Conexion.cadenaconexion;
                conn.Open();
                SqlCommand sqlCo = new SqlCommand();
                sqlCo.Connection = conn;
                sqlCo.CommandText = "Eliminar_Productos";
                sqlCo.CommandType = CommandType.StoredProcedure;

                SqlParameter parCod = new SqlParameter();
                parCod.ParameterName = "@codProductos";
                parCod.SqlDbType = SqlDbType.Int;
                parCod.Value = proc.CodProducto;
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
        }
        
        
    }
}
