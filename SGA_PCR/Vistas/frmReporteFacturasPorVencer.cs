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

namespace Apolo
{
    public partial class frmReporteFacturasPorVencer : Form
    {

        DataTable tablaLaptops;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmReporteFacturasPorVencer()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteFacturasPorVencer(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {

            reporteDA = new ReporteDA();
            tablaLaptops = reporteDA.ListarLaptopsFacturasPorVencer();

            dgvFacturas.DataSource = tablaLaptops;
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
                    fichero.FileName = "FacturasPorVencer";
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application aplicacion;
                        Excel.Workbook libros_trabajo;
                        Excel.Worksheet hoja_pre_alquiler;

                        aplicacion = new Excel.Application();
                        libros_trabajo = (Excel.Workbook)aplicacion.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

                        hoja_pre_alquiler = (Excel.Worksheet)libros_trabajo.Worksheets.Add();
                        hoja_pre_alquiler.Name = "FacturasPorVencer";
                        string cabecera = "Reporte de Facturas Por Vencer";
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
            //int filas = tablaLaptops.Rows.Count;
            int filas = vista.RowCount;
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

                hoja_trabajo.Cells[fila2, 1] = vista.GetRowCellValue(j, "cliente").ToString();

                if (vista.GetRowCellValue(j, "fecIniPlazoAlquiler").ToString().Length > 0)
                {
                    DateTime aux2 = DateTime.Parse(vista.GetRowCellValue(j, "fecIniPlazoAlquiler").ToString());
                    hoja_trabajo.Cells[fila2, 2] = aux2.ToString("yyyy/MM/dd");
                }
                else hoja_trabajo.Cells[fila2, 2] = "";

                if (vista.GetRowCellValue(j, "fecFinPlazoAlquiler").ToString().Length > 0)
                {
                    DateTime aux2 = DateTime.Parse(vista.GetRowCellValue(j, "fecFinPlazoAlquiler").ToString());
                    hoja_trabajo.Cells[fila2, 3] = aux2.ToString("yyyy/MM/dd");
                }
                else hoja_trabajo.Cells[fila2, 3] = "";

                hoja_trabajo.Cells[fila2, 4] = vista.GetRowCellValue(j, "factura").ToString();


                if (vista.GetRowCellValue(j, "fecInicioFactura").ToString().Length > 0)
                {
                    DateTime aux2 = DateTime.Parse(vista.GetRowCellValue(j, "fecInicioFactura").ToString());
                    hoja_trabajo.Cells[fila2, 5] = aux2.ToString("yyyy/MM/dd");
                }
                else hoja_trabajo.Cells[fila2, 5] = "";

                if (vista.GetRowCellValue(j, "fecFinFactura").ToString().Length > 0)
                {
                    DateTime aux2 = DateTime.Parse(vista.GetRowCellValue(j, "fecFinFactura").ToString());
                    hoja_trabajo.Cells[fila2, 6] = aux2.ToString("yyyy/MM/dd");
                }
                else hoja_trabajo.Cells[fila2, 6] = "";

                hoja_trabajo.Cells[fila2, 7] = vista.GetRowCellValue(j, "codigoEquipo").ToString();
                hoja_trabajo.Cells[fila2, 8] = vista.GetRowCellValue(j, "guia").ToString();
                hoja_trabajo.Cells[fila2, 9] = vista.GetRowCellValue(j, "CodigoAntiguo").ToString();
                hoja_trabajo.Cells[fila2, 10] = vista.GetRowCellValue(j, "GuiaAntigua").ToString();
                hoja_trabajo.Cells[fila2, 11] = vista.GetRowCellValue(j, "diasAntesVencer").ToString();
                hoja_trabajo.Cells[fila2, 12] = vista.GetRowCellValue(j, "KAM").ToString();

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
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, vista.Columns.Count]].Interior.Color = Color.Orange;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, vista.Columns.Count]].Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //worksheet.Range[worksheet.Cells[rowNum, columnNum], worksheet.Cells[rowNum, columnNum]].Merge();

                hoja.Cells[fila + 2, 1] = "Cliente";
                hoja.Cells[fila + 2, 2] = "Fecha Inicio Contrato";
                hoja.Cells[fila + 2, 3] = "Fecha Fin Contrato";
                hoja.Cells[fila + 2, 4] = "Factura";
                hoja.Cells[fila + 2, 5] = "Fecha Inicio Factura";
                hoja.Cells[fila + 2, 6] = "Fecha Fin Factura";
                hoja.Cells[fila + 2, 7] = "Código LC";
                hoja.Cells[fila + 2, 8] = "Guía";
                hoja.Cells[fila + 2, 9] = "Código Antiguo";
                hoja.Cells[fila + 2, 10] = "Guía Antiguo";
                hoja.Cells[fila + 2, 11] = "Días Antes Vencer";
                hoja.Cells[fila + 2, 12] = "KAM";


                int i = vista.Columns.Count + 64;
                char columF = (char)i;
                int fila2 = fila + 2;
                string filaBorde = fila2.ToString();
                char columI = 'A';
                //Ponemos borde a las celdas
                rango = hoja.Range[columI + fila2.ToString(), columF + fila2.ToString()];
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.Interior.Color = Color.Orange;
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

