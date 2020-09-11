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
    }
}
