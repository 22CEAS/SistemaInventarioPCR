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
    public partial class frmProcesoIngresoLaptopCpu : Form
    {
        DataTable tablaMarca;
        DataTable tablaModelo;
        DataTable tablaDestino;
        DataTable tablaProcesador;
        DataTable tablaMemoria;
        DataTable tablaDisco;
        DataTable tablaVideo;
        DataTable tablaLicencia;
        IngresoDetalle detalle;

        IngresoDA ingresoDA;
        LC laptop;
        Procesador procesador;
        Video video;
        DiscoDuro disco;
        Memoria memoria;
        Licencia licencia;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoIngresoLaptopCpu()
        {
            InitializeComponent();
            Inicializado();
        }
        public void Inicializado()
        {

            ingresoDA = new IngresoDA();
            laptop = new LC();
            detalle = new IngresoDetalle();

            txtCantidad.Text = "1";

            tablaProcesador = ingresoDA.ListarProcesadores();
            dgvProcesador.PrimaryGrid.AutoGenerateColumns = false;
            dgvProcesador.PrimaryGrid.DataSource = tablaProcesador;

            tablaMemoria = ingresoDA.ListarMemorias();
            dgvMemoria.PrimaryGrid.AutoGenerateColumns = false;
            dgvMemoria.PrimaryGrid.DataSource = tablaMemoria;

            tablaDisco = ingresoDA.ListarDiscosDuros();
            dgvDiscoDuro.PrimaryGrid.AutoGenerateColumns = false;
            dgvDiscoDuro.PrimaryGrid.DataSource = tablaDisco;

            tablaVideo = ingresoDA.ListarTarjetaVideos();
            dgvVideo.PrimaryGrid.AutoGenerateColumns = false;
            dgvVideo.PrimaryGrid.DataSource = tablaVideo;

            tablaLicencia = ingresoDA.ListarLicencias();
            dgvLicencia.PrimaryGrid.AutoGenerateColumns = false;
            dgvLicencia.PrimaryGrid.DataSource = tablaLicencia;

            tablaMarca = ingresoDA.ListarMarcas();
            cmbMarca.DataSource = tablaMarca;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = 0;
            int i = cmbMarca.SelectedIndex;

            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                tablaModelo = ingresoDA.ListarModelos(idMarca);
                cmbModelo.DataSource = tablaModelo;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = 0;
            }
            //tablaDestino = ingresoDA.ListarDestinos();
            //cmbDestino.DataSource = tablaDestino;
            //cmbDestino.DisplayMember = "nombre";
            //cmbDestino.ValueMember = "idDestino";
        }


        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbMarca.SelectedIndex;
            if (i >= 0) //Esto verifica que se ha seleccionado algún item del comboBox
            {
                int idMarca = Convert.ToInt32(tablaMarca.Rows[i]["idMarca"].ToString());
                tablaModelo = ingresoDA.ListarModelos(idMarca);
                cmbModelo.DataSource = (tablaModelo.Rows.Count > 0) ? tablaModelo : null;
                cmbModelo.DisplayMember = "nombre";
                cmbModelo.ValueMember = "idModelo";
                cmbModelo.SelectedIndex = (tablaModelo.Rows.Count > 0) ? 0 : -1;
            }

        }

        public bool llenarListaLaptops()
        {
            bool flag = false;
            laptop = new LC();
            

            int j = cmbMarca.SelectedIndex;
            laptop.Modelo.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            laptop.Modelo.NombreMarca = tablaMarca.Rows[j]["nombre"].ToString();
            j = cmbModelo.SelectedIndex;
            laptop.Modelo.IdModelo = Convert.ToInt32(cmbModelo.SelectedValue.ToString());
            laptop.Modelo.NombreModelo = tablaModelo.Rows[j]["nombre"].ToString();
            laptop.TamanoPantalla = Double.Parse(txtPantalla.Text);
            laptop.PartNumber = txtPantalla.Text;
            laptop.Garantia = (chbGarantia.Checked) ? 1 : 0;
            detalle.Laptop = laptop;
            detalle.Precio = Double.Parse(txtPrecio.Text);
            detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalle.Series=null;
            BindingList<String> series = new BindingList<String>();

            for (int i = 0; i < dgvSerieFabrica.Rows.Count; i++)
            {
                if (!dgvSerieFabrica.Rows[i].IsNewRow)
                {
                    if (dgvSerieFabrica.Rows[i].Cells[1].Value != null)
                    {
                        String serie = dgvSerieFabrica.Rows[i].Cells[1].Value.ToString();
                        series.Add(serie);
                    }
                }
            }
            detalle.Series = series;

            
            int filas = tablaProcesador.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvProcesador.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvProcesador.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        procesador = new Procesador();
                        procesador.IdProcesador = int.Parse(((GridCell)(dgvProcesador.PrimaryGrid.GetCell(i, 7))).Value.ToString());
                        procesador.IdModelo = int.Parse(((GridCell)(dgvProcesador.PrimaryGrid.GetCell(i, 8))).Value.ToString());
                        procesador.Modelo.NombreModelo = ((GridCell)(dgvProcesador.PrimaryGrid.GetCell(i, 2))).Value.ToString();
                        laptop.Procesador=procesador;
                        flag = true;
                    }
                }
            }

            filas = tablaVideo.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvVideo.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvVideo.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        video = new Video();
                        video.IdVideo = int.Parse(((GridCell)(dgvVideo.PrimaryGrid.GetCell(i, 6))).Value.ToString());
                        video.IdModelo = int.Parse(((GridCell)(dgvVideo.PrimaryGrid.GetCell(i, 7))).Value.ToString());
                        video.Modelo.NombreModelo = ((GridCell)(dgvVideo.PrimaryGrid.GetCell(i, 2))).Value.ToString();
                        laptop.Video = video;
                        flag = true;
                    }
                }
            }

            filas = tablaMemoria.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvMemoria.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvMemoria.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        memoria = new Memoria();
                        memoria.IdMemoria = int.Parse(((GridCell)(dgvMemoria.PrimaryGrid.GetCell(i, 5))).Value.ToString());
                        memoria.IdModelo = int.Parse(((GridCell)(dgvMemoria.PrimaryGrid.GetCell(i, 6))).Value.ToString());
                        memoria.Modelo.NombreModelo = ((GridCell)(dgvMemoria.PrimaryGrid.GetCell(i, 1))).Value.ToString();
                        laptop.Memorias.Add(memoria);
                        flag = true;
                    }
                }
            }


            filas = tablaDisco.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvDiscoDuro.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvDiscoDuro.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        disco = new DiscoDuro();
                        disco.IdDisco = int.Parse(((GridCell)(dgvDiscoDuro.PrimaryGrid.GetCell(i, 5))).Value.ToString());
                        disco.IdTipo = int.Parse(((GridCell)(dgvDiscoDuro.PrimaryGrid.GetCell(i, 6))).Value.ToString());
                        disco.TipoDisco = ((GridCell)(dgvDiscoDuro.PrimaryGrid.GetCell(i, 1))).Value.ToString();
                        laptop.Discos.Add(disco);
                        flag = true;
                    }
                }
            }


            filas = tablaLicencia.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        licencia = new Licencia();
                        licencia.IdCategoria = int.Parse(((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 4))).Value.ToString());
                        licencia.Categoria = ((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 1))).Value.ToString();
                        laptop.Licencias.Add(licencia);
                        flag = true;
                    }
                }
            }

            return flag;
        }

        public bool validarDatos()
        {
            bool flag = true;

            tabControl1.SelectedTab = tabProcesador;
            tabControl1.SelectedTab = tabMemoria;
            tabControl1.SelectedTab = tabVideo;
            tabControl1.SelectedTab = tabDiscoDuro;
            tabControl1.SelectedTab = tabLicencia;
            tabControl1.SelectedTab = tabDetalle;

            //==============================================================================================
            int filas = tablaVideo.Rows.Count;
            int cantVideos = 0;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvVideo.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvVideo.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        cantVideos++;
                    }
                }
            }
            if (cantVideos > 1)
            {
                MessageBox.Show("Solo seleccione una tarjeta de video");
                return false;
            }
            else if (cantVideos == 0)
            {
                MessageBox.Show("Debe seleccionar una tarjeta de video");
                return false;
            }

            //==============================================================================================
            filas = tablaProcesador.Rows.Count;
            int cantProcesadores = 0;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvProcesador.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvProcesador.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        cantProcesadores++;
                    }
                }
            }
            if (cantProcesadores > 1)
            {
                MessageBox.Show("Solo seleccione un procesador");
                return false;
            }
            else if (cantProcesadores == 0)
            {
                MessageBox.Show("Debe seleccionar un procesador");
                return false;
            }

            //==============================================================================================
            filas = tablaDisco.Rows.Count;
            int cantDiscos = 0;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvDiscoDuro.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvDiscoDuro.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        cantDiscos++;
                    }
                }
            }
            if (cantDiscos > 2)
            {
                MessageBox.Show("Solo puede seleccionar 2 discos");
                return false;
            }
            else if (cantDiscos == 0)
            {
                MessageBox.Show("Debe seleccionar almenos un disco duro");
                return false;
            }

            //==============================================================================================
            filas = tablaMemoria.Rows.Count;
            int cantMemorias = 0;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvMemoria.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvMemoria.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        cantMemorias++;
                    }
                }
            }
            if (cantMemorias > 4)
            {
                MessageBox.Show("Solo puede seleccionar 4 memorias");
                return false;
            }
            else if (cantMemorias == 0)
            {
                MessageBox.Show("Debe seleccionar almenos una memoria");
                return false;
            }


            //==============================================================================================
            filas = tablaLicencia.Rows.Count;
            int cantWindows = 0;
            int cantOffice = 0;
            int cantAntivirus = 0;
            for (int i = 0; i < filas; i++)
            {
                if (((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    if (Convert.ToBoolean(((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 0))).Value.ToString()) == true)
                    {
                        if (((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 1))).Value.ToString() == "WINDOWS")
                        {
                            cantWindows++;
                        }
                        else if (((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 1))).Value.ToString() == "OFFICE")
                        {
                            cantOffice++;
                        }
                        else if (((GridCell)(dgvLicencia.PrimaryGrid.GetCell(i, 1))).Value.ToString() == "ANTIVIRUS")
                        {
                            cantAntivirus++;
                        }
                    }
                }
            }
            if (cantWindows > 1)
            {
                MessageBox.Show("Solo puede seleccionar una licencia windows");
                return false;
            }
            
            if (cantOffice > 1)
            {
                MessageBox.Show("Solo puede seleccionar una licencia office");
                return false;
            }

            if (cantAntivirus > 1)
            {
                MessageBox.Show("Solo puede seleccionar una licencia de Antivirus");
                return false;
            }

            
            //==============================================================================================
            string partNumber = txtPartNumber.Text;
            partNumber = partNumber.Trim();
            if (!(partNumber.Length > 0))
            {
                MessageBox.Show("Ingrese un part number");
                return false;
            }

            //==============================================================================================
            string pantalla = txtPantalla.Text;
            pantalla = pantalla.Trim();
            if (!(pantalla.Length > 0))
            {
                MessageBox.Show("Ingrese un tamaño de pantalla válida");
                return false;
            }

            //==============================================================================================
            string precio = txtPrecio.Text;
            precio = precio.Trim();
            if (!(precio.Length > 0))
            {
                MessageBox.Show("Ingrese un precio válido");
                return false;
            }
            //==============================================================================================

            for (int i = 0; i < dgvSerieFabrica.Rows.Count; i++)
            {
                if (dgvSerieFabrica.Rows[i].Cells[1].Value == null)
                {
                    if (!dgvSerieFabrica.Rows[i].IsNewRow)
                    {
                        dgvSerieFabrica.Rows.Remove(dgvSerieFabrica.Rows[i]);
                        i = -1;
                    }
                }
            }
            int aux = int.Parse(txtCantidad.Text);
            int filasDgv = dgvSerieFabrica.Rows.Count - 1;
            
            if (filasDgv < aux)
            {
                MessageBox.Show("Falta ingresar " + (aux - filasDgv) + " filas");
                return false;
            }
            else if (filasDgv > aux)
            {
                MessageBox.Show("Hay " + (filasDgv - aux) + " filas de más");
                return false;
            }
            //==============================================================================================
            return true;
        }

        public IngresoDetalle DETALLE { get => detalle; set => detalle = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            // 'Comprobar que tenga filas
            if (validarDatos())
            {
                if (llenarListaLaptops())//Si entra es porque se ha seleccionado almenos solo
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            //string aux = txtCantidad.Text;
            //aux = aux.Trim();
            //if (aux.Length > 0)
            //{
            //    int cantidad = int.Parse(txtCantidad.Text);
            //    int cantFilas = dgvSerieFabrica.RowCount;
            //    if (cantFilas < cantidad)
            //    {
            //        for (int i = cantFilas; i < cantidad; i++)
            //        {
            //            DataGridViewRow row = (DataGridViewRow)dgvSerieFabrica.Rows[0].Clone();
            //            row.Cells[0].Value = i++;
            //            dgvSerieFabrica.Rows.Add(row);
            //        }
            //    }
            //    else
            //    {

            //    }

            //}
            string myStr = txtCantidad.Text;
            myStr = myStr.TrimStart('0');
            txtCantidad.Text = myStr.Length > 0 ? myStr : "1";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgvSerieFabrica_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvSerieFabrica.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvSerieFabrica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
       {
            if (dgvSerieFabrica.CurrentRow == null)
                return;

            dgvSerieFabrica.Rows.Remove(dgvSerieFabrica.CurrentRow);
        }
    }
}
