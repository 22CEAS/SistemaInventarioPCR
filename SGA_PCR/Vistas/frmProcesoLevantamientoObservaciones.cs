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
    public partial class frmProcesoLevantamientoObservaciones : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaCliente;
        ClienteDA clienteDA;
        ObservacionDA observacionDA;
        Observacion observacion;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoLevantamientoObservaciones()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoLevantamientoObservaciones(int idUsuario, string nombreUsuario)
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
            observacionDA = new ObservacionDA();
            observacion = new Observacion();
            
            dtpFechaIngreso.Value = DateTime.Now;

            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = 0;
            int i = cmbCliente.SelectedIndex;

            int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
            txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();
            
            ObtenerDatosObservacion();

        }

        public void ObtenerDatosObservacion()
        {
            observacion.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            observacion.FechaLevantamiento = dtpFechaIngreso.Value;
            string aux1 = "";
            aux1 = txtNroGuia.Text;
            observacion.GuiaLevantamiento = aux1.Trim();
            string aux2 = "";
            aux2 = txtNroDocumento.Text;
            observacion.RUC = aux2.Trim();
            string aux3 = "";
            aux3 = txtObservacionLevantamiento.Text;
            observacion.ObservacionLevantamiento = aux3.Trim();
            string aux4 = "";
            aux4 = txtObservacionDeuda.Text;
            observacion.ObservacionDeuda = aux4.Trim();

        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    txtObservacionLevantamiento.Enabled = false;
                    txtObservacionDeuda.Enabled = false;
                    btnAgregarObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    observacion = new Observacion();
                    break;
                case TipoVista.Nuevo:
                    cmbCliente.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    txtNroGuia.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    txtObservacionLevantamiento.Enabled = true;
                    txtObservacionDeuda.Enabled = true;
                    btnAgregarObservacion.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    observacion = new Observacion();
                    ObtenerDatosObservacion();
                    break;
                case TipoVista.Guardar:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    txtObservacionLevantamiento.Enabled = false;
                    txtObservacionDeuda.Enabled = false;
                    btnAgregarObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    break;
                case TipoVista.Modificar:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = true;
                    txtNroGuia.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    txtObservacionLevantamiento.Enabled = true;
                    txtObservacionDeuda.Enabled = true;
                    btnAgregarObservacion.Enabled = false;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    break;
                case TipoVista.Vista:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    txtObservacionLevantamiento.Enabled = false;
                    txtObservacionDeuda.Enabled = false;
                    btnAgregarObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    observacion = new Observacion();
                    break;
                case TipoVista.Limpiar:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    txtObservacionLevantamiento.Enabled = false;
                    txtObservacionDeuda.Enabled = false;
                    btnAgregarObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    observacion = new Observacion();
                    break;
                case TipoVista.Duplicar:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    txtObservacionLevantamiento.Enabled = false;
                    txtObservacionDeuda.Enabled = false;
                    btnAgregarObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    limpiarComponentes();
                    observacion = new Observacion();
                    break;
                case TipoVista.Anular:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    txtObservacionLevantamiento.Enabled = false;
                    txtObservacionDeuda.Enabled = false;
                    btnAgregarObservacion.Enabled = false;
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
            txtNroObservacion.Text = "";
            txtNroGuia.Text = "";
            cmbCliente.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Now;
            txtObservacionLevantamiento.Text = "";
            txtObservacionDeuda.Text = "";
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Modificar\n" + "la Observacion N° :" + txtNroObservacion.Text, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Modificar);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            string numObservacion = txtNroObservacion.Text;

            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede grabar el Levantamiento de Observacion si no\nha seleccionado un cliente correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            ObtenerDatosObservacion();

            if (observacion.ObservacionLevantamiento.Length == 0)
            {
                MessageBox.Show("No se puede grabar un Levantamiento de Observacion si no\nse ha llenado el motivo del levantamiento.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (observacion.GuiaLevantamiento.Length == 0)
            {
                MessageBox.Show("No se puede grabar este Levantamiento de Observacion,\nnecesita ingresar una guia.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Estas seguro que deseas Guardar este Levantamiento de Observación", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int error=0;
                observacion.IdEstado = 11;
                error = observacionDA.GrabarLevantamiento(observacion, this.nombreUsuario);

                if (error==0)
                {
                    MessageBox.Show("Hubo error en Registrar el Levantamiento, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                MessageBox.Show("Se guradó el Levantamiento", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                estadoComponentes(TipoVista.Guardar);
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (observacion.IdEstado == 0)
            {
                MessageBox.Show("Este Levantamiento de Observacion ya se encuentra en estado Anulado", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Anular este Levantamiento de Observacion", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    observacion.IdEstado = 1;
                    int error=observacionDA.AnularLevantamiento(observacion, this.nombreUsuario);
                    if (error == 0)
                    {
                        MessageBox.Show("Hubo error en Anular el Levantamiento, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    MessageBox.Show("Se anulo la Levantamiento de la Observación N° :" + observacion.IdObervacion);
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
                observacion = new Observacion();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarObservacion_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("No se puede agregar una observacion\n si no se ha seleccionado un cliente correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            using (frmProcesoLevantamientoObservacionesAgregarObservacion frm = new frmProcesoLevantamientoObservacionesAgregarObservacion(observacion.IdCliente))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Observacion obsAux = frm.OBSERVACION;
                    observacion.IdLC = obsAux.IdLC;
                    observacion.CodigoLC = obsAux.CodigoLC;
                    observacion.ObservacionDeuda = obsAux.ObservacionDeuda;
                    observacion.IdObervacion = obsAux.IdObervacion;
                    txtObservacionDeuda.Text = observacion.ObservacionDeuda;
                    txtNroObservacion.Text = observacion.IdObervacion.ToString();
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbCliente.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                observacion = new Observacion();
                int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
                txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();
                observacion.IdCliente = idCliente;
                txtObservacionDeuda.Text = "";
                txtObservacionLevantamiento.Text = "";
                txtNroObservacion.Text = "";
            }
            else
            {
                txtNroDocumento.Text = "";
            }

        }

        public void LlenarDatosObservacion()
        {
            txtNroObservacion.Text = observacion.IdObervacion.ToString();
            txtNroDocumento.Text = observacion.RUC;
            txtNroGuia.Text = observacion.GuiaLevantamiento.ToString();
            dtpFechaIngreso.Value = observacion.FechaLevantamiento;
            cmbCliente.SelectedValue = observacion.IdCliente;
            txtObservacionDeuda.Text = observacion.ObservacionDeuda;
            txtObservacionLevantamiento.Text = observacion.ObservacionLevantamiento;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            estadoComponentes(TipoVista.Vista);
            frmProcesoLevantamientoObservacionesBuscar frmBP = new frmProcesoLevantamientoObservacionesBuscar(this.idUsuario);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
                observacion = frmBP.ObjSeleccionado;
                txtNroObservacion.Text = observacion.IdDevolucion.ToString();
                LlenarDatosObservacion();
                observacion = frmBP.ObjSeleccionado;
            }
            else
            {
                estadoComponentes(TipoVista.Inicial);
            }
        }
    }
}
