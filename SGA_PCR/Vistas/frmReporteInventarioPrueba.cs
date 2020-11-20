﻿using AccesoDatos;
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
    public partial class frmReporteInventarioPrueba : Form
    {

        DataTable tablaLaptops;
        DataTable tablaLaptops2;
        ReporteDA reporteDA;
        private int idUsuario;
        private string nombreUsuario = "CEAS";
        DataTable tablaDisco;
        DataTable tablaMemoria;
        DataTable tablaLicencia;

        DataTable tablaProcesadoresModelos;
        DataTable tablaProcesadoresGeneracion;

        private string licenciaCategoriaSO = "S.O";
        private string licenciaCategoriaOffice = "OFFICE";
        private string licenciaCategoriaAntivirus = "ANTIVIRUS";

        private int idMarcaAppleLC = 1;
        private int idMarcaApplePC = 8;
        private int idCategoriaProcesador = 9;
        private string codTablaProcesadorGeneracion = "PROCESADOR_GENERACION";
        int cantGeneraciones;
        int cantModeloProcesador;
        int[][] arregloLCGeneral;
        int[][] arregloLCApple;

        private int idTipoCore3 = 168;
        private int idTipoCore5 = 169;
        private int idTipoCore7 = 170;
        private int idTipoCore9 = 171;
        private int idTipoXeon = 172;

        public frmReporteInventarioPrueba()
        {
            InitializeComponent();
            Inicializado();
        }

        public frmReporteInventarioPrueba(int idUsuario, string nombreUsuario)
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
            tablaProcesadoresModelos = reporteDA.tablaProcesadoresModelos(idCategoriaProcesador);
            tablaProcesadoresGeneracion = reporteDA.tablaProcesadoresGeneracion(codTablaProcesadorGeneracion);

            BindingList<LC> laptops = new BindingList<LC>();
            tablaDisco = reporteDA.ListarLaptopDisco();
            tablaMemoria = reporteDA.ListarLaptopMemoria();
            tablaLicencia = reporteDA.ListarLaptopLicencia();
            DataView viewDisco = new DataView(tablaDisco);
            DataView viewMemoria = new DataView(tablaMemoria);
            DataView viewLicencia = new DataView(tablaLicencia);
            int rec = 0;
            while (rec < tablaLaptops.Rows.Count)
            {
                LC laptop = new LC();
                laptop.IdLC = Convert.ToInt32(tablaLaptops.Rows[rec]["idLC"].ToString());
                laptop.Codigo = tablaLaptops.Rows[rec]["codigo"].ToString();
                laptop.IdMarca = int.Parse(tablaLaptops.Rows[rec]["idMarca"].ToString());
                laptop.MarcaLC = tablaLaptops.Rows[rec]["marcaLC"].ToString();
                laptop.NombreModeloLC = tablaLaptops.Rows[rec]["nombreModeloLC"].ToString();
                laptop.TipoProcesador = tablaLaptops.Rows[rec]["tipoProcesador"].ToString();
                laptop.IdGeneracionProcesador = int.Parse(tablaLaptops.Rows[rec]["idGeneracionProcesador"].ToString());
                laptop.GeneracionProcesador= int.Parse(tablaLaptops.Rows[rec]["generacionProcesador"].ToString());
                laptop.IdTipoProcesador = int.Parse(tablaLaptops.Rows[rec]["idTipoProcesador"].ToString());
                laptop.NombreModeloVideo = tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString().Length > 0 ? tablaLaptops.Rows[rec]["nombreModeloVideo"].ToString() : "";
                laptop.CapacidadVideo = Convert.ToInt32(tablaLaptops.Rows[rec]["capacidadVideo"].ToString());
                laptop.EstadoNombre = tablaLaptops.Rows[rec]["estado"].ToString();
                laptop.Cliente = tablaLaptops.Rows[rec]["cliente"].ToString();
                laptop.Ubicacion = tablaLaptops.Rows[rec]["ubicacion"].ToString();
                laptop.SerieFabrica = tablaLaptops.Rows[rec]["serieFabrica"].ToString();
                //tablaDisco = reporteDA.ListarLaptopDisco(laptop.IdLC);
                //tablaMemoria = reporteDA.ListarLaptopMemoria(laptop.IdLC);
                //tablaLicencia = reporteDA.ListarLaptopLicencia(laptop.IdLC);
                //laptop.SetDisco(tablaDisco);
                //laptop.SetMemoria(tablaMemoria);
                //laptop.SetLicencia(tablaLicencia);
                viewDisco.RowFilter = "idLC = " + laptop.IdLC.ToString();
                viewMemoria.RowFilter = "idLC = " + laptop.IdLC.ToString();
                viewLicencia.RowFilter = "idLC = " + laptop.IdLC.ToString();
                laptop.SetDisco(viewDisco);
                laptop.SetMemoria(viewMemoria);
                laptop.SetLicencia(viewLicencia);

                string tipoDisco1 = ""; int capDisco1 = 0; string tipoDisco2 = ""; int capDisco2 = 0;
                if (laptop.Discos.Count > 0)
                {
                    if (laptop.Discos.Count == 1)
                    {
                        laptop.Disco1 = laptop.Discos[0].TipoDisco;
                        laptop.CapacidadDisco1 = (laptop.Discos[0].Cantidad * laptop.Discos[0].Capacidad).ToString() + " GB";
                        laptop.Disco2 = "";
                        laptop.CapacidadDisco2 = "";
                    }
                    else if (laptop.Discos.Count >= 2)
                    {
                        laptop.Disco1 = laptop.Discos[0].TipoDisco;
                        laptop.CapacidadDisco1 = (laptop.Discos[0].Cantidad * laptop.Discos[0].Capacidad).ToString() + " GB";

                        laptop.Disco2 = laptop.Discos[1].TipoDisco;
                        laptop.CapacidadDisco2 = (laptop.Discos[1].Cantidad * laptop.Discos[1].Capacidad).ToString() + " GB";
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
                    windows = laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaSO);
                    office = laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaOffice);
                    antivirus = laptop.Licencias.SingleOrDefault(p => p.Categoria == this.licenciaCategoriaAntivirus);

                }

                laptop.LicenciaWindows = (windows != null) ? windows.Version : "";
                laptop.LicenciaOffice = (office != null) ? office.Version : "";
                laptop.LicenciaAntivirus = (antivirus != null) ? antivirus.Version : "";

                laptop.Licencias = null;
                laptop.Discos = null;
                laptop.Memorias = null;

                laptop.IdSalida = tablaLaptops.Rows[rec]["idSalida"].ToString();

                laptops.Add(laptop);
                rec++;
            }
            this.cantGeneraciones = tablaProcesadoresGeneracion.Rows.Count;
            this.cantModeloProcesador = tablaProcesadoresModelos.Rows.Count;

            this.arregloLCGeneral = new int[cantGeneraciones][];
            this.arregloLCApple = new int[cantGeneraciones][];

            for (int i = 0; i < this.cantGeneraciones; i++)
            {
                this.arregloLCGeneral[i] = new int[this.cantModeloProcesador];
                this.arregloLCApple[i] = new int[this.cantModeloProcesador];
                for (int j = 0; j < this.cantModeloProcesador; j++)
                {
                    int idGen = int.Parse(tablaProcesadoresGeneracion.Rows[i]["idAuxiliar"].ToString());
                    int idModPro = int.Parse(tablaProcesadoresModelos.Rows[j]["idModelo"].ToString());
                    var cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca != this.idMarcaAppleLC && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC).ToList());
                    this.arregloLCGeneral[i][j] = cantidad.Count;
                    cantidad = new BindingList<LC>(laptops.Where(p => p.IdMarca == this.idMarcaAppleLC && p.IdGeneracionProcesador == idGen && p.IdTipoProcesador == idModPro && p.IdMarca != this.idMarcaApplePC).ToList());
                    this.arregloLCApple[i][j] = cantidad.Count;
                }
            }

            for (int i = 0; i < this.cantGeneraciones; i++)
            {
                for (int j = 0; j < this.cantModeloProcesador; j++)
                {
                    string generacion = tablaProcesadoresGeneracion.Rows[i]["descripcion"].ToString();
                    string nombreProcesador = tablaProcesadoresModelos.Rows[j]["nombre"].ToString();
                    int cant = arregloLCGeneral[i][j];
                    //MessageBox.Show("Procesador: " + nombreProcesador + "Generación: " + generacion + "Cantidad: " + cant.ToString());
                }
            }



            //var generacion2 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 2).ToList());
            //var generacion3 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 3).ToList());
            //var generacion4 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 4).ToList());
            //var generacion5 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 5).ToList());
            //var generacion6 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 6).ToList());
            //var generacion7 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 7).ToList());
            //var generacion8 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 8).ToList());
            //var generacion9 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 9).ToList());
            //var generacion10 = new BindingList<LC>(laptops.Where(p => p.GeneracionProcesador == 10).ToList());

            //DataView pruevaview = new DataView();
            //dgvLaptops.DataSource = laptops;
            //vista.OptionsBehavior.AutoPopulateColumns = false;
            //vista.OptionsSelection.MultiSelect = true;
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
                        string cabecera = "Equipos en Alquiler";
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
            int cantColumnas = tablaProcesadoresGeneracion.Rows.Count + 3;
            int filas = vista.RowCount;


            int k = cantColumnas + 64;
            char columF = (char)k;
            int fila2 = 3;
            string filaBorde = fila2.ToString();
            char columI = 'A';
            //Ponemos borde a las celdas
            rango = hoja_trabajo.Range[columI + fila2.ToString(), columF + fila2.ToString()];
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.Style.Font.Bold = false;



            for (int i = 0; i < this.cantGeneraciones; i++)
            {
                for (int j = 0; j < this.cantModeloProcesador; j++)
                {
                    string generacion = tablaProcesadoresGeneracion.Rows[i]["descripcion"].ToString();
                    string nombreProcesador = tablaProcesadoresModelos.Rows[j]["nombre"].ToString();
                    int cant = arregloLCGeneral[i][j];
                    //MessageBox.Show("Procesador: " + nombreProcesador + "Generación: " + generacion + "Cantidad: " + cant.ToString());
                    hoja_trabajo.Cells[fila2 + 1 + j, i + 2] = arregloLCGeneral[i][j];
                    cant = arregloLCApple[i][j];
                    //MessageBox.Show("Procesador: " + nombreProcesador + "Generación: " + generacion + "Cantidad: " + cant.ToString());
                    hoja_trabajo.Cells[fila2 + 1+ cantModeloProcesador + 1 + j, i + 2] = arregloLCApple[i][j];
                }
            }


            //hoja_trabajo.Cells[fila2, 1] = vista.GetRowCellValue(j, "Codigo").ToString();
            //hoja_trabajo.Cells[fila2, 2] = vista.GetRowCellValue(j, "MarcaLC").ToString();
            //hoja_trabajo.Cells[fila2, 3] = vista.GetRowCellValue(j, "NombreModeloLC").ToString();
            //hoja_trabajo.Cells[fila2, 4] = vista.GetRowCellValue(j, "TipoProcesador").ToString();
            //hoja_trabajo.Cells[fila2, 5] = vista.GetRowCellValue(j, "NombreModeloVideo").ToString();
            //hoja_trabajo.Cells[fila2, 6] = vista.GetRowCellValue(j, "CapacidadVideo").ToString();
            //hoja_trabajo.Cells[fila2, 7] = vista.GetRowCellValue(j, "Disco1").ToString();
            //hoja_trabajo.Cells[fila2, 8] = vista.GetRowCellValue(j, "CapacidadDisco1").ToString();
            //hoja_trabajo.Cells[fila2, 9] = vista.GetRowCellValue(j, "Disco2").ToString();
            //hoja_trabajo.Cells[fila2, 10] = vista.GetRowCellValue(j, "CapacidadDisco2").ToString();
            //hoja_trabajo.Cells[fila2, 11] = vista.GetRowCellValue(j, "CapacidadMemoria").ToString();
            //hoja_trabajo.Cells[fila2, 12] = vista.GetRowCellValue(j, "EstadoNombre").ToString();
            //hoja_trabajo.Cells[fila2, 13] = vista.GetRowCellValue(j, "Cliente").ToString();
            //hoja_trabajo.Cells[fila2, 14] = vista.GetRowCellValue(j, "Ubicacion").ToString();
            //hoja_trabajo.Cells[fila2, 15] = vista.GetRowCellValue(j, "SerieFabrica").ToString();
            //hoja_trabajo.Cells[fila2, 16] = vista.GetRowCellValue(j, "IdSalida").ToString();



            montaCabeceras(1, ref hoja_trabajo, nombreCabecera);
        }

        private void montaCabeceras(int fila, ref Excel.Worksheet hoja, string nombreCabecera)
        {
            try
            {
                Excel.Range rango;
                int cantColumnas = tablaProcesadoresGeneracion.Rows.Count + 3;

                //** Montamos el título en la línea 1 **
                hoja.Cells[fila, 1] = nombreCabecera;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Merge();
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Interior.Color = Color.Orange;
                hoja.Range[hoja.Cells[fila, 1], hoja.Cells[fila, cantColumnas]].Style.Font.Bold = true;
                //Centramos los textos
                rango = hoja.Rows[fila];
                rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //worksheet.Range[worksheet.Cells[rowNum, columnNum], worksheet.Cells[rowNum, columnNum]].Merge();


                for (int k = 0; k < cantGeneraciones; k++)
                {
                    string genPro = tablaProcesadoresGeneracion.Rows[k]["descripcion"].ToString();
                    hoja.Cells[fila + 1, k+2] = genPro;
                }

                hoja.Cells[fila + 1, cantGeneraciones + 2] = "Total en Almacen";
                hoja.Cells[fila + 1, cantGeneraciones + 3] = "Equipos Buenos";

                hoja.Cells[fila + 2, 1] = "LAPTOP";

                for (int k = 0; k < cantModeloProcesador; k++)
                {
                    string modPro = tablaProcesadoresModelos.Rows[k]["nombre"].ToString();
                    hoja.Cells[fila + 3 + k, 1] = modPro;
                }

                hoja.Cells[fila + 3 + cantModeloProcesador, 1] = "MACKBOOK";

                for (int k = 0; k < cantModeloProcesador; k++)
                {
                    string modPro = tablaProcesadoresModelos.Rows[k]["nombre"].ToString();
                    hoja.Cells[fila + 3 + cantModeloProcesador + 1 + k, 1] = modPro;
                }



                int i = cantColumnas + 64;
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

                for (int j = 0; j < cantColumnas+3; j++)
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
