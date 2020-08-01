using AccesoDatos;
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
    public partial class frmProcesoCambio : Form
    {

        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }

        ClienteDA clienteDA;
        CambioDA cambioDA;
        Cambio cambio;
        Cambio cambioOld;
        LC artTemp;
        DataTable tablaDatosLaptop;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoCambio()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmProcesoCambio(int idUsuario, string nombreUsuario)
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
            cambioDA = new CambioDA();

            artTemp = new LC();
            dtpFechaCambio.Value = DateTime.Now;

            cambio = new Cambio();
            cambioOld = new Cambio();
            ObtenerDatosCambio();

            BindingList<Cambio> cambios = new BindingList<Cambio>();
            cambios.Add(cambio);
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = cambios;
            dgvLaptopsSeleccionados.PrimaryGrid.AutoGenerateColumns = false;

        }

        public void ObtenerDatosCambio()
        {
            cambio.FechaCambio = dtpFechaCambio.Value;
            string aux1 = txtRucDni.Text;
            cambio.RucDni = aux1.Trim();
            string aux2 = txtCliente.Text;
            cambio.NombreCliente = aux2.Trim();
            string aux3 = txtCodigoLaptop.Text;
            cambio.CodigoLCAntiguo = aux3.Trim();
            string aux4 = txtGuiaRemision.Text;
            cambio.GuiaCambio = aux4.Trim();
            string aux5 = txtNroTicket.Text;
            cambio.TicketTecnico = aux5.Trim();
            string aux6 = txtObservacion.Text;
            cambio.Observacion = aux6.Trim();
            cambio.DanoLC = (chbEquipoDanado.Checked)?1:0;
            cambio.PagaraCliente = (chbPagaraCliente.Checked) ? 1 : 0;
            cambio.FueDevuelto = (chbEquipoDevuelto.Checked) ? 1 : 0;
            cambio.EstadoLCAntiguo = (chbEquipoDanado.Checked) ? 3 : 2;
        }

        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    txtCodigoLaptop.Enabled = false;
                    txtCliente.Enabled = false;
                    txtGuiaRemision.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtNroTicket.Enabled = false;
                    txtRucDni.Enabled = false;
                    dtpFechaCambio.Enabled = false;
                    chbEquipoDanado.Enabled = false;
                    chbEquipoDevuelto.Enabled = false;
                    chbPagaraCliente.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    cambio = new Cambio();
                    break;
                case TipoVista.Nuevo:
                    txtCodigoLaptop.Enabled = true;
                    txtCliente.Enabled = true;
                    txtGuiaRemision.Enabled = true;
                    txtObservacion.Enabled = true;
                    txtNroTicket.Enabled = true;
                    txtRucDni.Enabled = true;
                    dtpFechaCambio.Enabled = true;
                    chbEquipoDanado.Enabled = true;
                    chbEquipoDevuelto.Enabled = true;
                    chbPagaraCliente.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    cambio = new Cambio();
                    break;
                case TipoVista.Guardar:
                    txtCodigoLaptop.Enabled = false;
                    txtCliente.Enabled = false;
                    txtGuiaRemision.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtNroTicket.Enabled = false;
                    txtRucDni.Enabled = false;
                    dtpFechaCambio.Enabled = false;
                    chbEquipoDanado.Enabled = false;
                    chbEquipoDevuelto.Enabled = false;
                    chbPagaraCliente.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
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
                    txtCodigoLaptop.Enabled = true;
                    txtCliente.Enabled = true;
                    txtGuiaRemision.Enabled = true;
                    txtObservacion.Enabled = true;
                    txtNroTicket.Enabled = true;
                    txtRucDni.Enabled = true;
                    dtpFechaCambio.Enabled = true;
                    chbEquipoDanado.Enabled = true;
                    chbEquipoDevuelto.Enabled = true;
                    chbPagaraCliente.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    break;
                case TipoVista.Vista:
                    txtCodigoLaptop.Enabled = false;
                    txtCliente.Enabled = false;
                    txtGuiaRemision.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtNroTicket.Enabled = false;
                    txtRucDni.Enabled = false;
                    dtpFechaCambio.Enabled = false;
                    chbEquipoDanado.Enabled = false;
                    chbEquipoDevuelto.Enabled = false;
                    chbPagaraCliente.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    //limpiarComponentes();
                    cambio = new Cambio();
                    break;
                case TipoVista.Limpiar:
                    txtCodigoLaptop.Enabled = false;
                    txtCliente.Enabled = false;
                    txtGuiaRemision.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtNroTicket.Enabled = false;
                    txtRucDni.Enabled = false;
                    dtpFechaCambio.Enabled = false;
                    chbEquipoDanado.Enabled = false;
                    chbEquipoDevuelto.Enabled = false;
                    chbPagaraCliente.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    limpiarComponentes();
                    cambio = new Cambio();
                    break;
                case TipoVista.Duplicar:
                    txtCodigoLaptop.Enabled = false;
                    txtCliente.Enabled = false;
                    txtGuiaRemision.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtNroTicket.Enabled = false;
                    txtRucDni.Enabled = false;
                    dtpFechaCambio.Enabled = false;
                    chbEquipoDanado.Enabled = false;
                    chbEquipoDevuelto.Enabled = false;
                    chbPagaraCliente.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    limpiarComponentes();
                    cambio = new Cambio();
                    break;
                case TipoVista.Anular:
                    txtCodigoLaptop.Enabled = false;
                    txtCliente.Enabled = false;
                    txtGuiaRemision.Enabled = false;
                    txtObservacion.Enabled = false;
                    txtNroTicket.Enabled = false;
                    txtRucDni.Enabled = false;
                    dtpFechaCambio.Enabled = false;
                    chbEquipoDanado.Enabled = false;
                    chbEquipoDevuelto.Enabled = false;
                    chbPagaraCliente.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCliente.Text = "";
            txtNroCambio.Text = "";
            txtCodigoLaptop.Text = "";
            txtGuiaRemision.Text = "";
            txtNroTicket.Text = "";
            txtRucDni.Text = "";
            txtObservacion.Text = "";
            dtpFechaCambio.Value = DateTime.Now;
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
        }


        public void LlenarDatosCambio()
        {
            txtCliente.Text = cambio.NombreCliente;
            txtCodigoLaptop.Text = cambio.CodigoLCAntiguo;
            txtGuiaRemision.Text = cambio.GuiaCambio;
            txtNroTicket.Text = cambio.TicketTecnico;
            txtRucDni.Text = cambio.RucDni;
            txtObservacion.Text = cambio.Observacion;
            dtpFechaCambio.Value = cambio.FechaCambio;
            chbEquipoDanado.Checked = (cambio.DanoLC == 1) ? true : false;
            chbEquipoDevuelto.Checked = (cambio.FueDevuelto == 1) ? true : false;
            chbPagaraCliente.Checked = (cambio.PagaraCliente == 1) ? true : false;
            BindingList<Cambio> cambios = new BindingList<Cambio>();
            cambios.Add(cambio);
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = cambios;
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (frmProcesoCambioAgregarProducto frm = new frmProcesoCambioAgregarProducto())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    cambio.LaptopNuevo = frm.LAPTOP;
                }
            }
            BindingList<Cambio> cambios = new BindingList<Cambio>();
            cambios.Add(cambio);
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = cambios;
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
                cambio = new Cambio();
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (cambio.Estado == 0)//en teoría 7 debería ser finalizado
            {
                MessageBox.Show("Este cambio ya no se puede modificar", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Modificar\n" + "el Cambio N° :" + txtNroCambio.Text, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    estadoComponentes(TipoVista.Modificar);

                }

            }
        }

        private void dgvLaptopsSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta laptop de tu detalle de Cambio", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                cambio.LaptopNuevo = null;
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cambio.Estado == 0)
            {
                MessageBox.Show("Este Cambio ya se encuentra en estado Anulado", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Anular este Cambio", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cambio.Estado = 0;
                    cambioDA.AnularCambio(cambio, this.nombreUsuario);
                    MessageBox.Show("Se anulo el Cambio N° :" + cambio.IdCambio, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoComponentes(TipoVista.Anular);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void txtCodigoLaptop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                string aux = txtCodigoLaptop.Text;
                tablaDatosLaptop=cambioDA.DatosLaptopPorCambiar(aux.Trim());
                if (tablaDatosLaptop.Rows.Count == 1)
                {
                    cambio.IdLCAntiguo = Convert.ToInt32(tablaDatosLaptop.Rows[0]["IdLCAntiguo"].ToString());
                    cambio.IdCliente = Convert.ToInt32(tablaDatosLaptop.Rows[0]["IdCliente"].ToString());
                    cambio.NombreCliente = tablaDatosLaptop.Rows[0]["NombreCliente"].ToString();
                    cambio.RucDni =tablaDatosLaptop.Rows[0]["RucDni"].ToString();
                    cambio.IdSalida = Convert.ToInt32(tablaDatosLaptop.Rows[0]["IdSalida"].ToString());
                    cambio.IdSalidaDet = Convert.ToInt32(tablaDatosLaptop.Rows[0]["IdSalidaDet"].ToString());
                    cambio.IdSucursal = Convert.ToInt32(tablaDatosLaptop.Rows[0]["IdSucursal"].ToString());

                    txtCliente.Text = cambio.NombreCliente;
                    txtRucDni.Text = cambio.RucDni;
                }
                else
                {
                    MessageBox.Show("No se encontró ningun cliente relacionado a esta laptop, verifique que el código sea correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cambio.IdLCAntiguo = 0;
                    cambio.IdCliente = 0;
                    cambio.NombreCliente = "";
                    cambio.RucDni = "";

                    txtCliente.Text = "";
                    txtRucDni.Text = "";
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            string numCambio = txtNroCambio.Text;
            ObtenerDatosCambio();
            string cliente = txtCliente.Text;
            cliente = cliente.Trim();

            if (cliente.Length == 0)
            {
                MessageBox.Show("No se puede grabar un Cambio si no\nexiste un cliente relacionado.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            string guia = txtGuiaRemision.Text;
            guia = guia.Trim();

            if (guia.Length == 0)
            {
                MessageBox.Show("No se puede grabar un Cambio si no\nexiste una guia.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (cambio.LaptopNuevo == null)
            {
                MessageBox.Show("No se puede grabar un Cambio si no\nexiste una laptop con la que hacer el cambio.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (numCambio.Length == 0)
            {
                if (MessageBox.Show("Estas seguro que deseas Guardar este proceso de Cambio", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ObtenerDatosCambio();
                    int idCambio = cambioDA.InsertarCambio(cambio, this.nombreUsuario);
                    if (idCambio == 0)
                    {
                        MessageBox.Show("Hubo error en Registrar el Cambio, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    MessageBox.Show("Se guradó el Cambio", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cambio.IdCambio = idCambio;
                    cambioOld = new Cambio(cambio);
                    txtNroCambio.Text = idCambio.ToString();
                    estadoComponentes(TipoVista.Guardar);
                }
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Guardar los cambios", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cambioDA.ModificarCambio(cambio, this.nombreUsuario, cambioOld);
                    MessageBox.Show("Se Modifico el Cambio N° :" + txtNroCambio.Text + " con exito", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    estadoComponentes(TipoVista.Guardar);
                }
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Vista);
            frmProcesoCambioBuscar frmBP = new frmProcesoCambioBuscar(this.idUsuario);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
                cambio = frmBP.ObjSeleccionado;
                txtNroCambio.Text = cambio.IdCambio.ToString();
                LlenarDatosCambio();
                cambio = frmBP.ObjSeleccionado;
                cambioOld = new Cambio(cambio);

                BindingList<Cambio> cambios = new BindingList<Cambio>();
                cambios.Add(cambio);
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = cambios;
            }
            else
            {
                estadoComponentes(TipoVista.Inicial);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
