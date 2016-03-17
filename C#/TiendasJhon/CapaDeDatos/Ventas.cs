using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Ventas
    {
        
        private int var_codVenta;
        private string var_cliente;
        private int var_caja;
        private DateTime var_fecha;
        private decimal var_descuento;
        private decimal var_totalVenta;
        #region

        public decimal Var_totalVenta
        {
            get { return var_totalVenta; }
            set { var_totalVenta = value; }
        }

        public decimal Var_descuento
        {
            get { return var_descuento; }
            set { var_descuento = value; }
        }

        public DateTime Var_fecha
        {
            get { return var_fecha; }
            set { var_fecha = value; }
        }

        public int Var_caja
        {
            get { return var_caja; }
            set { var_caja = value; }
        }

        public string Var_cliente
        {
            get { return var_cliente; }
            set { var_cliente = value; }
        }

        public int Var_codVenta
        {
            get { return var_codVenta; }
            set { var_codVenta = value; }
        }

        #endregion

        //Constructor vacio
        public Ventas()
        {

        }

        //Constructor con parámetros
        public Ventas(int codigoVenta, string cliente, int caja, DateTime fecha, decimal descuento, decimal totalVenta)
        {
            this.Var_codVenta = codigoVenta;
            this.Var_cliente = cliente;
            this.Var_caja = caja;
            this.Var_fecha = fecha;
            this.Var_descuento = descuento;
            this.Var_totalVenta = totalVenta;
        }

        //Metodo utilizado para crear una venta
        public string InsertarVenta(Ventas varVenta, List<DetalleVenta> detalles)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try 
	        {	        
		        sqlcon.ConnectionString = Conexion.cadenaconexion;
                sqlcon.Open();
                SqlTransaction sqlTra = sqlcon.BeginTransaction();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.Transaction = sqlTra;
                sqlCmd.CommandText = "sp_Ins_Venta";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //Agregar parámetros
                SqlParameter parCodVen = new SqlParameter();
                parCodVen.ParameterName = "@codVenta";
                parCodVen.SqlDbType = SqlDbType.Int;
                parCodVen.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parCodVen);

                SqlParameter parCli = new SqlParameter();
                parCli.ParameterName = "@cliente";
                parCli.SqlDbType = SqlDbType.VarChar;
                parCli.Size = 100;
                parCli.Value = varVenta.Var_cliente;
                sqlCmd.Parameters.Add(parCli);

                SqlParameter parCaja = new SqlParameter();
                parCaja.ParameterName = "@Caja";
                parCaja.SqlDbType = SqlDbType.Int;
                parCaja.Value = varVenta.Var_caja;
                sqlCmd.Parameters.Add(parCaja);

                SqlParameter parDes = new SqlParameter();
                parDes.ParameterName = "@Descuento";
                parDes.SqlDbType = SqlDbType.Decimal;
                parDes.Precision = 8;
                parDes.Scale = 0;
                parDes.Value = varVenta.Var_descuento;
                sqlCmd.Parameters.Add(parDes);


                SqlParameter parTotal = new SqlParameter();
                parTotal.ParameterName = "@VlrTotalVenta";
                parTotal.SqlDbType = SqlDbType.Decimal;
                parTotal.Precision = 10;
                parTotal.Scale = 0;
                parTotal.Value = varVenta.Var_descuento;
                sqlCmd.Parameters.Add(parTotal);

                //Ejecutamos el comando
                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el detalle de venta";
                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo de la venta que se generó por la base de datos
                    this.Var_codVenta = Convert.ToInt32(sqlCmd.Parameters["@codVenta"].Value);
                    foreach (DetalleVenta  det in detalles)
                    {
                        //Establecemos el código de la venta que se autogeneró
                        det.codigoVenta = this.Var_codVenta;
                        rpta = det.Insertar(det, ref sqlcon, ref sqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;//Se ocurre algun error al insertar nos salimos del for
                        }
                    }
                    
                }
                if (rpta.Equals("OK"))
                {
                    sqlTra.Commit();//Se inserto todo los detalles y confirmamos la transaccion
                }
                else
                {
                    sqlTra.Rollback();//Algun detalle no inserto y negamos la transanccion
                }
	        }
	        catch (Exception ex)
	        {
                rpta = ex.Message; 
	   	    }
                finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

    }
}
