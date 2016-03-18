using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class modObjetos
    {
        DataClasses1DataContext db = new DataClasses1DataContext();// Instancia de la clase que tiene la conexion

        //Metodo para insertar
        public object insertOb(string nombre, string estado,int cantidad)
        {
            var inserto = db.insert_tb_Objeto( nombre,estado,cantidad);

            return inserto;
        }


        

    }
}
