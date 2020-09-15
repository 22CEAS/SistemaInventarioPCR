using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using MySql.Data.MySqlClient;
namespace AccesoDatos
{
    public class IngresoDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;
        int IdCategoriaWindows = 12;
        int IdCategoriaOffice = 13;
        int IdCategoriaAntivirus = 14;

        public IngresoDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarDiscosDuros()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_disco ;");
        }

        public DataTable ListarProcesadores()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_procesador ;");
        }

        public DataTable ListarMemorias()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_memoria ;");
        }

        public DataTable ListarTarjetaVideos()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_video ;");
        }

        public DataTable ListarLicencias()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_licencias ;");
        }

        public DataTable ListarMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_laptops_marca ;");
        }

        public DataTable ListarModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_laptops_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarDestinos()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_disco ;");
        }

        public DataTable ListarProveedores()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proveedor_lista ;");
        }

        public DataTable ListarIngresoTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_ingreso_tipo ;");
        }


        public int InsertarIngreso(Ingreso ingreso, string usuario)
        {

            bool error = false;

            parametrosEntrada = new MySqlParameter[14];
            parametrosEntrada[0] = new MySqlParameter("@_idOC", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idTipoIngreso", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_tipoIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
            parametrosEntrada[4] = new MySqlParameter("@_razonSocial", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[6] = new MySqlParameter("@_facturaIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_guiaIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_fecIngresa", MySqlDbType.DateTime);
            parametrosEntrada[9] = new MySqlParameter("@_total", MySqlDbType.Double);
            parametrosEntrada[10] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[11] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[12] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            parametrosEntrada[13] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);

            parametrosEntrada[0].Value = 0;
            parametrosEntrada[1].Value = ingreso.IdTipoIngreso;
            parametrosEntrada[2].Value = ingreso.TipoIngreso;
            parametrosEntrada[3].Value = ingreso.IdProveedor;
            parametrosEntrada[4].Value = ingreso.RazonSocial;
            parametrosEntrada[5].Value = ingreso.Ruc;
            parametrosEntrada[6].Value = ingreso.Factura;
            parametrosEntrada[7].Value = ingreso.Guia;
            parametrosEntrada[8].Value = ingreso.FechaIngreso;
            parametrosEntrada[9].Value = ingreso.Total;
            parametrosEntrada[10].Value = ingreso.Observacion;
            parametrosEntrada[11].Value = ingreso.Estado;
            parametrosEntrada[12].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso",
                13, 14, out datosSalida, 1);

            if (datosSalida != null)
            {
                ingreso.IdIngreso = Convert.ToInt32(datosSalida[0]);
                if (ingreso.Detalles.Count > 0)
                {
                    error = InsertarDetalleIngreso(ingreso, usuario);
                    if (error) return -1;

                    foreach (IngresoDetalle det in ingreso.Detalles)
                    {
                        for (int i = 0; i < det.Cantidad; i++)
                        {
                            parametrosEntrada = new MySqlParameter[16];
                            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                            parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                            parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                            parametrosEntrada[3] = new MySqlParameter("@_descripcion", MySqlDbType.VarChar, 250);
                            parametrosEntrada[4] = new MySqlParameter("@_tamanoPantalla", MySqlDbType.Double);
                            parametrosEntrada[5] = new MySqlParameter("@_idProcesador", MySqlDbType.Int32);
                            parametrosEntrada[6] = new MySqlParameter("@_idVideo", MySqlDbType.Int32);
                            parametrosEntrada[7] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 80);
                            parametrosEntrada[8] = new MySqlParameter("@_serieFabrica", MySqlDbType.VarChar, 80);
                            parametrosEntrada[9] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                            parametrosEntrada[10] = new MySqlParameter("@_fecInicioSeguro", MySqlDbType.DateTime);
                            parametrosEntrada[11] = new MySqlParameter("@_fecFinSeguro", MySqlDbType.DateTime);
                            parametrosEntrada[12] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 80);
                            parametrosEntrada[13] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                            parametrosEntrada[14] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                            parametrosEntrada[15] = new MySqlParameter("@_idLC", MySqlDbType.Int32);

                            parametrosEntrada[0].Value = ingreso.IdIngreso;
                            parametrosEntrada[1].Value = det.IdIngresoDetalle;
                            parametrosEntrada[2].Value = det.LaptopIdModelo;
                            parametrosEntrada[3].Value = "";
                            parametrosEntrada[4].Value = det.LaptopTamanoPantalla;
                            parametrosEntrada[5].Value = det.Laptop.Procesador.IdProcesador;
                            if(det.Laptop.Video.IdVideo == 0)
                            {
                                parametrosEntrada[6].Value = null;
                            }
                            else
                            {
                                parametrosEntrada[6].Value = det.Laptop.Video.IdVideo;
                            }
                            parametrosEntrada[7].Value = det.Laptop.PartNumber;
                            parametrosEntrada[8].Value = det.Series[i];
                            parametrosEntrada[9].Value = det.Laptop.Garantia;
                            parametrosEntrada[10].Value = null;
                            parametrosEntrada[11].Value = null;
                            parametrosEntrada[12].Value = "ALMACEN";
                            parametrosEntrada[13].Value = det.Laptop.Observacion;
                            parametrosEntrada[14].Value = usuario;


                            datosSalida = new string[1];

                            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_laptop_cpu",
                                15, 16, out datosSalida, 1);
                            if (datosSalida != null)
                            {
                                int idLC = Convert.ToInt32(datosSalida[0]);
                                
                                foreach(Memoria mem in det.Laptop.Memorias)
                                {
                                    parametrosEntrada = new MySqlParameter[4];
                                    parametrosEntrada[0] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                                    parametrosEntrada[1] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                                    parametrosEntrada[2] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                                    parametrosEntrada[3] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);

                                    parametrosEntrada[0].Value = mem.IdMemoria;
                                    parametrosEntrada[1].Value = idLC;
                                    parametrosEntrada[2].Value = mem.Cantidad;
                                    parametrosEntrada[3].Value =usuario;

                                    bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_memoria_LC_ingreso");
                                }

                                foreach (DiscoDuro disco in det.Laptop.Discos)
                                {
                                    parametrosEntrada = new MySqlParameter[4];
                                    parametrosEntrada[0] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                                    parametrosEntrada[1] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                                    parametrosEntrada[2] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                                    parametrosEntrada[3] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);

                                    parametrosEntrada[0].Value = disco.IdDisco;
                                    parametrosEntrada[1].Value = idLC;
                                    parametrosEntrada[2].Value = disco.Cantidad;
                                    parametrosEntrada[3].Value = usuario;

                                    bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_disco_LC_ingreso");
                                }


                                foreach (Licencia licencia in det.Laptop.Licencias)
                                {
                                    parametrosEntrada = new MySqlParameter[9];
                                    parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                                    parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                                    parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                                    parametrosEntrada[3] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                                    parametrosEntrada[4] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 80);
                                    parametrosEntrada[5] = new MySqlParameter("@_fechaActivacion", MySqlDbType.DateTime);
                                    parametrosEntrada[6] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 80);
                                    parametrosEntrada[7] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 80);
                                    parametrosEntrada[8] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 80);

                                    parametrosEntrada[0].Value = ingreso.IdIngreso;
                                    parametrosEntrada[1].Value = 1;//Id=1 es idIngresoDet Id=2 es idIngresoDetAccesorios
                                    parametrosEntrada[2].Value = licencia.IdModelo;
                                    parametrosEntrada[3].Value = idLC;
                                    if (licencia.IdCategoria == IdCategoriaWindows)
                                    {
                                        parametrosEntrada[4].Value = det.Windows[i];
                                    }
                                    else if (licencia.IdCategoria == IdCategoriaOffice)
                                    {
                                        parametrosEntrada[4].Value = det.Office[i];
                                    }
                                    else if (licencia.IdCategoria == IdCategoriaAntivirus)
                                    {
                                        parametrosEntrada[4].Value = det.Antivirus[i];
                                    }

                                    parametrosEntrada[5].Value = ingreso.FechaIngreso;
                                    parametrosEntrada[6].Value = "ALMACEN";
                                    parametrosEntrada[7].Value = licencia.Observacion;
                                    parametrosEntrada[8].Value = usuario;

                                    bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_licencia_det");
                                    
                                }
                            }
                        }
                    }

                }
                if (ingreso.Discos.Count > 0 || ingreso.Memorias.Count > 0 || ingreso.Licencias.Count > 0)
                {
                    error = InsertarDetalleAccesoriosIngreso(ingreso, usuario);
                    if (error) return -1;

                    foreach(DiscoDuro disco in ingreso.Discos)
                    {
                        parametrosEntrada = new MySqlParameter[2];
                        parametrosEntrada[0] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);

                        parametrosEntrada[0].Value = disco.IdDisco;
                        parametrosEntrada[1].Value = disco.Cantidad;

                        bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_disco_cantidad");
                    }

                    foreach (Memoria memoria in ingreso.Memorias)
                    {
                        parametrosEntrada = new MySqlParameter[2];
                        parametrosEntrada[0] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);

                        parametrosEntrada[0].Value = memoria.IdMemoria;
                        parametrosEntrada[1].Value = memoria.Cantidad;

                        bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_memoria_cantidad");
                    }

                    foreach (Licencia licencia in ingreso.Licencias)
                    {
                        for(int i = 0; i < licencia.Cantidad;i++)
                        {
                            parametrosEntrada = new MySqlParameter[9];
                            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                            parametrosEntrada[1] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);
                            parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                            parametrosEntrada[3] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                            parametrosEntrada[4] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 80);
                            parametrosEntrada[5] = new MySqlParameter("@_fechaActivacion", MySqlDbType.DateTime);
                            parametrosEntrada[6] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 80);
                            parametrosEntrada[7] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 80);
                            parametrosEntrada[8] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 80);

                            parametrosEntrada[0].Value = ingreso.IdIngreso;
                            parametrosEntrada[1].Value = 2;//Id=1 es idIngresoDet Id=2 es idIngresoDetAccesorios
                            parametrosEntrada[2].Value = licencia.IdModelo;
                            parametrosEntrada[3].Value = null;
                            parametrosEntrada[4].Value = licencia.Clave;
                            parametrosEntrada[5].Value = null;
                            parametrosEntrada[6].Value = "ALMACEN";
                            parametrosEntrada[7].Value = licencia.Observacion;
                            parametrosEntrada[8].Value = usuario;

                            bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_licencia_det_accesorios");
                        }
                    }
                }

            }
            return ingreso.IdIngreso;
        }


        public bool InsertarDetalleIngreso(Ingreso ingreso, string usuario)
        {
            foreach (IngresoDetalle det in ingreso.Detalles)
            {
                parametrosEntrada = new MySqlParameter[28];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idMarcaLC", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLC", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_pantalla", MySqlDbType.Double);
                parametrosEntrada[5] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_idProcesador", MySqlDbType.Int32);
                parametrosEntrada[9] = new MySqlParameter("@_idVideo", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_idDisco1", MySqlDbType.Int32);
                parametrosEntrada[11] = new MySqlParameter("@_cantidadDisco1", MySqlDbType.Int32);
                parametrosEntrada[12] = new MySqlParameter("@_idDisco2", MySqlDbType.Int32);
                parametrosEntrada[13] = new MySqlParameter("@_cantidadDisco2", MySqlDbType.Int32);
                parametrosEntrada[14] = new MySqlParameter("@_idMemoria1", MySqlDbType.Int32);
                parametrosEntrada[15] = new MySqlParameter("@_cantidadMemoria1", MySqlDbType.Int32);
                parametrosEntrada[16] = new MySqlParameter("@_idMemoria2", MySqlDbType.Int32);
                parametrosEntrada[17] = new MySqlParameter("@_cantidadMemoria2", MySqlDbType.Int32);
                parametrosEntrada[18] = new MySqlParameter("@_idMemoria3", MySqlDbType.Int32);
                parametrosEntrada[19] = new MySqlParameter("@_cantidadMemoria3", MySqlDbType.Int32);
                parametrosEntrada[20] = new MySqlParameter("@_idModeloWindows", MySqlDbType.Int32);
                parametrosEntrada[21] = new MySqlParameter("@_idModeloOffice", MySqlDbType.Int32);
                parametrosEntrada[22] = new MySqlParameter("@_idModeloAntivirus", MySqlDbType.Int32);
                parametrosEntrada[23] = new MySqlParameter("@_caracteristicas", MySqlDbType.VarChar, 100);
                parametrosEntrada[24] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[25] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[26] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[27] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.LaptopIdMarca;
                parametrosEntrada[2].Value = det.LaptopIdModelo;
                parametrosEntrada[3].Value = det.Laptop.PartNumber;
                parametrosEntrada[4].Value = det.LaptopTamanoPantalla;
                parametrosEntrada[5].Value = det.Laptop.Garantia;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Laptop.IdProcesador;
                parametrosEntrada[9].Value = det.Laptop.IdVideo;
                int cantDiscos = det.Laptop.Discos.Count;
                if (cantDiscos == 1)
                {
                    parametrosEntrada[10].Value = det.Laptop.Discos[0].IdDisco;
                    parametrosEntrada[11].Value = det.Laptop.Discos[0].Cantidad;
                    parametrosEntrada[12].Value = 0;
                    parametrosEntrada[13].Value = 0;
                }
                else if (cantDiscos == 2)
                {
                    parametrosEntrada[10].Value = det.Laptop.Discos[0].IdDisco;
                    parametrosEntrada[11].Value = det.Laptop.Discos[0].Cantidad;
                    parametrosEntrada[12].Value = det.Laptop.Discos[1].IdDisco;
                    parametrosEntrada[13].Value = det.Laptop.Discos[1].Cantidad;
                }

                int cantMemorias = det.Laptop.Memorias.Count;
                if (cantMemorias == 1)
                {
                    parametrosEntrada[14].Value = det.Laptop.Memorias[0].IdMemoria;
                    parametrosEntrada[15].Value = det.Laptop.Memorias[0].Cantidad;
                    parametrosEntrada[16].Value = 0;
                    parametrosEntrada[17].Value = 0;
                    parametrosEntrada[18].Value = 0;
                    parametrosEntrada[19].Value = 0;
                }
                else if (cantMemorias == 2)
                {
                    parametrosEntrada[14].Value = det.Laptop.Memorias[0].IdMemoria;
                    parametrosEntrada[15].Value = det.Laptop.Memorias[0].Cantidad;
                    parametrosEntrada[16].Value = det.Laptop.Memorias[1].IdMemoria;
                    parametrosEntrada[17].Value = det.Laptop.Memorias[1].Cantidad;
                    parametrosEntrada[18].Value = 0;
                    parametrosEntrada[19].Value = 0;
                }
                else if (cantMemorias == 3)
                {
                    parametrosEntrada[14].Value = det.Laptop.Memorias[0].IdMemoria;
                    parametrosEntrada[15].Value = det.Laptop.Memorias[0].Cantidad;
                    parametrosEntrada[16].Value = det.Laptop.Memorias[1].IdMemoria;
                    parametrosEntrada[17].Value = det.Laptop.Memorias[1].Cantidad;
                    parametrosEntrada[18].Value = det.Laptop.Memorias[2].IdMemoria;
                    parametrosEntrada[19].Value = det.Laptop.Memorias[2].Cantidad;
                }
                int idWin = -1;
                int idOff = -1;
                int idAnt = -1;
                for (int i = 0; i < det.Laptop.Licencias.Count; i++)
                {
                    if (det.Laptop.Licencias[i].IdCategoria == IdCategoriaWindows)
                        idWin = det.Laptop.Licencias[i].IdModelo;
                    else if (det.Laptop.Licencias[i].IdCategoria == IdCategoriaOffice)
                        idOff = det.Laptop.Licencias[i].IdModelo;
                    else if (det.Laptop.Licencias[i].IdCategoria == IdCategoriaAntivirus)
                        idAnt = det.Laptop.Licencias[i].IdModelo;
                }
                parametrosEntrada[20].Value = (idWin==-1)?0: idWin;
                parametrosEntrada[21].Value = (idOff == -1) ? 0 : idOff;
                parametrosEntrada[22].Value = (idAnt == -1) ? 0 : idAnt;
                parametrosEntrada[23].Value = det.Caracteristica;
                parametrosEntrada[24].Value = det.Observacion;
                parametrosEntrada[25].Value = det.Estado;
                parametrosEntrada[26].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det",
                27, 28, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool InsertarDetalleAccesoriosIngreso(Ingreso ingreso, string usuario)
        {
            foreach (Licencia det in ingreso.Licencias)
            {
                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLicencia", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.IdCategoria;
                parametrosEntrada[2].Value = det.IdModelo;
                parametrosEntrada[3].Value = det.Clave;
                parametrosEntrada[4].Value = 0;
                parametrosEntrada[5].Value = 0;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Observacion;
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_accesorios",
                11, 12, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
            }

            foreach (DiscoDuro det in ingreso.Discos)
            {
                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLicencia", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = 0;
                parametrosEntrada[2].Value = 0;
                parametrosEntrada[3].Value = "";
                parametrosEntrada[4].Value = det.IdDisco;
                parametrosEntrada[5].Value = 0;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Observacion;
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_accesorios",
                11, 12, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
            }

            foreach (Memoria det in ingreso.Memorias)
            {
                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLicencia", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = 0;
                parametrosEntrada[2].Value = 0;
                parametrosEntrada[3].Value = "";
                parametrosEntrada[4].Value = 0;
                parametrosEntrada[5].Value = det.IdMemoria;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Observacion;
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_accesorios",
                11, 12, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
