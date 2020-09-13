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
    public partial class frmProcesoIngreso : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaIngresoTipo;
        DataTable tablaProveedor;

        Ingreso ingreso;
        IngresoDA ingresoDA;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoIngreso()
        {
            InitializeComponent();
            Inicializado();
            estadoComponentes(TipoVista.Inicial);
        }
        public void Inicializado()
        {

            ingresoDA = new IngresoDA();
            ingreso = new Ingreso();
            dtpFechaIngreso.Value = DateTime.Now;



            tablaProveedor = ingresoDA.ListarProveedores();
            cmbProveedor.DataSource = tablaProveedor;
            cmbProveedor.DisplayMember = "razonSocial";
            cmbProveedor.ValueMember = "idProveedor";
            cmbProveedor.SelectedIndex = 0;
            int i = cmbProveedor.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                txtRUC.Text = tablaProveedor.Rows[i]["ruc"].ToString();
            }

            tablaIngresoTipo = ingresoDA.ListarIngresoTipo();
            cmbTipoIngreso.DataSource = tablaIngresoTipo;
            cmbTipoIngreso.DisplayMember = "descripcion";
            cmbTipoIngreso.ValueMember = "idAuxiliar";

            ingreso = new Ingreso();
            ingreso.Detalles = new BindingList<IngresoDetalle>();
            ObtenerDatosIngreso();
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = ingreso.Detalles;
            dgvLaptopsSeleccionados.PrimaryGrid.AutoGenerateColumns = false;
            dgvMemorias.PrimaryGrid.DataSource = ingreso.Memorias;
            dgvMemorias.PrimaryGrid.AutoGenerateColumns = false;
            dgvDisco.PrimaryGrid.DataSource = ingreso.Discos;
            dgvDisco.PrimaryGrid.AutoGenerateColumns = false;
            dgvLicencia.PrimaryGrid.DataSource = ingreso.Licencias;
            dgvLicencia.PrimaryGrid.AutoGenerateColumns = false;

        }

        public void ObtenerDatosIngreso()
        {

            ingreso.IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue.ToString());
            ingreso.IdTipoIngreso = Convert.ToInt32(cmbTipoIngreso.SelectedValue.ToString());
            int i = cmbProveedor.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                ingreso.Ruc = tablaProveedor.Rows[i]["ruc"].ToString();
                ingreso.RazonSocial = tablaProveedor.Rows[i]["razonSocial"].ToString();
            }
            ingreso.FechaIngreso = dtpFechaIngreso.Value;
            ingreso.Factura = txtFactura.Text;
            ingreso.Guia = txtGuia.Text;

        }


        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvDisco.Enabled = false;
                    dgvMemorias.Enabled = false;
                    dgvLicencia.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Nuevo:
                    cmbProveedor.Enabled = true;
                    cmbTipoIngreso.Enabled = true;
                    txtFactura.Enabled = true;
                    txtGuia.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    dgvDisco.Enabled = true;
                    dgvMemorias.Enabled = true;
                    dgvLicencia.Enabled = true;
                    btnAgregarDisco.Enabled = true;
                    btnAgregarMemoria.Enabled = true;
                    btnAgregarLicencia.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = true;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Guardar:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvDisco.Enabled = false;
                    dgvMemorias.Enabled = false;
                    dgvLicencia.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGrabar.Enabled = false;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    //limpiarComponentes();
                    break;
                case TipoVista.Modificar:
                    cmbProveedor.Enabled = true;
                    cmbTipoIngreso.Enabled = true;
                    txtFactura.Enabled = true;
                    txtGuia.Enabled = true;
                    dtpFechaIngreso.Enabled = true;
                    dgvLaptopsSeleccionados.Enabled = true;
                    dgvDisco.Enabled = true;
                    dgvMemorias.Enabled = true;
                    dgvLicencia.Enabled = true;
                    btnAgregarDisco.Enabled = true;
                    btnAgregarMemoria.Enabled = true;
                    btnAgregarLicencia.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = true;
                    //limpiarComponentes();
                    //alquiler = new Alquiler();
                    break;
                case TipoVista.Vista:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvDisco.Enabled = false;
                    dgvMemorias.Enabled = false;
                    dgvLicencia.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGrabar.Enabled = false;
                    //limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Limpiar:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvDisco.Enabled = false;
                    dgvMemorias.Enabled = false;
                    dgvLicencia.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAnular.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Duplicar:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvDisco.Enabled = false;
                    dgvMemorias.Enabled = false;
                    dgvLicencia.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGrabar.Enabled = false;
                    limpiarComponentes();
                    ingreso = new Ingreso();
                    break;
                case TipoVista.Anular:
                    cmbProveedor.Enabled = false;
                    cmbTipoIngreso.Enabled = false;
                    txtFactura.Enabled = false;
                    txtGuia.Enabled = false;
                    dtpFechaIngreso.Enabled = false;
                    dgvLaptopsSeleccionados.Enabled = false;
                    dgvDisco.Enabled = false;
                    dgvMemorias.Enabled = false;
                    dgvLicencia.Enabled = false;
                    btnAgregarDisco.Enabled = false;
                    btnAgregarMemoria.Enabled = false;
                    btnAgregarLicencia.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnEditar.Enabled = false;
                    btnGrabar.Enabled = false;
                    break;
            }
        }


        public void limpiarComponentes()
        {
            txtNroIngreso.Text = "";
            txtGuia.Text = "";
            txtFactura.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            dgvDisco.PrimaryGrid.DataSource = null;
            dgvMemorias.PrimaryGrid.DataSource = null;
            dgvLicencia.PrimaryGrid.DataSource = null;
            dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
        }
        

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            IngresoDetalle detalle = new IngresoDetalle();
            using (frmProcesoIngresoLaptopCpu frm = new frmProcesoIngresoLaptopCpu())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    detalle = frm.DETALLE;
                    detalle.IdIngresoDetalle = ingreso.Detalles.Count + 1;
                    ingreso.Detalles.Add(detalle);
                    dgvLaptopsSeleccionados.PrimaryGrid.DataSource = ingreso.Detalles;
                }
            }

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbProveedor.SelectedIndex;
            if (i >= 0) 
            {
                ingreso.Ruc = tablaProveedor.Rows[i]["ruc"].ToString();
                txtRUC.Text = tablaProveedor.Rows[i]["ruc"].ToString();
                ingreso.RazonSocial = tablaProveedor.Rows[i]["razonSocial"].ToString();
            }
        }

        private void btnAgregarMemoria_Click(object sender, EventArgs e)
        {
            using (frmProcesoIngresoMemoria frm = new frmProcesoIngresoMemoria())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (Memoria memoriaTraido in frm.MEMORIAS)
                    {
                        Memoria memTemp = new Memoria();
                        memTemp.IdMemoria = memoriaTraido.IdMemoria;
                        bool exists = ingreso.Memorias.Any(x => x.IdMemoria.Equals(memTemp.IdMemoria));
                        if (!(exists))
                        {
                            memTemp.TipoMemoria = memoriaTraido.TipoMemoria;
                            memTemp.Capacidad = memoriaTraido.Capacidad;
                            memTemp.Cantidad = 1;
                            ingreso.Memorias.Add(memTemp);
                        }
                    }
                    dgvMemorias.PrimaryGrid.DataSource = ingreso.Memorias;
                }
            }

        }

        private void dgvMemorias_DoubleClick(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro deseas Eliminar esta memoria", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dgvMemorias.PrimaryGrid.Rows.Count > 0)
                {
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
                    ingreso.Memorias = memorias;
                    dgvMemorias.PrimaryGrid.DataSource = ingreso.Memorias;
                }
            }
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            using (frmProcesoIngresoDisco frm = new frmProcesoIngresoDisco())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DiscoDuro discoTraido in frm.DISCOS)
                    {
                        DiscoDuro disTemp = new DiscoDuro();
                        disTemp.IdDisco = discoTraido.IdDisco;
                        bool exists = ingreso.Discos.Any(x => x.IdDisco.Equals(disTemp.IdDisco));
                        if (!(exists))
                        {
                            disTemp.TipoDisco = discoTraido.TipoDisco;
                            disTemp.Capacidad = discoTraido.Capacidad;
                            disTemp.Cantidad = 1;
                            ingreso.Discos.Add(disTemp);
                        }
                    }
                    dgvDisco.PrimaryGrid.DataSource = ingreso.Discos;
                }
            }

        }

        private void dgvDisco_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar este disco", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dgvDisco.PrimaryGrid.Rows.Count > 0)
                {
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
                            disco.Cantidad = int.Parse(((GridCell)(dgvDisco.PrimaryGrid.GetCell(i, 2))).Value.ToString());
                            discos.Add(disco);
                        }
                    }
                    ingreso.Discos = discos;
                    dgvDisco.PrimaryGrid.DataSource = ingreso.Discos;
                }
            }
        }

        private void btnAgregarLicencia_Click(object sender, EventArgs e)
        {
            using (frmProcesoIngresoLicencia frm = new frmProcesoIngresoLicencia())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (Licencia licenciaTraido in frm.LICENCIAS)
                    {
                        Licencia licTemp = new Licencia();
                        licTemp.IdModelo = licenciaTraido.IdModelo;
                        //bool exists = ingreso.Licencias.Any(x => x.IdModelo.Equals(licTemp.IdModelo));
                        bool exists = false;
                        if (!(exists))
                        {

                            licTemp.IdLicencia = ingreso.Licencias.Count + 1;
                            licTemp.Categoria = licenciaTraido.Categoria;
                            licTemp.IdModelo = licenciaTraido.IdModelo;
                            licTemp.Marca = licenciaTraido.Marca;
                            licTemp.Version = licenciaTraido.Version;
                            licTemp.Clave = licenciaTraido.Clave;
                            licTemp.Cantidad = licenciaTraido.Cantidad;

                            ingreso.Licencias.Add(licTemp);
                        }
                    }
                    dgvLicencia.PrimaryGrid.DataSource = ingreso.Licencias;
                }
            }
        }

        private void dgvLicencia_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta licencia", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int detTempId;
                if (dgvLicencia.PrimaryGrid.Rows.Count > 0)
                {
                    detTempId = int.Parse(((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[7])).Value.ToString());

                    int indiceLC = 0;
                    foreach (Licencia licencia in ingreso.Licencias)
                    {
                        if (licencia.IdLicencia == detTempId)
                        {
                            break;
                        }
                        indiceLC++;
                    }
                    ingreso.Licencias.RemoveAt(indiceLC);

                    for (int i = 0; i < ingreso.Detalles.Count; i++)
                    {
                        ingreso.Licencias[i].IdLicencia = i + 1;
                    }

                    dgvLicencia.PrimaryGrid.DataSource = ingreso.Licencias;
                }

            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar el proceso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                estadoComponentes(TipoVista.Limpiar);
                ingreso = new Ingreso();
                dgvDisco.PrimaryGrid.DataSource = null;
                dgvMemorias.PrimaryGrid.DataSource = null;
                dgvLicencia.PrimaryGrid.DataSource = null;
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = null;
            }
        }

        public void LlenarDatosAlquiler()
        {
            cmbProveedor.SelectedValue = ingreso.IdProveedor;
            cmbTipoIngreso.SelectedValue = ingreso.IdTipoIngreso;
            txtRUC.Text = ingreso.Ruc;
            dtpFechaIngreso.Value = ingreso.FechaIngreso;
            txtFactura.Text = ingreso.Factura;
            txtGuia.Text = ingreso.Guia;
            txtNroIngreso.Text = ingreso.IdIngreso.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Vista);
            frmProcesoAlquilerBuscar frmBP = new frmProcesoAlquilerBuscar(this.idUsuario);
            if (frmBP.ShowDialog() == DialogResult.OK)
            {
                //ingreso = frmBP.ObjSeleccionado;
                if (ingreso.Estado == 6 || ingreso.Estado == 4)//Esto es si está en un estado donde todavía se puede modificar la laptop
                {
                    for (int i = 0; i < ingreso.Detalles.Count; i++)
                    {
                        //ingreso.Detalles[i].Laptop = ingresoDA.LlenarDetalleDeUnaLaptop(ingreso.Detalles[i].Laptop.IdLC);
                    }
                }
                else
                {
                    for (int i = 0; i < ingreso.Detalles.Count; i++)
                    {
                        //ingreso.Detalles[i].Laptop = ingresoDA.LlenarDetalleDeUnaLaptopDesdeMismoAlquilerDetalle(alquiler.Detalles[i]);
                    }

                }
                txtNroIngreso.Text = ingreso.IdIngreso.ToString();
                LlenarDatosAlquiler();
                dgvLaptopsSeleccionados.PrimaryGrid.DataSource = ingreso.Detalles;
            }
            else
            {
                estadoComponentes(TipoVista.Inicial);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (ingreso.Estado == 7 || ingreso.Estado == 0)//en teoría 7 debería ser finalizado
            {
                MessageBox.Show("Este ingreso ya no se puede modificar", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Modificar\n" + "el Ingreso N° :" + txtNroIngreso.Text, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    estadoComponentes(TipoVista.Modificar);

                }

            }
        }

        private void dgvLaptopsSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro deseas Eliminar esta detalle de Ingreso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int detTempId;
                if (dgvLaptopsSeleccionados.PrimaryGrid.Rows.Count > 0)
                {
                    detTempId = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[6])).Value.ToString());

                    int indiceLC = 0;
                    foreach (IngresoDetalle detalle in ingreso.Detalles)
                    {
                        if (detalle.IdIngresoDetalle == detTempId)
                        {
                            break;
                        }
                        indiceLC++;
                    }

                    ingreso.Detalles.RemoveAt(indiceLC);
                    for(int i = 0; i < ingreso.Detalles.Count; i++)
                    {
                        ingreso.Detalles[i].IdIngresoDetalle = i + 1;
                    }

                    dgvLaptopsSeleccionados.PrimaryGrid.DataSource = ingreso.Detalles;
                }
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            if (ingreso.Estado == 0)
            {
                MessageBox.Show("Este ingreso ya se encuentra en estado Anulado", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ingreso.Estado == 8 || ingreso.Estado == 9)//los estados de aqui todavía están por definir
            {
                MessageBox.Show("Este ingreso no se puede anular", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desea Anular este ingreso", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ingreso.Estado = 0;
                    //ingresorDA.AnularAlquiler(ingreso, this.nombreUsuario);
                    MessageBox.Show("Se anulo el Ingreso N° :" + ingreso.IdIngreso, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoComponentes(TipoVista.Anular);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }
        
        private void dgvMemorias_CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            int i = dgvMemorias.PrimaryGrid.ActiveRow.Index;
            int memoriaId;
            int aux;
            int cantidadMemoria;
            string myStr;
            if (!(i == -1))
            {
                myStr = ((GridCell)(((GridRow)dgvMemorias.PrimaryGrid.ActiveRow)[2])).Value.ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    aux = int.Parse(myStr);
                    if (aux < 0) myStr = "1";
                }
                else myStr = "1";
                cantidadMemoria= myStr.Length > 0 ? int.Parse(myStr) : 1;
                ((GridCell)(((GridRow)dgvMemorias.PrimaryGrid.ActiveRow)[2])).Value = cantidadMemoria;

                memoriaId = int.Parse(((GridCell)(((GridRow)dgvMemorias.PrimaryGrid.ActiveRow)[3])).Value.ToString());

                for (int j = 0; j < ingreso.Memorias.Count; j++)
                {
                    if (memoriaId == ingreso.Memorias[j].IdMemoria) ingreso.Memorias[j].Cantidad = cantidadMemoria;
                }
            }

        }

        private void dgvDisco_CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            int i = dgvDisco.PrimaryGrid.ActiveRow.Index;
            int discoId;
            int aux;
            int cantidadDisco;
            string myStr;
            if (!(i == -1))
            {
                myStr = ((GridCell)(((GridRow)dgvDisco.PrimaryGrid.ActiveRow)[2])).Value.ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    aux = int.Parse(myStr);
                    if (aux < 0) myStr = "1";
                }
                else myStr = "1";
                cantidadDisco = myStr.Length > 0 ? int.Parse(myStr) : 1;
                ((GridCell)(((GridRow)dgvDisco.PrimaryGrid.ActiveRow)[2])).Value = cantidadDisco;

                discoId = int.Parse(((GridCell)(((GridRow)dgvDisco.PrimaryGrid.ActiveRow)[3])).Value.ToString());

                for (int j = 0; j < ingreso.Discos.Count; j++)
                {
                    if (discoId == ingreso.Discos[j].IdDisco) ingreso.Discos[j].Cantidad = cantidadDisco;
                }
            }

        }
        private void dgvLicencia_CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            int i = dgvLicencia.PrimaryGrid.ActiveRow.Index;
            int licenciaId;
            int aux;
            int cantidadLicencia;
            string myStr;
            string clave="";
            if (!(i == -1))
            {
                myStr = ((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[4])).Value.ToString();
                myStr = myStr.TrimStart('0');

                if (myStr.Length > 0)
                {
                    aux = int.Parse(myStr);
                    if (aux < 0) myStr = "1";
                }
                else myStr = "1";
                cantidadLicencia = myStr.Length > 0 ? int.Parse(myStr) : 1;
                ((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[4])).Value = cantidadLicencia;

                if (((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[3])).Value != null)
                {
                    clave = ((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[3])).Value.ToString();
                    clave = clave.Trim();
                }
                ((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[3])).Value = clave;


                licenciaId = int.Parse(((GridCell)(((GridRow)dgvLicencia.PrimaryGrid.ActiveRow)[7])).Value.ToString());

                for (int j = 0; j < ingreso.Discos.Count; j++)
                {
                    if (licenciaId == ingreso.Licencias[j].IdLicencia)
                    {
                        ingreso.Licencias[j].Cantidad = cantidadLicencia;
                        ingreso.Licencias[j].Clave = clave;
                    } 
                }
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            int detTempId;
            IngresoDetalle det = new IngresoDetalle();
            int indiceLC = 0;

            if (dgvLaptopsSeleccionados.PrimaryGrid.Rows.Count > 0)
            {
                detTempId = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[6])).Value.ToString());

                foreach (IngresoDetalle detalle in ingreso.Detalles)
                {
                    if (detalle.IdIngresoDetalle == detTempId)
                        break;
                    indiceLC++;
                }
            }

            using (frmProcesoIngresoLaptopCpu frm = new frmProcesoIngresoLaptopCpu(ingreso.Detalles[indiceLC]))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (dgvLaptopsSeleccionados.PrimaryGrid.Rows.Count > 0)
                    {
                        detTempId = int.Parse(((GridCell)(((GridRow)dgvLaptopsSeleccionados.PrimaryGrid.ActiveRow)[6])).Value.ToString());

                        int indiceLC2 = 0;
                        foreach (IngresoDetalle detalle in ingreso.Detalles)
                        {
                            if (detalle.IdIngresoDetalle == detTempId)
                            {
                                break;
                            }
                            indiceLC2++;
                        }

                        ingreso.Detalles.RemoveAt(indiceLC2);
                        for (int i = 0; i < ingreso.Detalles.Count; i++)
                        {
                            ingreso.Detalles[i].IdIngresoDetalle = i + 1;
                        }

                        dgvLaptopsSeleccionados.PrimaryGrid.DataSource = ingreso.Detalles;
                    }

                    det = frm.DETALLE;
                    det.IdIngresoDetalle = ingreso.Detalles.Count + 1;
                    ingreso.Detalles.Add(det);
                    dgvLaptopsSeleccionados.PrimaryGrid.DataSource = ingreso.Detalles;
                }
            }
        }
    }
}
