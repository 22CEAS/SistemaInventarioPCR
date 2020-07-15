using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AlquilerDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public AlquilerDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarLaptopsAlmacenSinMemoriaDisco()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_laptops_almacen_lista ;");
        }
        public DataTable ListarLaptopDisco(int idLC)
        {
            return objManager.MostrarTablaDatos("Select * from vista_laptops_discos where idLC=" + idLC + " ;");
        }
        public DataTable ListarLaptopMemoria(int idLC)
        {
            return objManager.MostrarTablaDatos("Select * from vista_laptops_memorias where idLC=" + idLC + " ;");
        }
        public DataTable ListarLaptopLicencia(int idLC)
        {
            return objManager.MostrarTablaDatos("Select * from vista_licencia_lista where idLC="+idLC+" ;");
        }
    }
}
