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
    public partial class frmAgregarProducto : Form
    {
        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular }
        DataTable tablaLaptops;
        LC laptop;
        BindingList<LC> laptops;
        AlquilerDA alquilerDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";


        public frmAgregarProducto()
        {
            InitializeComponent();
            Inicializado();
            //estadoComponentes(TipoVista.Inicial);
        }

        public frmAgregarProducto(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
            //estadoComponentes(TipoVista.Inicial);
        }

        public void Inicializado()
        {

            alquilerDA = new AlquilerDA();
            //laptop = new LC();
            laptops = new BindingList<LC>();
            tablaLaptops = alquilerDA.ListarLaptopsAlmacenSinMemoriaDisco();

            dgvLaptops.PrimaryGrid.AutoGenerateColumns = false;
            dgvLaptops.PrimaryGrid.DataSource = tablaLaptops; ;
        }

        public bool llenarListaLaptops()
        {
            bool flag = false;
            int filas = tablaLaptops.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if(((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 0))).Value != null)
                {
                    laptop = new LC();
                    laptop.IdLC= int.Parse(((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 9))).Value.ToString());
                    laptop.Codigo = ((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 1))).Value.ToString();
                    laptop.Modelo.NombreMarca = ((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 2))).Value.ToString();
                    laptop.Modelo.NombreModelo = ((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 3))).Value.ToString();
                    laptop.TamanoPantalla = Double.Parse(((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 4))).Value.ToString());
                    laptop.Procesador.Modelo.NombreModelo = ((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 5))).Value.ToString();
                    laptop.Procesador.Generacion = int.Parse(((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 6))).Value.ToString());
                    laptop.Video.Modelo.NombreModelo = ((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 7))).Value.ToString();
                    laptop.Video.Capacidad = int.Parse(((GridCell)(dgvLaptops.PrimaryGrid.GetCell(i, 8))).Value.ToString());
                    laptops.Add(laptop);
                    flag = true;
                }
            }
            return flag;
        }
        public BindingList<LC> LAPTOPS { get => laptops; set => laptops = value; }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (llenarListaLaptops())//Si entra es porque se ha seleccionado almenos solo
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
