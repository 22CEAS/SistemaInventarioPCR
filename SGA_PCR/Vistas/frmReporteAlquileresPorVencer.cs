﻿using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraPrinting;
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
    public partial class frmReporteAlquileresPorVencer : Form
    {

        DataTable tablaLaptops;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmReporteAlquileresPorVencer()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteAlquileresPorVencer(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            Inicializado();
        }

        public void Inicializado()
        {

            //
        }

        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            // Create a new row.
            CellObject row = new CellObject();
            XlFormattingObject rowFormatting = new XlFormattingObject();
            // Specify row values.
            row.Value = "LAPTOPS POR VENCER";
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 14 };
            rowFormatting.BackColor = Color.Orange;
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row });
            // Add an empty row to the output document.
            e.ExportContext.AddRow();
            // Merge cells of two new rows. 
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(11, 1)));
        }



        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que desea Exportar el reporte", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DevExpress.Export.ExportSettings.DefaultExportType = ExportType.DataAware;
                    XlsxExportOptionsEx options = new XlsxExportOptionsEx();
                    options.CustomizeSheetHeader += options_CustomizeSheetHeader;
                    //options.CustomizeCell += op_CustomizeCell;
                    string file = "LAPTOPS POR VENCER.xlsx";
                    dgvLaptops.ExportToXlsx(file, options);
                    System.Diagnostics.Process.Start(file);
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

                hoja_trabajo.Cells[fila2, 1] = vista.GetRowCellValue(j, "Cliente").ToString();
                hoja_trabajo.Cells[fila2, 2] = vista.GetRowCellValue(j, "Contacto").ToString();
                hoja_trabajo.Cells[fila2, 3] = vista.GetRowCellValue(j, "DireccionCliente").ToString();
                hoja_trabajo.Cells[fila2, 4] = vista.GetRowCellValue(j, "Codigo").ToString();
                hoja_trabajo.Cells[fila2, 5] = vista.GetRowCellValue(j, "GuiaSalida").ToString();
                hoja_trabajo.Cells[fila2, 6] = vista.GetRowCellValue(j, "MarcaLC").ToString();
                hoja_trabajo.Cells[fila2, 7] = vista.GetRowCellValue(j, "NombreModeloLC").ToString();
                hoja_trabajo.Cells[fila2, 8] = vista.GetRowCellValue(j, "TamanoPantalla").ToString();
                hoja_trabajo.Cells[fila2, 9] = vista.GetRowCellValue(j, "TipoProcesador").ToString();
                hoja_trabajo.Cells[fila2, 10] = vista.GetRowCellValue(j, "GeneracionProcesador").ToString();
                hoja_trabajo.Cells[fila2, 11] = vista.GetRowCellValue(j, "NombreModeloVideo").ToString();
                hoja_trabajo.Cells[fila2, 12] = vista.GetRowCellValue(j, "CapacidadVideo").ToString();
                hoja_trabajo.Cells[fila2, 13] = vista.GetRowCellValue(j, "CodigoAntiguo").ToString();

                if (vista.GetRowCellValue(j, "fecIniContrato").ToString().Length > 0)
                {
                    DateTime aux2 = DateTime.Parse(vista.GetRowCellValue(j, "fecIniContrato").ToString());
                    hoja_trabajo.Cells[fila2, 14] = aux2.ToString("yyyy/MM/dd");
                }
                else hoja_trabajo.Cells[fila2, 14] = "";

                if (vista.GetRowCellValue(j, "fecFinContrato").ToString().Length > 0)
                {
                    DateTime aux2 = DateTime.Parse(vista.GetRowCellValue(j, "fecFinContrato").ToString());
                    hoja_trabajo.Cells[fila2, 15] = aux2.ToString("yyyy/MM/dd");
                }
                else hoja_trabajo.Cells[fila2, 15] = "";

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
                hoja.Cells[fila + 2, 2] = "Contacto";
                hoja.Cells[fila + 2, 3] = "Direccion Cliente";
                hoja.Cells[fila + 2, 4] = "Código LC";
                hoja.Cells[fila + 2, 5] = "Guía";
                hoja.Cells[fila + 2, 6] = "Marca LC";
                hoja.Cells[fila + 2, 7] = "Nombre Modelo LC";
                hoja.Cells[fila + 2, 8] = "Tamano Pantalla";
                hoja.Cells[fila + 2, 9] = "Tipo Procesador";
                hoja.Cells[fila + 2, 10] = "Generacion Procesador";
                hoja.Cells[fila + 2, 11] = "Nombre Modelo Video";
                hoja.Cells[fila + 2, 12] = "Capacidad Video";
                hoja.Cells[fila + 2, 13] = "Código Antiguo";
                hoja.Cells[fila + 2, 14] = "Fecha Inicio Contrato";
                hoja.Cells[fila + 2, 15] = "Fecha Fin Contrato";


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

        private void verResumen_Click(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
        }

        private async void cargarData_Click(object sender, EventArgs e)
        {
            label1.Text = $"CANTIDAD REGISTRO: 0";
            Task<bool> task = new Task<bool>(cargarDataTabla);
            task.Start();
            giftCarga.Image = Image.FromFile(@"C:\Users\USUARIO\Documents\GitHub\SistemaInventarioPCR\SGA_PCR\Imagenes\progress.gif");
            giftCarga.SizeMode = PictureBoxSizeMode.StretchImage;
            bool resultado = await task;
            giftCarga.Enabled = false;
            giftCarga.Visible = false;
            cargarData.Text = "DATA CARGADA";
            label1.Text = $"CANTIDAD REGISTRO: {vista.RowCount.ToString()}";
            cargarData.Visible = false;
        }

        public bool cargarDataTabla()
        {
            try
            {
                reporteDA = new ReporteDA();
                tablaLaptops = reporteDA.ListarLaptopsPorVencer();

                dgvLaptops.DataSource = tablaLaptops;
                vista.OptionsBehavior.AutoPopulateColumns = false;
                vista.OptionsSelection.MultiSelect = true;


            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message); OMITIMOS EL MENSAJE
            }

            return true;
        }

        private void frmReporteAlquileresPorVencer_Load(object sender, EventArgs e)
        {
            cargarData.PerformClick();
        }
    }
}