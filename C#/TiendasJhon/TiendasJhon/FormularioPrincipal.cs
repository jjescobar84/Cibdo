using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendasJhon
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Productos Proc = new Productos();
            Proc.MdiParent = this;
            Proc.Show();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
