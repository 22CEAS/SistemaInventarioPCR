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
    public partial class frmProcesoLevantamientoObservacionesAgregarObservacion : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaObservaciones;
        Observacion observacion;
        ObservacionDA observacionDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmProcesoLevantamientoObservacionesAgregarObservacion(int idCliente)
        {
            InitializeComponent();
            Inicializado(idCliente);
        }

        public frmProcesoLevantamientoObservacionesAgregarObservacion(int idUsuario, string nombreUsuario, int idCliente)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado(idCliente);
        }

        public void Inicializado(int idCliente)
        {

            observacionDA = new ObservacionDA();

            tablaObservaciones = observacionDA.ListarObservaciones(idCliente);

            dgvObservaciones.PrimaryGrid.AutoGenerateColumns = false;
            dgvObservaciones.PrimaryGrid.DataSource = tablaObservaciones;
        }

        public int llenarListaObservaciones()
        {
            int flag = 0;
            int filas = tablaObservaciones.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvObservaciones.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvObservaciones.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        observacion = new Observacion();
                        observacion.IdLC = int.Parse(((GridCell)(dgvObservaciones.PrimaryGrid.GetCell(i, 3))).Value.ToString());
                        observacion.CodigoLC = ((GridCell)(dgvObservaciones.PrimaryGrid.GetCell(i, 1))).Value.ToString();
                        observacion.ObservacionDeuda = ((GridCell)(dgvObservaciones.PrimaryGrid.GetCell(i, 2))).Value.ToString();
                        observacion.IdObervacion = int.Parse(((GridCell)(dgvObservaciones.PrimaryGrid.GetCell(i, 4))).Value.ToString());
                        flag++;
                    }
                }
            }
            return flag;
        }

        public Observacion OBSERVACION { get => observacion; set => observacion = value; }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int cant = llenarListaObservaciones();
            if (cant == 1)//Si entra es porque se ha seleccionado almenos solo
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                if (cant == 0) MessageBox.Show("Tiene que seleccionar una observacion", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cant > 0) MessageBox.Show("No puedes seleccionar más de una observacion", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
