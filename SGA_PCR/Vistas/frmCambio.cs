﻿using System;
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
    public partial class frmCambio : Form
    {
        public frmCambio()
        {
            InitializeComponent();
        }

        private void btnCambiarProducto_Click(object sender, EventArgs e)
        {
            using (frmProductoCambio frm = new frmProductoCambio())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }
    }
}
