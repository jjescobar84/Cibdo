using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace TiendasJhon
{
    public partial class Productos : Form

    {

     
        public Productos()
        {
            InitializeComponent();
        }

        // Metodo para llenar el combobox
        //private 

        private void Productos_Load(object sender, EventArgs e)
        {
            // Llenamos  el datagrid
            CatdataGridView.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;
            CatdataGridView.DataSource = CapaNegocios.NegocioCategoria.ObtenerCategoria();
            dataGridView1.DataSource = CapaNegocios.NegProductos.ObtenerProductosConNomCat();


            label1.Visible = false;
            label2.Visible = false;
            codigotextBox.Visible = false;
            categoriatextBox.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            CatdataGridView.Visible = false;
            textBox1.Visible = false;
            label5.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            comboBox3.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false; 
            button12.Visible = false;
            dataGridView1.Visible = false;

            //Llenar combobox
            comboBox3.DataSource = NegocioCategoria.ObtenerCategoria();
            comboBox3.ValueMember = "codCategoria";
            comboBox3.DisplayMember = "descripcionCat";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CatdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigotextBox.Text = Convert.ToString(CatdataGridView.CurrentRow.Cells["CodigoCategoria"].Value);
            categoriatextBox.Text = Convert.ToString(CatdataGridView.CurrentRow.Cells["DescripcionCategorias"].Value);
            button2.Enabled = false;
            tabControl1.SelectedIndex = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string rpta = NegocioCategoria.NegActualizar(int.Parse(codigotextBox.Text), categoriatextBox.Text);
            CatdataGridView.DataSource = NegocioCategoria.ObtenerCategoria();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Debes de escoger una opcion");
                comboBox1.Focus();
                return;
            }
            switch (comboBox1.Text)
            {

                case "Registrar ":
                    button2.Visible = true;
                    label2.Visible = true;
                    categoriatextBox.Visible = true;
                    label4.Enabled = false;
                    comboBox1.Enabled = false;
                    button3.Enabled = false;
                    break;
                case "Consultar":
                    CatdataGridView.Visible = true;
                    //button4.Visible = true;
                    button5.Visible = true;
                    break;
                default:
                    MessageBox.Show("Opcion incorrecta");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (categoriatextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar una categoria");
                categoriatextBox.Focus();
                return;
            }
            
            string rpta = NegocioCategoria.InsertCategoria(categoriatextBox.Text);
            CatdataGridView.DataSource = NegocioCategoria.ObtenerCategoria();
            CatdataGridView.Visible = true;
            MessageBox.Show("Se a guardado con exito");
            categoriatextBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*textBox1.Visible = true;
            label5.Visible = true;
            button6.Visible = true;
            button4.Enabled = false;*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            codigotextBox.Visible = true;
            categoriatextBox.Visible = true;
            button1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Debes de ingresar un código para eliminar");
                textBox1.Focus();
                return;
            }
            
            /*string rpt = NegocioCategoria.EliminarCategoria(int.Parse(textBox1.Text));
            CatdataGridView.DataSource = NegocioCategoria.ObtenerCategoria();*/
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Dede escoger una opcion");
                comboBox2.Focus();
                return;
            }
            switch (comboBox2.Text)
	        {
                case "Registrar Productos":
                    comboBox2.Enabled = true;
                    button7.Enabled = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    comboBox3.Visible = true;
                    button8.Visible = true;
                    break;
                case "Consultar Productos":
                    dataGridView1.Visible = true;
                    button10.Visible = true;
                    button9.Visible = true;
                    break;
		    default:
            break;
	    }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Codigo"].Value);
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NombreProducto"].Value);
            textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["PrecioUnit"].Value);
            comboBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Categoria"].Value);
            tabControl1.SelectedIndex = 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar un nombre de producto");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar un precio de producto");
                textBox3.Focus();
                return;
            }
            
            
            string rpta = NegProductos.InsertProductos(textBox2.Text, decimal.Parse(textBox3.Text),Convert.ToInt32(comboBox3.SelectedValue));
            dataGridView1.DataSource = NegProductos.ObtenerProductosConNomCat();
            if (rpta != string.Empty)
            {
                MessageBox.Show("Se a guardado con exito");
                dataGridView1.Visible = true;
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudo guardar");
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string rpta = NegProductos.ActualizarProduct(textBox2.Text, Convert.ToInt32(comboBox3.Text));
            dataGridView1.DataSource = NegProductos.ObtenerProductosConNomCat();
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            button11.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button12.Visible = true;
            textBox5.Visible = true;
            label10.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Debes de ingresar un código para eliminar");
                textBox5.Focus();
                return;
            }

            string rpt = NegProductos.EliminarProductos(int.Parse(textBox5.Text));
            dataGridView1.DataSource = NegProductos.ObtenerProductosConNomCat();
        }

     
    }
}
