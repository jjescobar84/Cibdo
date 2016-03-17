using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace ConexionesTresCapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Consultar cliente por cedula
            Cliente objCliente = new Cliente();
            try
            {
                DataSet DatosCliente = objCliente.ConsultarClientePorNitCed(textBox1.Text);
                int numRegistro = DatosCliente.Tables["TablaConsultada"].Rows.Count;
                if (numRegistro == 0)
                    MessageBox.Show("No se encontro el cliente");
                else                {
                    dataGridView1.DataSource = DatosCliente.Tables["TablaConsultada"];}
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message+objCliente.Mensaje);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             // Consultar cliente por cedula
            Cliente objCliente = new Cliente();
            try
            {
                DataSet DatosCliente = objCliente.ConsultarTodosCliente();
                int numRegistro = DatosCliente.Tables["TablaConsultada"].Rows.Count;
                if (numRegistro == 0)
                    MessageBox.Show("No se encontraron registros");
                else                {
                    dataGridView1.DataSource = DatosCliente.Tables["TablaConsultada"];}
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message+objCliente.Mensaje);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar un Nit o Cedula");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar un nombre de razon social");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar un telefono");
                textBox4.Focus();
                return;
            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar una direccion");
                textBox5.Focus();
                return;
            }
            try
            {
                bool DatosCliente = objCliente.InsertarClientes(textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text);
                dataGridView1.DataSource = DatosCliente;
                MessageBox.Show("Se a guardado con exito");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message + objCliente.Mensaje);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            dataGridView2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            button5.Visible = true;
            dataGridView2.Visible = true;
            button7.Visible = true;

            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Nit o una Cedula del cliente");
                textBox6.Focus();
                return;
            }

            Cliente objCliente = new Cliente();
            try
            {
                DataSet DatosCliente = objCliente.ConsultarClientePorNitCed(textBox6.Text);
                int numRegistro = DatosCliente.Tables["TablaConsultada"].Rows.Count;
                if (numRegistro == 0)
                    MessageBox.Show("No se encontro el cliente");
                else
                {
                    dataGridView2.DataSource = DatosCliente.Tables["TablaConsultada"];
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message + objCliente.Mensaje);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            textBox7.Visible = true;
            button6.Visible = true;
            textBox8.Visible = true;
            button7.Enabled = false;
            textBox9.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            if (textBox7.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una razon social");
                textBox7.Focus();
                return;
            }
            if (textBox8.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un telefono");
                textBox8.Focus();
                return;
            }
            if (textBox9.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una direccion");
                textBox9.Focus();
                return;
            }
            try
            {
                bool DatosCliente = objCliente.ModificarClientes(textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
                dataGridView2.DataSource = DatosCliente;
                dataGridView2.Visible = false;
                MessageBox.Show("Se han modificado los datos con exito");
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message + objCliente.Mensaje);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            try
            {
                bool DatosCliente = objCliente.EliminarCliente(textBox6.Text);
                dataGridView2.DataSource = DatosCliente;
                dataGridView2.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message + objCliente.Mensaje);

            }
            button6.Visible = false;
            button5.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
