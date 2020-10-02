using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class RenovacionDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public RenovacionDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarLaptopsClientesEstadoAlquilado(int idCliente)
        {
            return objManager.MostrarTablaDatos("Select * From vista_laptops_detalle_alquiler_plazo_alquiler where idCliente=" + idCliente + " ;");
        }

        public int InsertarRenovaciones(BindingList<Renovacion> renovaciones, string usuario)
        {

            bool error = false;

            foreach(Renovacion renovacion in renovaciones)
            {
                parametrosEntrada = new MySqlParameter[3];
                parametrosEntrada[0] = new MySqlParameter("@_idSalidaDet", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_fecFinContrato", MySqlDbType.DateTime);
                parametrosEntrada[2] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);

                parametrosEntrada[0].Value = renovacion.IdSalidaDetalle;
                parametrosEntrada[1].Value = renovacion.FechaFinContrato;
                parametrosEntrada[2].Value = usuario;
                bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_salida_det_fechaFinalPlazo");
                if (!okey) return 0;

            }

            return 1;
        }
    }
}
