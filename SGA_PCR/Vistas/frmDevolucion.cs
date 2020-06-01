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
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void dgvEquipos_RowDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs e)
        {
            using (frmEvaluarEquipo frm = new frmEvaluarEquipo())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }
    }
}
