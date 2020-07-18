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
    public partial class frmAlquiler : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        System.Data.DataTable tablaCliente;
        System.Data.DataTable tablaClienteSucursal;
        System.Data.DataTable tablaDisco;
        System.Data.DataTable tablaMemoria;
        System.Data.DataTable tablaLicencia;
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

            alquiler.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            alquiler.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue.ToString());
            alquiler.FechaSalida = dtpFechaTraslado.Value;
            alquiler.FechaIniContrato = dtpIniPlazo.Value;
            alquiler.FechaFinContrato = dtpFinPlazo.Value;
            alquiler.NroContrato = txtNroContrato.Text;
            alquiler.NroOC = txtNroOC.Text;
            alquiler.RucDni = txtNroDocumento.Text;

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
            //laptop.IdLC = int.Parse(((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 9))).Value.ToString());
            dgvMemorias.PrimaryGrid.Columns[2].AllowEdit=true;
            //dgvMemorias.PrimaryGrid.AllowEdit = true;
        }

        private void btnEditarDisco_Click(object sender, EventArgs e)
        {
            //laptop.IdLC = int.Parse(((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 9))).Value.ToString());
            dgvDisco.PrimaryGrid.Columns[2].AllowEdit = true;
            //dgvMemorias.PrimaryGrid.AllowEdit = true;

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
                /*AlquilerDetalle auxLC = new AlquilerDetalle();
                auxLC = alquiler.Detalles.SingleOrDefault(p => p.Laptop.IdLC == artTemp.IdLC);
                dgvDisco.PrimaryGrid.DataSource = alquiler.Detalles[indice].Laptop.Discos;
                dgvMemorias.PrimaryGrid.DataSource = auxLC.Laptop.Memorias;
                dgvLicencia.PrimaryGrid.DataSource = auxLC.Laptop.Licencias;*/


                tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                dgvDisco.PrimaryGrid.DataSource = tablaDisco;
                dgvMemorias.PrimaryGrid.DataSource = tablaMemoria;
                dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;
            }
        }

        private void btnAgregarMemoria_Click(object sender, EventArgs e)
        {

            using (frmEditarMemoria frm = new frmEditarMemoria())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }
                    
                    foreach (Memoria memoriaTraido in frm.MEMORIAS)
                    {
                        Memoria memTemp = new Memoria();
                        memTemp.IdMemoria = memoriaTraido.IdMemoria;
                        bool exists = alquiler.Detalles[indice].Laptop.Memorias.Any(x => x.IdMemoria.Equals(memTemp.IdMemoria));
                        if (!(exists))
                        {
                            memTemp.TipoMemoria = memoriaTraido.TipoMemoria;
                            memTemp.Capacidad = memoriaTraido.Capacidad;
                            memTemp.Cantidad = 1;
                            alquiler.Detalles[indice].Laptop.Memorias.Add(memTemp);
                        }
                    }

                    bool error;
                    if (dgvMemorias.PrimaryGrid.Rows.Count > 0)
                    {
                        error = alquilerDA.ActualizarLaptopMemoria(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Memorias, this.nombreUsuario);
                    }
                    else
                    {
                        error = alquilerDA.InsertarLaptopMemoriasPrimeraVez(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Memorias, this.nombreUsuario);
                    }
                    
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en agregar las memorias seleccionadas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    
                    MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                    dgvMemorias.PrimaryGrid.DataSource = tablaMemoria;
                }
            }

            
        }

        private void btnGuardarMemoria_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Estas seguro deseas Guardar los cambios hechos en tus memorias actuales", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                if (dgvMemorias.PrimaryGrid.Rows.Count > 0)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<Memoria> memorias = new BindingList<Memoria>();
                    for (int i = 0; i < dgvMemorias.PrimaryGrid.Rows.Count; i++)
                    {
                        Memoria memoria = new Memoria();
                        memoria.IdMemoria = int.Parse(((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 3))).Value.ToString());
                        memoria.TipoMemoria = ((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 0))).Value.ToString();
                        memoria.Capacidad = int.Parse(((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 1))).Value.ToString());
                        memoria.Cantidad = int.Parse(((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 2))).Value.ToString());
                        memorias.Add(memoria);
                    }
                    error = alquilerDA.ActualizarLaptopMemoria(artTemp.IdLC, memorias, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en el cambio de piezas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Memorias = memorias;
                    MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void dgvMemorias_DoubleClick(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Estas seguro deseas Eliminar esta memoria", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                if (dgvMemorias.PrimaryGrid.Rows.Count > 0)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<Memoria> memorias = new BindingList<Memoria>();
                    for (int i = 0; i < dgvMemorias.PrimaryGrid.Rows.Count; i++)
                    {
                        Memoria memoria = new Memoria();
                        int memoriaID = int.Parse(((GridCell)(((GridRow)dgvMemorias.PrimaryGrid.ActiveRow)[3])).Value.ToString());
                        memoria.IdMemoria = int.Parse(((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 3))).Value.ToString());
                        if (memoriaID != memoria.IdMemoria)
                        {
                            memoria.TipoMemoria = ((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 0))).Value.ToString();
                            memoria.Capacidad = int.Parse(((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 1))).Value.ToString());
                            memoria.Cantidad = int.Parse(((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 2))).Value.ToString());
                            memorias.Add(memoria);

                        }
                    }
                    error = alquilerDA.ActualizarLaptopMemoria(artTemp.IdLC, memorias, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error, no se pudo eliminar esta memoria, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Memorias = memorias;
                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaMemoria = alquilerDA.ListarLaptopMemoria(artTemp.IdLC);
                    dgvMemorias.PrimaryGrid.DataSource = tablaMemoria;
                }
            }
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {

            using (frmEditarDisco frm = new frmEditarDisco())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }
                    
                    foreach (DiscoDuro discoTraido in frm.DISCOS)
                    {
                        DiscoDuro disTemp = new DiscoDuro();
                        disTemp.IdDisco = discoTraido.IdDisco;
                        bool exists = alquiler.Detalles[indice].Laptop.Discos.Any(x => x.IdDisco.Equals(disTemp.IdDisco));
                        if (!(exists))
                        {
                            disTemp.TipoDisco = discoTraido.TipoDisco;
                            disTemp.Capacidad = discoTraido.Capacidad;
                            disTemp.Cantidad = 1;
                            alquiler.Detalles[indice].Laptop.Discos.Add(disTemp); 
                        }
                    }

                    bool error;
                    if (dgvDisco.PrimaryGrid.Rows.Count > 0)
                    {
                        error = alquilerDA.ActualizarLaptopDisco(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Discos, this.nombreUsuario);
                    }
                    else
                    {
                        error = alquilerDA.InsertarLaptopDiscosPrimeraVez(artTemp.IdLC, alquiler.Detalles[indice].Laptop.Discos, this.nombreUsuario);
                    }

                    if (!error)
                    {
                        MessageBox.Show("Hubo error en agregar los discos seleccionados, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }


                    MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                    dgvDisco.PrimaryGrid.DataSource = tablaDisco;
                }
            }
        }
        private void dgvDisco_DoubleClick(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Eliminar este disco", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                if (dgvDisco.PrimaryGrid.Rows.Count > 0)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<DiscoDuro> discos = new BindingList<DiscoDuro>();
                    for (int i = 0; i < dgvDisco.PrimaryGrid.Rows.Count; i++)
                    {
                        DiscoDuro disco = new DiscoDuro();
                        int discoID = int.Parse(((GridCell)(((GridRow)dgvDisco.PrimaryGrid.ActiveRow)[3])).Value.ToString());
                        disco.IdDisco = int.Parse(((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 3))).Value.ToString());
                        if (discoID != disco.IdDisco)
                        {
                            disco.TipoDisco = ((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 0))).Value.ToString();
                            disco.Capacidad = int.Parse(((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 1))).Value.ToString());
                            disco.Cantidad = int.Parse(((GridCell)(dgvMemorias.PrimaryGrid.GetCell(i, 2))).Value.ToString());
                            discos.Add(disco);

                        }
                    }
                    error = alquilerDA.ActualizarLaptopDisco(artTemp.IdLC, discos, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error, no se pudo eliminar este disco, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Discos = discos;
                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaDisco = alquilerDA.ListarLaptopDisco(artTemp.IdLC);
                    dgvDisco.PrimaryGrid.DataSource = tablaDisco;
                }
            }
        }

        private void btnGuardarDisco_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Guardar los cambios hechos en tus discos actuales", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                if (dgvDisco.PrimaryGrid.Rows.Count > 0)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }

                    BindingList<DiscoDuro> discos = new BindingList<DiscoDuro>();
                    for (int i = 0; i < dgvDisco.PrimaryGrid.Rows.Count; i++)
                    {
                        DiscoDuro disco = new DiscoDuro();
                        disco.IdDisco = int.Parse(((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 3))).Value.ToString());
                        disco.TipoDisco = ((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 0))).Value.ToString();
                        disco.Capacidad = int.Parse(((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 1))).Value.ToString());
                        disco.Cantidad = int.Parse(((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 2))).Value.ToString());
                        discos.Add(disco);
                    }
                    error = alquilerDA.ActualizarLaptopDisco(artTemp.IdLC, discos, this.nombreUsuario);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en el cambio de piezas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    alquiler.Detalles[indice].Laptop.Discos = discos;
                    MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnAgregarLicencia_Click(object sender, EventArgs e)
        {
            using (frmEditarLicencia frm = new frmEditarLicencia())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());

                    int indice = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indice++;
                    }
                    BindingList<Licencia> licenciaAux = new BindingList<Licencia>();
                    foreach (Licencia licenciaTraido in frm.LICENCIAS)
                    {
                        Licencia licTemp = new Licencia();
                        licTemp.IdLicencia = licenciaTraido.IdLicencia;
                        licTemp.Categoria = licenciaTraido.Categoria;
                        bool exists = alquiler.Detalles[indice].Laptop.Licencias.Any(x => x.Categoria.Equals(licTemp.Categoria));
                        if (!(exists))
                        {
                            licTemp.Categoria = licenciaTraido.Categoria;
                            licTemp.Marca = licenciaTraido.Marca;
                            licTemp.Version = licenciaTraido.Version;
                            licTemp.Clave = licenciaTraido.Clave;

                            licenciaAux.Add(licTemp);
                        }
                    }

                    bool error=true;

                    if (licenciaAux.Count > 0)
                        error = alquilerDA.InsertarLaptopLicenciaPrimeraVez(artTemp.IdLC, licenciaAux, this.nombreUsuario);
                    else return;

                    if (!error)
                    {
                        MessageBox.Show("Hubo error en agregar las licencias seleccionadas, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    foreach (Licencia licenciaTraido in licenciaAux)
                    {
                        alquiler.Detalles[indice].Laptop.Licencias.Add(licenciaTraido);
                    }

                    MessageBox.Show("Se realizó el cambio de piezas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                    dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;
                }
            }
        }


        private void btnCaducidadLicencia_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Poner en caducidad esta licencia", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                if (dgvLicencia.PrimaryGrid.Rows.Count > 0)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());
                    int licTempId = int.Parse(((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[4])).Value.ToString());

                    error = alquilerDA.ActualizarLaptopLicencia(artTemp.IdLC, licTempId, this.nombreUsuario, 0);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en poner en caducidad esta licencia, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    int indiceLC = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    //Hasta aqui ya se encontro la licencia del ID y el indice de donde se ubica en el detalle

                    int indiceLic = 0;
                    foreach (Licencia licencia in alquiler.Detalles[indiceLC].Laptop.Licencias)
                    {
                        if (licencia.IdLicencia == licTempId)
                        {
                            break;
                        }
                        indiceLic++;
                    }

                    alquiler.Detalles[indiceLC].Laptop.Licencias.RemoveAt(indiceLic);

                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                    dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;
                }
            }
        }

        private void btnEliminarLicencia_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Eliminar esta licencia", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool error;
                if (dgvLicencia.PrimaryGrid.Rows.Count > 0)
                {
                    artTemp.IdLC = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[8])).Value.ToString());
                    int licTempId  = int.Parse(((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[4])).Value.ToString());

                    error = alquilerDA.ActualizarLaptopLicencia(artTemp.IdLC, licTempId, this.nombreUsuario,1);
                    if (!error)
                    {
                        MessageBox.Show("Hubo error en eliminar esta licencia, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    int indiceLC = 0;
                    foreach (AlquilerDetalle detalle in alquiler.Detalles)
                    {
                        if (detalle.Laptop.IdLC == artTemp.IdLC)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    //Hasta aqui ya se encontro la licencia del ID y el indice de donde se ubica en el detalle
                    
                    int indiceLic = 0;
                    foreach (Licencia licencia in alquiler.Detalles[indiceLC].Laptop.Licencias)
                    {
                        if (licencia.IdLicencia == licTempId)
                        {
                            break;
                        }
                        indiceLic++;
                    }

                    alquiler.Detalles[indiceLC].Laptop.Licencias.RemoveAt(indiceLic);

                    MessageBox.Show("Se eliminó la pieza seleccionada", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tablaLicencia = alquilerDA.ListarLaptopLicencia(artTemp.IdLC);
                    dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Guardar este proceso de Pre-Alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ObtenerDatosAlquiler();
                bool error = alquilerDA.InsertarPreAlquiler(alquiler, this.nombreUsuario);
                        
                if (!error)
                {
                    MessageBox.Show("Hubo error en Registrar el Pre-Alquiler, comunicarse con tu soporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                    
                MessageBox.Show("Se guradó el Pre-Alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                alquiler = new Alquiler();
                dgvDisco.PrimaryGrid.DataSource = null;
                dgvMemorias.PrimaryGrid.DataSource = null;
                dgvLicencia.PrimaryGrid.DataSource = null;
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Imprimir el Pre-Alquiler", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    SaveFileDialog fichero = new SaveFileDialog();
                    fichero.Filter = "Excel (*.xls)|*.xls";
                    fichero.FileName = "NombreDelAlquiler";
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application aplicacion;
                        Excel.Workbook libros_trabajo;
                        Excel.Worksheet hoja_pre_alquiler;

                        aplicacion = new Excel.Application();
                        libros_trabajo = (Excel.Workbook)aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

                        hoja_pre_alquiler = (Excel.Worksheet)libros_trabajo.Worksheets.Add();
                        hoja_pre_alquiler.Name = "Pre-Alquiler";
                        string cabecera = "Reporte de Pre-Alquiler";
                        ExportarDataGridViewExcel(ref hoja_pre_alquiler, dgvLaptopsSeleccionados, cabecera);


                        ((Excel.Worksheet)aplicacion.ActiveWorkbook.Sheets["Hoja1"]).Delete();

                        libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                        libros_trabajo.Close(true);
                        releaseObject(libros_trabajo);
                        aplicacion.Quit();
                        releaseObject(aplicacion);
                        MessageBox.Show("Se generó el reporte con éxito", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public void ExportarDataGridViewExcel(ref Excel.Worksheet hoja_trabajo, SuperGridControl grd, string nombreCabecera)
        {
            Excel.Range rango;
            int i = 0;
            //Recorremos el DataGridView rellenando la hoja de trabajo
            foreach (AlquilerDetalle det in alquiler.Detalles)
            {
                //int k = grd.Columns.Count + 64;
                int k = 12 + 64;
                char columF = (char)k;
                int fila2 = i + 8;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[i + 8, 1] = "LAPTOP "+ det.Laptop.Codigo;
                hoja_trabajo.Cells[i + 8, 2] = det.Laptop.Modelo.NombreMarca;
                hoja_trabajo.Cells[i + 8, 3] = det.Laptop.Modelo.NombreModelo;
                string aux = "";
                aux = det.Laptop.Procesador.Modelo.NombreModelo + "/GEN" + det.Laptop.Procesador.Generacion.ToString();
                hoja_trabajo.Cells[i + 8, 4] = aux;
                hoja_trabajo.Cells[i + 8, 5] = det.Laptop.Video.Capacidad.ToString() + " GB";

                hoja_trabajo.Cells[i + 8, 9] = det.Laptop.TamanoPantalla.ToString();

                string tipoDisco1 = ""; int capDisco1 = 0; string tipoDisco2 = ""; int capDisco2 = 0;
                if (det.Laptop.Discos.Count > 0)
                {
                    if (det.Laptop.Discos.Count == 1)
                    {
                        tipoDisco1 = det.Laptop.Discos[0].TipoDisco;
                        capDisco1 = det.Laptop.Discos[0].Cantidad* det.Laptop.Discos[0].Capacidad;
                    }
                    else if (det.Laptop.Discos.Count >= 2)
                    {
                        tipoDisco1 = det.Laptop.Discos[0].TipoDisco;
                        capDisco1 = det.Laptop.Discos[0].Cantidad * det.Laptop.Discos[0].Capacidad;

                        tipoDisco2 = det.Laptop.Discos[1].TipoDisco;
                        capDisco2 = det.Laptop.Discos[1].Cantidad * det.Laptop.Discos[1].Capacidad;
                    }
                }

                hoja_trabajo.Cells[i + 8, 6] = (tipoDisco1.Length > 0) ? tipoDisco1 + " - " + capDisco1.ToString() + " GB" : "";
                hoja_trabajo.Cells[i + 8, 7] = (tipoDisco2.Length > 0) ? tipoDisco2 + " - " + capDisco2.ToString() + " GB" : "";

                int capacidadMem = 0;
                foreach(Memoria mem in det.Laptop.Memorias)
                {
                    capacidadMem += mem.Capacidad;
                }
                hoja_trabajo.Cells[i + 8, 8] = capacidadMem.ToString()+" GB";

                Licencia windows = null; Licencia office = null; Licencia antivirus = null;

                if (det.Laptop.Licencias.Count > 0)
                {
                    windows = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == "WINDOWS");
                    office = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == "OFFICE");
                    antivirus = det.Laptop.Licencias.SingleOrDefault(p => p.Categoria == "ANTIVIRUS");

                }

                hoja_trabajo.Cells[i + 8, 10] = (windows != null) ? windows.Version : "";
                hoja_trabajo.Cells[i + 8, 11] = (office != null) ? office.Version : "";
                hoja_trabajo.Cells[i + 8, 12] = (antivirus != null) ? antivirus.Version : "";


                i++;
            }
            montaCabeceras(1, ref hoja_trabajo, grd, nombreCabecera);
        }
        private void montaCabeceras(int fila, ref Excel.Worksheet hoja, SuperGridControl grd, string nombreCabecera)
        {
            try
            {
                Excel.Range rango;

                //** Montamos el título en la línea 1 **
                hoja.Cells[fila, 1] = nombreCabecera;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 12]].Merge();
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 12]].Interior.Color = Color.Silver;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, 12]].Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //worksheet.Range[worksheet.Cells[rowNum, columnNum], worksheet.Cells[rowNum, columnNum]].Merge();
                int indice;

                hoja.Cells[fila + 1, 1] = "Alquiler N°";

                hoja.Cells[fila + 2, 1] = "Cliente°";
                indice = cmbCliente.SelectedIndex;
                hoja.Cells[fila + 2, 2] = tablaCliente.Rows[indice]["nombre_razonSocial"].ToString();
                hoja.Cells[fila + 3, 1] = "Dirección";
                indice = cmbSucursal.SelectedIndex;
                hoja.Cells[fila + 3, 2] = tablaClienteSucursal.Rows[indice]["direccion"].ToString();
                hoja.Cells[fila + 4, 1] = "RUC";
                hoja.Cells[fila + 4, 2] = txtNroDocumento.Text;
                
                hoja.Cells[fila + 2, 5] = "Fecha Traslado";
                hoja.Cells[fila + 2, 6] = dtpFechaTraslado.Value.ToShortDateString();
                hoja.Cells[fila + 3, 5] = "Fecha Inicio Contrato";
                hoja.Cells[fila + 3, 6] = dtpIniPlazo.Value.ToShortDateString();
                hoja.Cells[fila + 4, 5] = "Fecha Fin Contrato";
                hoja.Cells[fila + 4, 6] = dtpFinPlazo.Value.ToShortDateString();
                
                hoja.Cells[fila + 2, 8] = "N° Contrato";
                hoja.Cells[fila + 2, 9] = txtNroContrato.Text;
                hoja.Cells[fila + 3, 8] = "N° OC";
                hoja.Cells[fila + 3, 9] = txtNroOC.Text;

                hoja.Cells[fila + 6, 1] = "Equipo";
                hoja.Cells[fila + 6, 2] = "Marca";
                hoja.Cells[fila + 6, 3] = "Modelo";
                hoja.Cells[fila + 6, 4] = "Procesador";
                hoja.Cells[fila + 6, 5] = "Video";
                hoja.Cells[fila + 6, 6] = "Disco 1";
                hoja.Cells[fila + 6, 7] = "Disco 2";
                hoja.Cells[fila + 6, 8] = "Memoria";
                hoja.Cells[fila + 6, 9] = "Pantalla";
                hoja.Cells[fila + 6, 10] = "Windows";
                hoja.Cells[fila + 6, 11] = "Office";
                hoja.Cells[fila + 6, 12] = "Antivirus";
                
                //int i = grd.Columns.Count + 64;
                int i = 12 + 64;
                char columF = (char)i;
                int fila2 = fila + 6;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Interior.Color = Color.Silver;
                rango.Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila2];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //for (int j = 0; j < grd.Columns.Count; j++)
                for (int j = 0; j < 12; j++)
                {
                    rango = hoja.Columns[j + 1];
                    rango.ColumnWidth = 10;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de redondeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error mientras liberaba objecto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
