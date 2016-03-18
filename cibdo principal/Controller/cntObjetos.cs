using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
     public class cntObjetos
    {
         //Instancia a la clase del modelo 
        Model.modObjetos mod = new Model.modObjetos();
         //Metodo que me recibe el metodo del modelo para insertar datos
        public object objinsert(string nombre,string estado,int cantidad)
        {
            return mod.insertOb(nombre,estado,cantidad);
        }
           

    }
}
