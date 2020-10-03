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
    public partial class frmReporteStocksLaptops : Form
    {

        DataTable tablaLaptops;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";
        DataTable tablaDisco;
        DataTable tablaMemoria;
        DataTable tablaLicencia;

        public frmReporteStocksLaptops()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteStocksLaptops(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {

            reporteDA = new ReporteDA();
            tablaLaptops = reporteDA.ListarLaptopsInventario();

            BindingList<LC> laptops = new BindingList<LC>();
            int rec = 0;
            while (rec < tablaLaptops.Rows.Count)
            {
                LC laptop = new LC();
                laptop.IdLC = Convert.ToInt32(tablaLaptops.Rows[rec]["idLC"].ToString());
                laptop.Codigo = tablaLaptops.Rows[rec]["codigo"].ToString();
                laptop.MarcaLC = tablaLaptops.Rows[rec]["marcaLC"].ToString();
                laptop.NombreModeloLC = tablaLaptops.Rows[rec]["nombreModeloLC"].ToString();
                laptop.TipoProcesador = tablaLaptops.Rows[rec]["tipoProcesador"].ToString();
                laptop.NombreModeloVideo = tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString();
                laptop.CapacidadVideo = Convert.ToInt32(tablaLaptops.Rows[rec]["capacidadVideo"].ToString());
                laptop.EstadoNombre = tablaLaptops.Rows[rec]["estado"].ToString();
                laptop.Cliente = tablaLaptops.Rows[rec]["cliente"].ToString();
                laptop.Ubicacion = tablaLaptops.Rows[rec]["ubicacion"].ToString();
                laptop.SerieFabrica = tablaLaptops.Rows[rec]["serieFabrica"].ToString();
                tablaDisco = reporteDA.ListarLaptopDisco(laptop.IdLC);
                tablaMemoria = reporteDA.ListarLaptopMemoria(laptop.IdLC);
                tablaLicencia = reporteDA.ListarLaptopLicencia(laptop.IdLC);
                laptop.SetDisco(tablaDisco);
                laptop.SetMemoria(tablaMemoria);
                laptop.SetLicencia(tablaLicencia);


                string tipoDisco1 = ""; int capDisco1 = 0; string tipoDisco2 = ""; int capDisco2 = 0;
                if (laptop.Discos.Count > 0)
                {
                    if (laptop.Discos.Count == 1)
                    {
                        laptop.Disco1 = laptop.Discos[0].TipoDisco;
                        laptop.CapacidadDisco1 = (laptop.Discos[0].Cantidad * laptop.Discos[0].Capacidad).ToString() + " GB";
                    }
                    else if (laptop.Discos.Count >= 2)
                    {
                        laptop.Disco1 = laptop.Discos[0].TipoDisco;
                        laptop.CapacidadDisco1 = (laptop.Discos[0].Cantidad * laptop.Discos[0].Capacidad).ToString() + " GB";

                        laptop.Disco2 = laptop.Discos[1].TipoDisco;
                        laptop.CapacidadDisco2 = (laptop.Discos[1].Cantidad * laptop.Discos[1].Capacidad).ToString()+ " GB";
                    }
                }

                
                int capacidadMem = 0;
                foreach (Memoria mem in laptop.Memorias)
                {
                    capacidadMem += mem.Capacidad * mem.Cantidad;
                }
                laptop.CapacidadMemoria = capacidadMem.ToString() + " GB";

                Licencia windows = null; Licencia office = null; Licencia antivirus = null;

                if (laptop.Licencias.Count > 0)
                {
                    windows = laptop.Licencias.SingleOrDefault(p => p.Categoria == "WINDOWS");
                    office = laptop.Licencias.SingleOrDefault(p => p.Categoria == "OFFICE");
                    antivirus = laptop.Licencias.SingleOrDefault(p => p.Categoria == "ANTIVIRUS");

                }

                laptop.LicenciaWindows = (windows != null) ? windows.Version : "";
                laptop.LicenciaOffice = (office != null) ? office.Version : "";
                laptop.LicenciaAntivirus = (antivirus != null) ? antivirus.Version : "";

                laptop.Licencias = null;
                laptop.Discos = null;
                laptop.Memorias = null;

                laptops.Add(laptop);
                rec++;
            }


            dgvLaptops.DataSource = laptops;
            vista.OptionsBehavior.AutoPopulateColumns = false;
            vista.OptionsSelection.MultiSelect = true;
        }
    }
}
