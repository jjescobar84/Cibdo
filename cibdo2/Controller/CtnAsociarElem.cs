using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CtnAsociarElem
    {
        Model.ModAsociarElem Model = new Model.ModAsociarElem();// Instancia al modelo

        //Controlador para la traer el tipo de elemento espacio
        public object ListarEspacio()
        {
            return Model.ListarEspacio();
        }

    }
}
