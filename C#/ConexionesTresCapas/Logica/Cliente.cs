using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Cliente:Conexion
    {
        long codCliente;
        string nitCedula;
        string nombreRazon;
        string telefono;
        string direccion;

        public long CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public string NitCedula
        {
            get { return nitCedula; }
            set { nitCedula = value; }
        }


        public string NombreRazon
        {
            get { return nombreRazon; }
            set { nombreRazon = value; }
        }


        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        //Consulta

        public DataSet ConsultarClientePorNitCed(string nitCedula)
        {
            string cadenaSqlConsultar = "SELECT * FROM tb_Clientes where cedulaNit_cliente ='" + nitCedula+"'";
            DataSet ConsultaResultante = ConsultasSQL(cadenaSqlConsultar);
            return ConsultaResultante;
        }

        public DataSet ConsultarTodosCliente()
        {
            string cadenaSqlConsultar = "SELECT * FROM tb_Clientes";
            DataSet ConsultaResultante = ConsultasSQL(cadenaSqlConsultar);
            return ConsultaResultante;
        }

        public bool InsertarClientes(string nitCedula, string nombreRazon, string telefono, string direccion)
        {
            string cadenaInsertar = "INSERT INTO tb_Clientes VALUES ('"+nitCedula+"', '"+nombreRazon+"', '"+telefono+"','"+direccion+"')";
            bool InsertResultante = EjecutarSQL(cadenaInsertar);
            return InsertResultante;
        }

        public bool ModificarClientes(string nitCedula, string nombreRazon, string telefono, string direccion)
        {
            string cadenaSqlModificar = "UPDATE tb_Clientes SET  nombre_razonsocial = '"+nombreRazon+"', telefono='"+telefono+"', direccion='"+direccion+"' WHERE cedulaNit_cliente = '"+nitCedula+"'";
            bool ModificarResultante = EjecutarSQL(cadenaSqlModificar);
            return ModificarResultante;
        }

        public bool EliminarCliente(string nitCedula)
        {
            string cadenaSqleliminar = "DELETE FROM tb_Clientes WHERE cedulaNit_cliente= '"+nitCedula+"'";
            bool EliminarResultante = EjecutarSQL(cadenaSqleliminar);
            return EliminarResultante;
        }
    }
}
