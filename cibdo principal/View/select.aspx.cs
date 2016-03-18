using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class select : System.Web.UI.Page
    {
        Controller.cntRecordatorio cntr = new Controller.cntRecordatorio();
        protected void Page_Load(object sender, EventArgs e)
        {
            

           
        }

       
        public void pintaRecorda()
        {   
            GridView1.DataSource = cntr.consultaRecorda();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string id =  ["id"];
            //int idNum = Convert.ToInt32(id);

            //cntr.deleteRe(idNum);
            //Response.Redirect("select.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            pintaRecorda();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

      
    }
}