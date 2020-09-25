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
    public class FacturaDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public FacturaDA()
        {
            objManager = new DBManager();
        }
        public DataTable ListarCV()
        {
            return objManager.MostrarTablaDatos("Select * from vista_factura_CV ;");
        }
        public int InsertarFacturas(BindingList<Factura> facturas, string usuario)
        {

            foreach(Factura factura in facturas)
            {
                MySqlDataReader reader;
                string sql = "";
                sql = "SELECT DISTINCT s.idSalida FROM salida s INNER JOIN salida_det d ON s.idSalida = d.idSalida WHERE d.guiaSalida = '" + factura.NumeroDocRef + "' ;";
                reader = objManager.MostrarInformacion(sql);

                while (reader.Read())
                {
                    factura.IdSalida = reader.GetInt32("idSalida");
                }

                objManager.conexion.Close();
                objManager.conexion.Dispose();
                objManager.cmd.Dispose();


                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_numFactura", MySqlDbType.VarChar, 255);
                parametrosEntrada[2] = new MySqlParameter("@_fecIniPago", MySqlDbType.DateTime);
                parametrosEntrada[3] = new MySqlParameter("@_fecFinPago", MySqlDbType.DateTime);
                parametrosEntrada[4] = new MySqlParameter("@_fecEmisiom", MySqlDbType.DateTime);
                parametrosEntrada[5] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
                parametrosEntrada[6] = new MySqlParameter("@_codigoLC", MySqlDbType.VarChar, 255);
                parametrosEntrada[7] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);

                parametrosEntrada[0].Value = factura.IdSalida;
                parametrosEntrada[1].Value = factura.NumeroFactura;
                parametrosEntrada[2].Value = factura.FechaIniPago;
                parametrosEntrada[3].Value = factura.FechaFinPago;
                parametrosEntrada[4].Value = factura.FechaPago;
                parametrosEntrada[5].Value = factura.RucDni;
                parametrosEntrada[6].Value = factura.CodigoLC;
                parametrosEntrada[7].Value = factura.NumeroDocRef;
                parametrosEntrada[8].Value = "";
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_factura",
                    11, 12, out datosSalida, 1);

                if (datosSalida != null)
                {
                    factura.IdFactura = Convert.ToInt32(datosSalida[0]);
                }

            }

            return 1;
        }

        public int InsertarFactura(Factura factura, string usuario)
        {

            MySqlDataReader reader;
            string sql = "";
            sql = "SELECT DISTINCT s.idSalida FROM salida s INNER JOIN salida_det d ON s.idSalida = d.idSalida WHERE d.guiaSalida = '" + factura.NumeroDocRef + "' ;";
            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                factura.IdSalida = reader.GetInt32("idSalida");
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();


            parametrosEntrada = new MySqlParameter[12];
            parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_numFactura", MySqlDbType.VarChar, 255);
            parametrosEntrada[2] = new MySqlParameter("@_fecIniPago", MySqlDbType.DateTime);
            parametrosEntrada[3] = new MySqlParameter("@_fecFinPago", MySqlDbType.DateTime);
            parametrosEntrada[4] = new MySqlParameter("@_fecEmisiom", MySqlDbType.DateTime);
            parametrosEntrada[5] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[6] = new MySqlParameter("@_codigoLC", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            parametrosEntrada[11] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdSalida;
            parametrosEntrada[1].Value = factura.NumeroFactura;
            parametrosEntrada[2].Value = factura.FechaIniPago;
            parametrosEntrada[3].Value = factura.FechaFinPago;
            parametrosEntrada[4].Value = factura.FechaPago;
            parametrosEntrada[5].Value = factura.RucDni;
            parametrosEntrada[6].Value = factura.CodigoLC;
            parametrosEntrada[7].Value = factura.NumeroDocRef;
            parametrosEntrada[8].Value = "";
            parametrosEntrada[9].Value = 1;
            parametrosEntrada[10].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_factura",
                11, 12, out datosSalida, 1);

            if (datosSalida != null)
            {
                factura.IdFactura = Convert.ToInt32(datosSalida[0]);
            }

            sql = "Select * from laptop_cpu where codigo='" + factura.CodigoLC + "' ;";
            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                factura.IdLC = reader.GetInt32("idLC");
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();


            parametrosEntrada = new MySqlParameter[2];
            parametrosEntrada[0] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idLC", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdSalida;
            parametrosEntrada[1].Value = factura.IdLC;

            bool okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_cuota");


            parametrosEntrada = new MySqlParameter[12];
            parametrosEntrada[0] = new MySqlParameter("@_idFactura", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idSalida", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
            parametrosEntrada[3] = new MySqlParameter("@_numFactura", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_fecInicioPago", MySqlDbType.DateTime);
            parametrosEntrada[5] = new MySqlParameter("@_fecFinPago", MySqlDbType.DateTime);
            parametrosEntrada[6] = new MySqlParameter("@_fecEmisiom", MySqlDbType.DateTime);
            parametrosEntrada[7] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[8] = new MySqlParameter("@_codigoLC", MySqlDbType.VarChar, 255);
            parametrosEntrada[9] = new MySqlParameter("@_guiaSalida", MySqlDbType.VarChar, 255);
            parametrosEntrada[10] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[11] = new MySqlParameter("@_estado", MySqlDbType.Int32);

            parametrosEntrada[0].Value = factura.IdFactura;
            parametrosEntrada[1].Value = factura.IdSalida;
            parametrosEntrada[2].Value = factura.IdLC;
            parametrosEntrada[3].Value = factura.NumeroFactura;
            parametrosEntrada[4].Value = factura.FechaIniPago;
            parametrosEntrada[5].Value = factura.FechaFinPago;
            parametrosEntrada[6].Value = factura.FechaPago;
            parametrosEntrada[7].Value = factura.RucDni;
            parametrosEntrada[8].Value = factura.CodigoLC;
            parametrosEntrada[9].Value = factura.NumeroDocRef;
            parametrosEntrada[10].Value = "";
            parametrosEntrada[11].Value = 1;

            okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_cuota");
            
            return 1;
        }
    }
}
