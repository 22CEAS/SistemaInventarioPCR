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
using Excel = Microsoft.Office.Interop.Excel;

namespace Vistas
{
    public partial class frmProcesoReparacion : Form
    {

        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }

        ClienteDA clienteDA;
        ReparacionDA reparacionDA;
        Reparacion reparacion;
        Reparacion reparacionOld;
        LC artTemp;
        DataTable tablaDatosLaptop;
        DataTable tablaEstados;

        private int idUsuario;
        private string nombreUsuario = "CEAS";
        private int flagModificar = 0;

        public frmProcesoReparacion()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoReparacion(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public void Inicializado()
        {

            clienteDA = new ClienteDA();
            reparacionDA = new ReparacionDA();

            artTemp = new LC();
            dtpFecReparacion.Value = DateTime.Now;

            reparacion = new Reparacion();
            reparacionOld = new Reparacion();

            tablaEstados = reparacionDA.ListarEstados();
            cmbEstado.DataSource = tablaEstados;
            cmbEstado.DisplayMember = "nombreEstado";
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.SelectedIndex = 0;

            tablaDatosLaptop = reparacionDA.ListarLaptops();
            cmbEquipo.DataSource = tablaDatosLaptop;
            cmbEquipo.DisplayMember = "codigo";
            cmbEquipo.ValueMember = "idLC";
            cmbEquipo.SelectedIndex = tablaDatosLaptop.Rows.Count>0?0:-1;

            ObtenerDatosReparacion();

        }

        public void ObtenerDatosReparacion()
        {
            reparacion.FechaReparacion = dtpFecReparacion.Value;
            string aux1 = txtDescripcion.Text;
            reparacion.ObservacionReparacion = aux1.Trim();
            string aux2 = txtObservacion.Text;
            reparacion.ObservacionActual = aux2.Trim();

            int i = cmbEquipo.SelectedIndex;
            if (i >= 0)
            {
                reparacion.IdLC = Convert.ToInt32(tablaDatosLaptop.Rows[i]["idLC"].ToString());
                reparacion.CodigoLC = tablaDatosLaptop.Rows[i]["codigo"].ToString();
                reparacion.EstadoLCAnt = Convert.ToInt32(tablaDatosLaptop.Rows[i]["idEstado"].ToString());
            }
            i = cmbEstado.SelectedIndex;
            if (i >= 0)
            {
                reparacion.EstadoLCAct = Convert.ToInt32(tablaEstados.Rows[i]["idEstado"].ToString());
            }
        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    cmbEquipo.Enabled = false;
                    cmbEstado.Enabled = false;
                    dtpFecReparacion.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    reparacion = new Reparacion();
                    break;
                case TipoVista.Nuevo:
                    cmbEquipo.Enabled = true;
                    cmbEstado.Enabled = true;
                    dtpFecReparacion.Enabled = true;
                    txtObservacion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    reparacion = new Reparacion();
                    break;
                case TipoVista.Guardar:
                    cmbEquipo.Enabled = false;
                    cmbEstado.Enabled = false;
                    dtpFecReparacion.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    break;
                case TipoVista.Modificar:
                    cmbEquipo.Enabled = true;
                    cmbEstado.Enabled = true;
                    dtpFecReparacion.Enabled = true;
                    txtObservacion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    break;
                case TipoVista.Vista:
                    cmbEquipo.Enabled = false;
                    cmbEstado.Enabled = false;
                    dtpFecReparacion.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    reparacion = new Reparacion();
                    break;
                case TipoVista.Limpiar:
                    cmbEquipo.Enabled = false;
                    cmbEstado.Enabled = false;
                    dtpFecReparacion.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    reparacion = new Reparacion();
                    break;
                case TipoVista.Duplicar:
                    cmbEquipo.Enabled = false;
                    cmbEstado.Enabled = false;
                    dtpFecReparacion.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    limpiarComponentes();
                    reparacion = new Reparacion();
                    break;
                case TipoVista.Anular:
                    cmbEquipo.Enabled = false;
                    cmbEstado.Enabled = false;
                    dtpFecReparacion.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtObservacion.Text = "";
            txtDescripcion.Text = "";
            txtNroReparacion.Text = "";
            dtpFecReparacion.Value = DateTime.Now;

            tablaEstados = reparacionDA.ListarEstados();
            cmbEstado.DataSource = tablaEstados;
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.SelectedIndex = tablaEstados.Rows.Count > 0 ? 0 : -1;

            tablaDatosLaptop.Rows.Clear();
            cmbEquipo.DataSource= tablaDatosLaptop;
            tablaDatosLaptop = reparacionDA.ListarLaptops();
            cmbEquipo.DataSource = tablaDatosLaptop;
            cmbEquipo.DisplayMember = "codigo";
            cmbEquipo.ValueMember = "idLC";
            cmbEquipo.SelectedIndex = tablaDatosLaptop.Rows.Count > 0 ? 0 : -1;
        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            string numReparacion = txtNroReparacion.Text;

            if (cmbEquipo.SelectedValue == null)
            {
                MessageBox.Show("No se puede grabar una Reparacion si no\nha seleccionado una laptop correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            string observacion = txtObservacion.Text;
            observacion = observacion.Trim();

            if (observacion.Length == 0)
            {
                MessageBox.Show("No se puede grabar una Reparacion si no\nllena el campo de observacion.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            string descripcion = txtDescripcion.Text;
            descripcion = descripcion.Trim();
            if (descripcion.Length == 0)
            {
                MessageBox.Show("No se puede grabar una Reparacion si no\nllena el campo de descripcion.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            ObtenerDatosReparacion();

            if (numReparacion.Length == 0)
            {
                if (MessageBox.Show("Estas seguro que deseas Guardar este proceso de Reparacion", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int idReparacion = reparacionDA.InsertarReparacion(reparacion, this.nombreUsuario);
                    if (idReparacion == 0)
                    {
                        MessageBox.Show("Hubo error en Registrar la Reparacion, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    MessageBox.Show("Se guradó la Reparacion", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    reparacion.IdReparacion = idReparacion;
                    reparacionOld = new Reparacion(reparacion);
                    txtNroReparacion.Text = idReparacion.ToString();
                    estadoComponentes(TipoVista.Guardar);
                }
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Guardar los cambios", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bool okey=reparacionDA.ModificarReparacion(reparacion, this.nombreUsuario, reparacionOld);
                    if (okey)
                        MessageBox.Show("Se Modifico la Reparacion N° :" + txtNroReparacion.Text + " con exito", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("No se Modifico la Reparacion N° :" + txtNroReparacion.Text + ", comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    estadoComponentes(TipoVista.Guardar);
                }
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (reparacion.Estado == 0)//
            {
                MessageBox.Show("Esta reparacion ya no se puede modificar", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Modificar\n" + "la Reparacion N° :" + txtNroReparacion.Text, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    estadoComponentes(TipoVista.Modificar);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            if (reparacion.Estado == 0)
            {
                MessageBox.Show("Esta reparacion ya se encuentra en estado Anulado", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Anular esta reaparacion", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    reparacion.Estado = 0;
                    reparacionDA.AnularReparacion(reparacion, this.nombreUsuario);
                    MessageBox.Show("Se anulo la Reparacion N° :" + reparacion.IdReparacion, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoComponentes(TipoVista.Anular);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Limpiar);
                reparacion = new Reparacion();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Vista);
            frmProcesoReparacionBuscar frmBP = new frmProcesoReparacionBuscar(this.idUsuario);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
                flagModificar = 1;
                reparacion = frmBP.ObjSeleccionado;
                reparacionOld = new Reparacion(reparacion);
                txtNroReparacion.Text = reparacion.IdReparacion.ToString();
                LlenarDatosReparacion();
                reparacion = frmBP.ObjSeleccionado;
            }
            else
            {
                estadoComponentes(TipoVista.Inicial);
            }
        }

        public void LlenarDatosReparacion()
        {
            txtNroReparacion.Text = reparacion.IdReparacion.ToString();
            txtObservacion.Text = reparacion.ObservacionActual;
            txtDescripcion.Text = reparacion.ObservacionReparacion;
            cmbEstado.SelectedValue = reparacion.EstadoLCAct;

            DataRow newRow = tablaDatosLaptop.NewRow();
            newRow["idLC"] = reparacion.IdLC;
            newRow["codigo"] = reparacion.CodigoLC;
            newRow["idEstado"] = reparacion.EstadoLCAnt;
            tablaDatosLaptop.Rows.Add(newRow);

            cmbEquipo.DataSource = tablaDatosLaptop;
            cmbEquipo.DisplayMember = "codigo";
            cmbEquipo.ValueMember = "idLC";

            cmbEquipo.SelectedValue = reparacion.IdLC;
            dtpFecReparacion.Value = reparacion.FechaReparacion;
        }
    }
}
