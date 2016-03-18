using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class InsertObjetos : System.Web.UI.Page
    {
        Controller.cntObjetos insert = new Controller.cntObjetos();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            insertar();
        }

        public void insertar()
        {
            string nombre = TextBox1.Text;
            string estado = TextBox2.Text;
            int cantidad = Convert.ToInt32(TextBox3.Text);

            insert.objinsert(nombre, estado, cantidad);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}