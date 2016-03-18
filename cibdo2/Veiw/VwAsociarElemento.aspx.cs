using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Veiw
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        Controller.CtnAsociarElem ctn = new Controller.CtnAsociarElem();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarEspacios();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ListarEspacios()
        {
            GridView1.DataSource = ctn.ListarEspacio();
            GridView1.DataBind();
        }

    }
}