using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class modRecordatorio
    {

        DataClasses1DataContext dt = new DataClasses1DataContext();//Instancia a la clase que tiene la conexion
        
        //Metodo para consultar
        public object traerRecordatorio()
        {
            var traeRecor = dt.select_tb_Recordatorios();
            return traeRecor;
        }


        //Metodo para insertar
        public object insertRecordatorios( string nombre, DateTime fecha, DateTime hora, string descripcion, int Persona_idPersona, string Tipo_recordatorio_descripcion )
        {
            var insert = dt.insert_tb_Recordatorios(nombre,fecha,hora, descripcion,  Persona_idPersona, Tipo_recordatorio_descripcion);
            return insert;
        }

        //Metodo paraeliminar
        public object deleteRecordatorios(int idRec)
        {
            var DeleteReco = dt.delete_recordatorio(idRec);
            return DeleteReco;
        }

        //Metodo para asociar un tipo de recordatorio
        public object asociarRecordatorio( )
    {
        var SelectReco = dt.select_tipo_recordatorio();
        return SelectReco;
    }



        // public void ubdateRecordatorios (int idRec)
        //{
        //    var UpdateReco = dt.update_Recordatorios(int idRec);
        //    return UpdateReco;
        //}
            


    }
}
