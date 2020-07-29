using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmProcesoIngreso : Form
    {
        public frmProcesoIngreso()
        {
            InitializeComponent();
        }
        
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            using (frmProcesoLaptopCpu frm = new frmProcesoLaptopCpu())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }

        }

        private void frmIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            //frmPrincipal.btnIngreso.Enabled = true;
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeInput1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelX4_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
