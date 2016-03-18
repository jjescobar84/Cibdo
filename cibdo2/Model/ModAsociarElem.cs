using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModAsociarElem
    {
        //conexion a la base
        DataClasses1DataContext conn = new DataClasses1DataContext();

        // Listar los tipos de espacio
        public object ListarEspacio()
        {
            var ListarEsp = conn.Listar_Espacios();
            return ListarEsp;
        }
    }
}
