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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }
        
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            using (frmLaptopCpu frm = new frmLaptopCpu())
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
    }
}
