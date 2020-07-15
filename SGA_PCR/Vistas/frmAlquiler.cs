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
    public partial class frmAlquiler : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaCliente;
        DataTable tablaClienteSucursal;
        DataTable tablaDisco;
        DataTable tablaMemoria;
        DataTable tablaLicencia;
        ClienteDA clienteDA;
        AlquilerDA alquilerDA;
        Alquiler alquiler;
        LC artTemp;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmAlquiler()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }

        public frmAlquiler(int idUsuario, string nombreUsuario)
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

            dtpFechaTraslado.Value = DateTime.Now;
            dtpIniPlazo.Value = DateTime.Now;
            dtpFinPlazo.Value = DateTime.Now;
            dtpFinPlazo.MinDate = dtpIniPlazo.Value;

            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = 0;
            int i = cmbCliente.SelectedIndex;

            txtNroDocumento.Text = tablaCliente.Rows[i]["nroDocumento"].ToString();

            //Listar Sucursales correspondientes al cliente

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                tablaClienteSucursal = clienteDA.ListarSucursalCliente(idCliente);
                cmbSucursal.DataSource = tablaClienteSucursal;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "idSucursal";
                cmbSucursal.SelectedIndex = 0;
            }

            alquiler = new Alquiler();
            alquiler.Detalles = new BindingList<AlquilerDetalle>();
            ObtenerDatosAlquiler();
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = alquiler.Detalles;
            dgvLaptopsSeleccionados.PrimaryGrid.AutoGenerateColumns = false;
            dgvMemorias.PrimaryGrid.AutoGenerateColumns = false;
            dgvDisco.PrimaryGrid.AutoGenerateColumns = false;
            dgvLicencia.PrimaryGrid.AutoGenerateColumns = false;

        }

        public void ObtenerDatosAlquiler()
        {

            alquiler.Cliente.IdCliente= Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            ClienteSucursal sucursal = new ClienteSucursal();
            sucursal.IdSucursal= Convert.ToInt32(cmbSucursal.SelectedValue.ToString());
            alquiler.Cliente.Sucursales.Add(sucursal);
            alquiler.FechaSalida = dtpFechaTraslado.Value;
            alquiler.FechaIniContrato = dtpIniPlazo.Value;
            alquiler.FechaFinContrato = dtpFinPlazo.Value;
            alquiler.UsuarioRegistro.IdUsuario = this.idUsuario;

        }

        public void estadoComponentes(TipoVista estado)
        {
            /*switch (estado)
            {
                case TipoVista.Inicial: //ya esta

                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = false;
                    txtNombreContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    sucursalCliente = new ClienteSucursal();
                    break;
                case TipoVista.Nuevo: //ya esta
                    //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = true;
                    txtNombreContacto.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDireccion.Enabled = true;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    sucursalCliente = new ClienteSucursal();
                    break;
                case TipoVista.Guardar: //ya esta listo
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = false;
                    txtNombreContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    chbActivo.Enabled = false;
                    sucursalCliente = new ClienteSucursal();
                    //limpiarComponentes();
                    break;
                case TipoVista.Modificar://ya esta
                                         //Inicializado(idUsuario, nombreUsuario);

                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = false;
                    txtNroDocumento.Enabled = true;
                    txtNombreContacto.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDireccion.Enabled = true;
                    chbActivo.Enabled = true;
                    limpiarComponentes();
                    sucursalCliente = new ClienteSucursal();
                    break;
                case TipoVista.Vista:
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = false;
                    txtNombreContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    chbActivo.Enabled = false;
                    //limpiarComponentes();
                    sucursalCliente = new ClienteSucursal();
                    break;
                case TipoVista.Limpiar: //ya esta
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = false;
                    txtNombreContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    sucursalCliente = new ClienteSucursal();
                    break;
                case TipoVista.Duplicar:  //ya esta
                    //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    txtNombreContacto.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDireccion.Enabled = true;
                    chbActivo.Enabled = true;
                    limpiarComponentes();
                    sucursalCliente = new ClienteSucursal();
                    break;
                case TipoVista.Anular:  //ya esta
                    btnNuevo.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false; ;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = (cmbCliente.SelectedIndex != -1) ? true : false;
                    cmbCliente.Enabled = true;
                    txtNroDocumento.Enabled = false;
                    txtNombreContacto.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    chbActivo.Enabled = false;
                    limpiarComponentes();
                    sucursalCliente = new ClienteSucursal();
                    break;
            }*/
        }

        public void limpiarComponentes()
        {
            /*txtNroDocumento.Text = "";
            txtNombreContacto.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            chbActivo.Checked = false;*/
        }


        private void btnEditarMemoria_Click(object sender, EventArgs e)
        {
            using (frmEditarMemoria frm = new frmEditarMemoria())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void btnEditarDisco_Click(object sender, EventArgs e)
        {
            using (frmEditarDisco frm = new frmEditarDisco())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void btnEditarLicencia_Click(object sender, EventArgs e)
        {
            using (frmEditarLicencia frm = new frmEditarLicencia())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (frmAgregarProducto frm = new frmAgregarProducto())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (LC laptopTraido in frm.LAPTOPS)
                    {
                        AlquilerDetalle dp = new AlquilerDetalle();
                        artTemp = new LC();
                        artTemp.IdLC = laptopTraido.IdLC;
                        bool exists = alquiler.Detalles.Any(x => x.Laptop.IdLC.Equals(artTemp.IdLC));
                        if (!(exists))
                        {
                            tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                            tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                            tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                            laptopTraido.SetDisco(tablaDisco);
                            laptopTraido.SetMemoria(tablaMemoria);
                            laptopTraido.SetLicencia(tablaLicencia);

                            dp.Laptop = laptopTraido;
                            alquiler.Detalles.Add(dp);
                        }
                    }
                    
                    
                }
            }
        }

        private void dtpIniPlazo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFinPlazo.Value < dtpIniPlazo.Value) dtpFinPlazo.Value = dtpIniPlazo.Value;
            dtpFinPlazo.MinDate = dtpIniPlazo.Value;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbCliente.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idCliente = Convert.ToInt32(tablaCliente.Rows[i]["idCliente"].ToString());
                tablaClienteSucursal = clienteDA.ListarSucursalCliente(idCliente);
                cmbSucursal.DataSource = (tablaClienteSucursal.Rows.Count > 0) ? tablaClienteSucursal : null;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "idSucursal";
                cmbSucursal.SelectedIndex = (tablaClienteSucursal.Rows.Count>0)?0:-1;
            }

        }

        private void dgvLaptopsSeleccionados_Click(object sender, EventArgs e)
        {
            GridRow aux = (GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow;
            if (aux != null)
            {

                artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());
                
                int indice = 0;
                foreach(AlquilerDetalle detalle in alquiler.Detalles)
                {
                    if(detalle.Laptop.IdLC== artTemp.IdLC)
                    {
                        break;
                    }
                    indice++;
                }
                AlquilerDetalle auxLC = new AlquilerDetalle();
                auxLC = alquiler.Detalles.SingleOrDefault(p => p.Laptop.IdLC == artTemp.IdLC);
                dgvDisco.PrimaryGrid.DataSource = alquiler.Detalles[indice].Laptop.Discos;
                dgvMemorias.PrimaryGrid.DataSource = auxLC.Laptop.Memorias;
                dgvLicencia.PrimaryGrid.DataSource = auxLC.Laptop.Licencias;
            }
        }
    }
}
