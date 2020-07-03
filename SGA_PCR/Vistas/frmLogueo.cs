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
    public partial class frmLogueo : Form
    {
        public frmLogueo()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IngresarSistema();
        }
        private void IngresarSistema()
        {

            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnVerContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            btnOcultarContraseña.Visible = false;
            btnVerContraseña.Visible = true;
        }
    }
}
