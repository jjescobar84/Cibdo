using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class cntRecordatorio
    {
        
        
        Model.modRecordatorio clsmod = new Model.modRecordatorio();// Instancia a la clase del modelo
        
        // Metodo que me recibe el retorno del metodo consultar
        public object consultaRecorda()
        {
            return clsmod.traerRecordatorio();
        }
        // Metodo que me recibe el retorno del metodo insertar
        public object insertRe(string nombre, DateTime fecha, DateTime hora, string descripcion, int Persona_idPersona,string Tipo_recordatorio_descripcion)
        {
            return clsmod.insertRecordatorios(nombre, fecha, hora, descripcion, Persona_idPersona, Tipo_recordatorio_descripcion);
        }
        // Metodo que me recibe el retorno del metodo eliminar
        public object deleteRe(int idReco)
        {
            return clsmod.deleteRecordatorios(idReco);
        }
        // Metodo que me recibe el retorno del metodo asociar recordatorio
        public object selectTipoRe()
        {
            return clsmod.asociarRecordatorio();
        }
    }
   
}
