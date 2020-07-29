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
    public partial class frmProcesoDevolucion : Form
    {

        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaCliente;
        DataTable tablaLaptops;
        ClienteDA clienteDA;
        AlquilerDA alquilerDA;
        DevolucionDA devolucionDA;
        Devolucion devolucion;
        DevolucionDetalle detalleTemp;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoDevolucion()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoDevolucion(int idUsuario, string nombreUsuario)
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
            alquilerDA = new AlquilerDA();
            devolucionDA = new DevolucionDA();
            devolucion = new Devolucion();

            detalleTemp = new DevolucionDetalle();
            dtpFechaIngreso.Value = DateTime.Now;

            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = 0;
            int i = cmbCliente.SelectedIndex;

            int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
            txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();

            tablaLaptops = devolucionDA.ListarLaptopsClientesEstadoAlquilado(idCliente);

            ObtenerDatosDevolucion();
            devolucion.LlenarDatos(tablaLaptops);
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = tablaLaptops;
            dgvLaptopsSeleccionados.PrimaryGrid.AutoGenerateColumns = false;

        }

        public void ObtenerDatosDevolucion()
        {

            devolucion.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            devolucion.FechaDevolucion = dtpFechaIngreso.Value;
            string aux1 = "";
            aux1 = txtNroGuia.Text;
            devolucion.GuiaDevolucion = aux1.Trim();
            string aux2 = "";
            aux2 = txtNroDocumento.Text;
            devolucion.RucDni = aux2.Trim();

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
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    devolucion = new Devolucion();
                    break;
                case TipoVista.Nuevo:
                    cmbCliente.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    txtNroGuia.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnObservacion.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    devolucion = new Devolucion();
                    ObtenerDatosDevolucion();
                    break;
                case TipoVista.Guardar:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    //limpiarComponentes();
                    break;
                case TipoVista.Modificar:
                    cmbCliente.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    txtNroGuia.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnObservacion.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    break;
                case TipoVista.Vista:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    //limpiarComponentes();
                    devolucion = new Devolucion();
                    break;
                case TipoVista.Limpiar:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    devolucion = new Devolucion();
                    break;
                case TipoVista.Duplicar:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    limpiarComponentes();
                    devolucion = new Devolucion();
                    break;
                case TipoVista.Anular:
                    cmbCliente.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    txtNroGuia.Enabled = false;
                    txtNroDocumento.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnObservacion.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    limpiarComponentes();
                    devolucion = new Devolucion();
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtNroDevolucion.Text = "";
            txtNroGuia.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
        }
        
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = cmbCliente.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                devolucion = new Devolucion();
                int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
                txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();
                devolucion.IdCliente = idCliente;
                tablaLaptops = null;
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
            }
            else
            {
                txtNroDocumento.Text = "";
            }

        }

        public void LlenarDatosAlquiler()
        {
            txtNroDevolucion.Text = devolucion.IdDevolucion.ToString();
            cmbCliente.SelectedValue = devolucion.IdCliente;
            txtNroDocumento.Text = devolucion.RucDni;
            txtNroGuia.Text = devolucion.GuiaDevolucion.ToString();
            dtpFechaIngreso.Value = devolucion.FechaDevolucion;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Limpiar);
                devolucion = new Devolucion();
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            estadoComponentes(TipoVista.Vista);
            frmProcesoDevolucionBuscar frmBP = new frmProcesoDevolucionBuscar(this.idUsuario);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
                devolucion = frmBP.ObjSeleccionado;
                txtNroDevolucion.Text = devolucion.IdDevolucion.ToString();
                LlenarDatosAlquiler();
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = devolucion.Detalles;
            }
            else
            {
                estadoComponentes(TipoVista.Inicial);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Modificar\n" + "la Devolución N° :" + txtNroDevolucion.Text, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Modificar);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            string numDevolucion = txtNroDevolucion.Text;
            ObtenerDatosDevolucion();

            if (devolucion.Detalles.Count == 0)
            {
                MessageBox.Show("No se puede grabar un Devolución si no\nseleccionas ninguna laptop.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (devolucion.GuiaDevolucion.Length == 0)
            {
                MessageBox.Show("No se puede grabar esta Devolución\nnecesita ingresar una guia.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            ObtenerDatosDevolucion();
            if (numDevolucion.Length == 0)
            {
                if (MessageBox.Show("Estas seguro que deseas Guardar este proceso de Devolución", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ObtenerDatosDevolucion();
                    int idDevolucion=0;
                    idDevolucion = devolucionDA.InsertarDevolucion(devolucion, this.nombreUsuario);

                    if (idDevolucion == 0)
                    {
                        MessageBox.Show("Hubo error en Registrar la Devolución, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    MessageBox.Show("Se guradó la devolución", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    devolucion.IdDevolucion = idDevolucion;
                    txtNroDevolucion.Text = idDevolucion.ToString();
                    estadoComponentes(TipoVista.Guardar);
                }
            }
            else
            {
                
                if (MessageBox.Show("Estas seguro que desea Guardar los cambios", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    devolucionDA.ModificarDevolucion(devolucion, this.nombreUsuario);
                    MessageBox.Show("Se Modifico la Devolución N° :" + txtNroDevolucion.Text + " con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    estadoComponentes(TipoVista.Guardar);
                }
            }


        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (frmProcesoDevolucionAgregarProducto frm = new frmProcesoDevolucionAgregarProducto(devolucion.IdCliente))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DevolucionDetalle detalleTraido in frm.DETALLES)
                    {
                        DevolucionDetalle dp = new DevolucionDetalle();
                        dp.IdLC = detalleTraido.IdLC;
                        bool exists = devolucion.Detalles.Any(x => x.IdLC.Equals(dp.IdLC));
                        if (!(exists))
                        {
                            devolucion.Detalles.Add(detalleTraido);
                        }
                    }
                }
            }

            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = devolucion.Detalles;
            if (devolucion.Detalles.Count > 0)
            {
                btnObservacion.Enabled = true;
            }
        }

        private void btnObservacion_Click(object sender, EventArgs e)
        {

            if (dgvLaptopsSeleccionados.PrimaryGrid.Rows.Count > 0)
            {
                detalleTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[4])).Value.ToString());

                int indice = 0;
                foreach (DevolucionDetalle detalle in devolucion.Detalles)
                {
                    if (detalle.IdLC == detalleTemp.IdLC)
                    {
                        break;
                    }
                    indice++;
                }
                int cobrar = devolucion.Detalles[indice].Cobrar;
                int dano = devolucion.Detalles[indice].Danado;
                string observacion = devolucion.Detalles[indice].Observacion;
                using (frmProcesoEvaluarEquipo frm = new frmProcesoEvaluarEquipo(cobrar, dano, observacion))
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        devolucion.Detalles[indice].Cobrar = frm.Cobrado;
                        devolucion.Detalles[indice].Danado = frm.Dano;
                        devolucion.Detalles[indice].EstadoLC = (frm.Dano == 1) ? 3 : 2;
                        devolucion.Detalles[indice].Observacion = frm.Observacion;
                        dgvLaptopsSeleccionados.PrimaryGrid.DataSource = devolucion.Detalles;
                    }
                }
            }

        }

        private void dgvLaptopsSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta laptop de tu detalle de Devolución", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                if (dgvLaptopsSeleccionados.PrimaryGrid.Rows.Count > 0)
                {
                    detalleTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[4])).Value.ToString());

                    int indiceLC = 0;
                    foreach (DevolucionDetalle detalle in devolucion.Detalles)
                    {
                        if (detalle.IdLC == detalleTemp.IdLC)
                        {
                            break;
                        }
                        indiceLC++;
                    }

                    devolucion.Detalles.RemoveAt(indiceLC);

                    dgvLaptopsSeleccionados.PrimaryGrid.DataSource = devolucion.Detalles;
                }
            }

        }
    }
}
