using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using Modelo;
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
    public partial class frmReporteMemoria : Form
    {

        DataTable tablaMemorias;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmReporteMemoria()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteMemoria(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {

            reporteDA = new ReporteDA();
            tablaMemorias = reporteDA.ListarMemorias();

            dgvMemorias.DataSource = tablaMemorias;
            vista.OptionsBehavior.AutoPopulateColumns = false;
            vista.OptionsSelection.MultiSelect = true;
        }
    }
}
