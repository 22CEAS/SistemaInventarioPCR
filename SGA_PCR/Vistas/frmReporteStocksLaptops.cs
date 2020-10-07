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
                laptop.NombreModeloVideo = tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString().Length>0? tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString():"";
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
                        laptop.Disco2 = "";
                        laptop.CapacidadDisco2 ="";
                    }
                    else if (laptop.Discos.Count >= 2)
                    {
                        laptop.Disco1 = laptop.Discos[0].TipoDisco;
                        laptop.CapacidadDisco1 = (laptop.Discos[0].Cantidad * laptop.Discos[0].Capacidad).ToString() + " GB";

                        laptop.Disco2 = laptop.Discos[1].TipoDisco;
                        laptop.CapacidadDisco2 = (laptop.Discos[1].Cantidad * laptop.Discos[1].Capacidad).ToString()+ " GB";
                    }
                }
                else if (laptop.Discos.Count == 0)
                {
                    laptop.Disco1 = "";
                    laptop.CapacidadDisco1 = "";
                    laptop.Disco2 = "";
                    laptop.CapacidadDisco2 = "";
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

        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que desea Exportar el reporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    SaveFileDialog fichero = new SaveFileDialog();
                    //fichero.Filter = "Excel (*.xls)|*.xls";
                    fichero.Filter = "Excel(*.xlsx) | *.xlsx";
                    fichero.FileName = "Laptops";
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application aplicacion;
                        Excel.Workbook libros_trabajo;
                        Excel.Worksheet hoja_pre_alquiler;

                        aplicacion = new Excel.Application();
                        libros_trabajo = (Excel.Workbook)aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

                        hoja_pre_alquiler = (Excel.Worksheet)libros_trabajo.Worksheets.Add();
                        hoja_pre_alquiler.Name = "Laptops";
                        string cabecera = "Reporte de Laptops";
                        ExportarDataGridViewExcel(ref hoja_pre_alquiler, cabecera);


                        ((Excel.Worksheet)aplicacion.ActiveWorkbook.Sheets["Hoja1"]).Delete();

                        //libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                        libros_trabajo.SaveAs(fichero.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
                        libros_trabajo.Close(true);
                        releaseObject(libros_trabajo);
                        aplicacion.Quit();
                        releaseObject(aplicacion);
                        MessageBox.Show("Se generó el reporte con éxito", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString(), "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public void ExportarDataGridViewExcel(ref Excel.Worksheet hoja_trabajo, string nombreCabecera)
        {
            Excel.Range rango;

            //Recorremos el DataGridView rellenando la hoja de trabajo
            int filas = tablaLaptops.Rows.Count;
            for (int j = 0; j < filas; j++)
            {
                int k = vista.Columns.Count + 64;
                char columF = (char)k;
                int fila2 = j + 4;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Style.Font.Bold = false;

                hoja_trabajo.Cells[fila2, 1] = vista.GetRowCellValue(j, "Codigo").ToString();
                hoja_trabajo.Cells[fila2, 2] = vista.GetRowCellValue(j, "MarcaLC").ToString();
                hoja_trabajo.Cells[fila2, 3] = vista.GetRowCellValue(j, "NombreModeloLC").ToString();
                hoja_trabajo.Cells[fila2, 4] = vista.GetRowCellValue(j, "TipoProcesador").ToString();
                hoja_trabajo.Cells[fila2, 5] = vista.GetRowCellValue(j, "NombreModeloVideo").ToString();
                hoja_trabajo.Cells[fila2, 6] = vista.GetRowCellValue(j, "CapacidadVideo").ToString();
                hoja_trabajo.Cells[fila2, 7] = vista.GetRowCellValue(j, "Disco1").ToString();
                hoja_trabajo.Cells[fila2, 8] = vista.GetRowCellValue(j, "CapacidadDisco1").ToString();
                hoja_trabajo.Cells[fila2, 9] = vista.GetRowCellValue(j, "Disco2").ToString();
                hoja_trabajo.Cells[fila2, 10] = vista.GetRowCellValue(j, "CapacidadDisco2").ToString();
                hoja_trabajo.Cells[fila2, 11] = vista.GetRowCellValue(j, "CapacidadMemoria").ToString();
                hoja_trabajo.Cells[fila2, 12] = vista.GetRowCellValue(j, "EstadoNombre").ToString();
                hoja_trabajo.Cells[fila2, 13] = vista.GetRowCellValue(j, "Cliente").ToString();
                hoja_trabajo.Cells[fila2, 14] = vista.GetRowCellValue(j, "Ubicacion").ToString();
                hoja_trabajo.Cells[fila2, 15] = vista.GetRowCellValue(j, "SerieFabrica").ToString();


            }
            montaCabeceras(1, ref hoja_trabajo, nombreCabecera);
        }

        private void montaCabeceras(int fila, ref Excel.Worksheet hoja, string nombreCabecera)
        {
            try
            {
                Excel.Range rango;

                //** Montamos el título en la línea 1 **
                hoja.Cells[fila, 1] = nombreCabecera;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, vista.Columns.Count]].Merge();
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, vista.Columns.Count]].Interior.Color = Color.Silver;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, vista.Columns.Count]].Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //worksheet.Range[worksheet.Cells[rowNum, columnNum], worksheet.Cells[rowNum, columnNum]].Merge();

                hoja.Cells[fila + 2, 1] = "Codigo";
                hoja.Cells[fila + 2, 2] = "Marca LC";
                hoja.Cells[fila + 2, 3] = "Nombre Modelo LC";
                hoja.Cells[fila + 2, 4] = "Tipo Procesador";
                hoja.Cells[fila + 2, 5] = "Nombre Modelo Video";
                hoja.Cells[fila + 2, 6] = "Capacidad Video";
                hoja.Cells[fila + 2, 7] = "Disco1";
                hoja.Cells[fila + 2, 8] = "Capacidad Disco1";
                hoja.Cells[fila + 2, 9] = "Disco2";
                hoja.Cells[fila + 2, 10] = "Capacidad Disco2";
                hoja.Cells[fila + 2, 11] = "Capacidad Memoria";
                hoja.Cells[fila + 2, 12] = "Estado Nombre";
                hoja.Cells[fila + 2, 13] = "Cliente";
                hoja.Cells[fila + 2, 14] = "Ubicacion";
                hoja.Cells[fila + 2, 15] = "SerieFabrica";


                int i = vista.Columns.Count + 64;
                char columF = (char)i;
                int fila2 = fila + 2;
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

                for (int j = 0; j < vista.Columns.Count; j++)
                {
                    rango = hoja.Columns[j + 1];
                    rango.ColumnWidth = 25;
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
                MessageBox.Show("Error mientras liberaba objecto " + ex.ToString(), "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
