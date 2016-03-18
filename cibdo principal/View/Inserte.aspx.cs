using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class Inserte : System.Web.UI.Page
    {
        Controller.cntRecordatorio cntr = new Controller.cntRecordatorio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        public void insertRecorda()
        {
            string nombre = TextBox2.Text;
            DateTime fecha = DateTime.Parse(TextBox3.Text);
            DateTime hora = DateTime.Parse(TextBox4.Text + ":00.0000000");
            string descripcion = TextBox5.Text;
            int Persona_idPersona = 1;
            string Tipo_recordatorio_descripcion = DropDownList1.Text; 
          
            cntr.insertRe(nombre, fecha, hora, descripcion, Persona_idPersona, Tipo_recordatorio_descripcion);
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            DropDownList1.Text = "";
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            insertRecorda(); 
        }
    }
}