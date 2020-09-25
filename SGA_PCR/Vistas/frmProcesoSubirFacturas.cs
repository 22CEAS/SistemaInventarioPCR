using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using AccesoDatos;

namespace Vistas
{
    public partial class frmProcesoSubirFacturas : Form
    {
        BindingList<Factura> facturas;
        FacturaDA facturaDA;
        DataTable cuadroVencimiento;

        private int idUsuario;
        private string nombreUsuario = "CEAS";

        public frmProcesoSubirFacturas()
        {
            InitializeComponent();
            Inicializado();
        }

        public void Inicializado()
        {
            dgvFacturas.PrimaryGrid.AutoGenerateColumns = false;
            facturas = new BindingList<Factura>();
            facturaDA = new FacturaDA();
        }

        private void btnSubirFactura_Click(object sender, EventArgs e)
        {
            try
            {
                string path;

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //DE ESTA MANERA FILTRAMOS TODOS LOS ARCHIVOS EXCEL EN EL NAVEGADOR DE ARCHIVOS
                    Filter = "Excel | *.xls;*.xlsx;",

                    //AQUÍ INDICAMOS QUE NOMBRE TENDRÁ EL NAVEGADOR DE ARCHIVOS COMO TITULO
                    Title = "Seleccionar Archivo"
                };

                //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    facturas = new BindingList<Factura>();

                    path = openFileDialog.FileName;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        Factura fact = new Factura();
                        fact.FechaPago = sl.GetCellValueAsDateTime(iRow, 1);
                        fact.TipoPago = sl.GetCellValueAsString(iRow, 2);
                        fact.CodigoLC = sl.GetCellValueAsString(iRow, 3);
                        fact.FechaIniPago = sl.GetCellValueAsDateTime(iRow, 4);
                        fact.FechaFinPago = sl.GetCellValueAsDateTime(iRow, 5);
                        fact.RucDni = sl.GetCellValueAsString(iRow, 6);
                        fact.RazonSocial = sl.GetCellValueAsString(iRow, 7);
                        fact.NumeroOC = sl.GetCellValueAsString(iRow, 8);
                        fact.NumeroDocRef = sl.GetCellValueAsString(iRow, 9);
                        fact.NumeroFactura = sl.GetCellValueAsString(iRow, 10);
                        fact.TotalSoles = sl.GetCellValueAsDouble(iRow, 11);
                        fact.TotalDolares = sl.GetCellValueAsDouble(iRow, 12);
                        fact.TipoCambio = sl.GetCellValueAsDouble(iRow, 13);
                        fact.VentaSoles = sl.GetCellValueAsDouble(iRow, 14);
                        fact.CostoSoles = sl.GetCellValueAsDouble(iRow, 15);
                        fact.CostoDolares = sl.GetCellValueAsDouble(iRow, 16);
                        fact.CostoTotalSolesSinIGV = sl.GetCellValueAsDouble(iRow, 17);
                        fact.UtilidadSoles = sl.GetCellValueAsDouble(iRow, 18);
                        fact.UtilidadDolares = sl.GetCellValueAsDouble(iRow, 19);
                        fact.UtilidadTotalSolesSinIGV = sl.GetCellValueAsDouble(iRow, 20);

                        facturas.Add(fact);
                        iRow++;
                    }
                    dgvFacturas.PrimaryGrid.DataSource = facturas;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (facturas.Count > 0)
            {
                if (MessageBox.Show("Estas seguro que desea Guardar las facturas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //facturaDA.InsertarFacturas(facturas, this.nombreUsuario);
                    Validar(2);
                    MessageBox.Show("Se guardó las listas de facturas", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
            }
        }

        private void Validar(int flag)
        {
            cuadroVencimiento = facturaDA.ListarCV();
            foreach (Factura f in facturas)
            {
                String concatCodActCV = "", concatCodAntCV = "", facturaCV = "", guiaSalidaCV = ""; 
                DateTime fecFinFacCV;
                String concatCodSis = f.RucDni + "-" + f.CodigoLC;
                for (int i = 0; i < cuadroVencimiento.Rows.Count; i++)
                {
                    concatCodActCV = cuadroVencimiento.Rows[i]["concatCodActCV"].ToString();
                    concatCodAntCV = cuadroVencimiento.Rows[i]["concatCodAntCV"].ToString();
                    facturaCV = cuadroVencimiento.Rows[i]["numFactura"].ToString();
                    fecFinFacCV = DateTime.Parse(cuadroVencimiento.Rows[i]["fecFinPago"].ToString());
                    guiaSalidaCV = cuadroVencimiento.Rows[i]["guiaSalida"].ToString();

                    if (((concatCodSis == concatCodActCV) || (concatCodSis == concatCodAntCV)) && f.NumeroDocRef== guiaSalidaCV)
                    {
                        if (facturaCV != f.NumeroFactura)
                        {
                            if ((f.TipoPago == "RENOVACION") || (f.TipoPago == "ALQUILER"))
                            {
                                if (f.FechaIniPago > fecFinFacCV)
                                {
                                    if (f.FechaIniPago < f.FechaFinPago)
                                    {
                                        if (fecFinFacCV.ToString() == "31/12/1999 00:00:00")
                                        {
                                            if(flag==2)//2 es grabar
                                            {
                                                facturaDA.InsertarFactura(f, this.nombreUsuario);
                                                f.ObservacionXLevantar = "Se grabo correctamente la factura";
                                            }
                                            else
                                            {
                                                f.ObservacionXLevantar = "Todo Bien, es la primera factura, no hay factura anterior";
                                            }
                                            
                                            break;
                                        }
                                        else
                                        {
                                            TimeSpan tSpan = f.FechaIniPago - fecFinFacCV;
                                            int numDiasTrans = tSpan.Days;
                                            if (numDiasTrans != 1)
                                            {
                                                f.ObservacionXLevantar = "Esta factura tiene errores en la fecha. Hay un Salto de fechas de " + numDiasTrans + " dias.";
                                                break;
                                            }
                                            else
                                            {
                                                if (flag == 2)//2 es grabar
                                                {
                                                    facturaDA.InsertarFactura(f, this.nombreUsuario);
                                                    f.ObservacionXLevantar = "Se grabo correctamente la factura";
                                                }
                                                else
                                                {
                                                    f.ObservacionXLevantar = "Todo Bien";
                                                }
                                                
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        f.ObservacionXLevantar = "Error en las fechas, la fecha final de la factura de Sisgeco es menor o igual a la fecha inicial de la factura de Sisgeco";
                                        break;
                                    }
                                }
                                else
                                {
                                    f.ObservacionXLevantar = "Error en la fechas, la fecha final de la ultima factura pagada es mayor o igual a la fecha inicio de esta nueva factura";
                                    break;
                                }
                            }
                            else
                            {
                                f.ObservacionXLevantar = "Esta factura no es del tipo Renovacion o Alquiler";
                                break;
                            }
                        }
                        else
                        {
                            f.ObservacionXLevantar = "Esta factura ya esta registrada";
                            break;
                        }
                    }
                }
            }
            dgvFacturas.PrimaryGrid.DataSource = facturas;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Validar(1);
            MessageBox.Show("Se terminó la validación", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
