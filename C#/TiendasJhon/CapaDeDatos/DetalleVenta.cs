using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
   public class DetalleVenta
    {
       private int var_codigoVenta;
       private int var_codigoProducto;
       private decimal var_cantidad;
       private decimal var_descuento;

       //Constructor vacio
       public DetalleVenta()
       {

       }

       //Constructor con parametros
       public DetalleVenta(
           int codigoVenta,
           int codigoProducto,
           decimal cantidad,
           decimal descuento
       )
       {
           this.var_codigoVenta = codigoVenta;
           this.var_codigoProducto = codigoProducto;
           this.var_cantidad = cantidad;
           this.var_descuento = descuento;
       }

       //Metodo utilizado para insertar un DetalleVenta
       //Le pasamos la conexion y la transaccion por referencia, debido a que esos datos lo obtenemos
       //de la clase Venta y no deberiamos crear una nueva Conexion o una nueva Transaccion
       //sino la creada por la clase Venta
       public string Insertar(DetalleVenta varDetalleVenta, ref SqlConnection sqlCon, ref SqlTransaction sqlTra)
       {
           string rpta = "";
           try
           {
               //1. Establecer el comando
               SqlCommand sqlCmd = new SqlCommand();
               sqlCmd.Connection = sqlCon;
               sqlCmd.Transaction = sqlTra;
               sqlCmd.CommandText = "sp_Ins_DetalleVenta";
               sqlCmd.CommandType = CommandType.StoredProcedure;

               //4. Agregar los parametros al comando
               //Establecemos los valores para el parametro @codigoVenta del Procedimiento Almacenado
               SqlParameter sqlParcodigoVenta = new SqlParameter();
               sqlParcodigoVenta.ParameterName = "@codCompVenta";
               sqlParcodigoVenta.SqlDbType = SqlDbType.Int;
               sqlParcodigoVenta.Value = varDetalleVenta.codigoVenta;
               sqlCmd.Parameters.Add(sqlParcodigoVenta); //Agregamos el parametro al comando
               //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
               SqlParameter sqlParcodigoProducto = new SqlParameter();
               sqlParcodigoProducto.ParameterName = "@codProducto";
               sqlParcodigoProducto.SqlDbType = SqlDbType.Int;
               sqlParcodigoProducto.Size = 4;
               sqlParcodigoProducto.Value = varDetalleVenta.codigoProducto;
               sqlCmd.Parameters.Add(sqlParcodigoProducto); //Agregamos el parametro al comando
               //Establecemos los valores para el pprtarametro @cantidad del Procedimiento Almacenado
               SqlParameter sqlParcantidad = new SqlParameter();
               sqlParcantidad.ParameterName = "@cantidad";
               sqlParcantidad.SqlDbType = SqlDbType.Decimal;
               sqlParcantidad.Precision = 18;
               sqlParcantidad.Scale = 2;
               sqlParcantidad.Value = varDetalleVenta.cantidad;
               sqlCmd.Parameters.Add(sqlParcantidad); //Agregamos el parametro al comando


               //5. Ejecutamos el commando
               rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el detalle de venta de forma correcta";

           }
           catch (Exception ex)
           {
               rpta = ex.Message;
           }
           return rpta;
       }

       #region Metodos Get y Set
       public int codigoVenta
       {
           get { return var_codigoVenta; }
           set { var_codigoVenta = value; }
       }
       public int codigoProducto
       {
           get { return var_codigoProducto; }
           set { var_codigoProducto = value; }
       }
       public decimal cantidad
       {
           get { return var_cantidad; }
           set { var_cantidad = value; }
       }
       public decimal descuento
       {
           get { return var_descuento; }
           set { var_descuento = value; }
       }
       #endregion
    }
}
