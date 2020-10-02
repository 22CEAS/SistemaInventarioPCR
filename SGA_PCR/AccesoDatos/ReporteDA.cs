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
    public class ReporteDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public ReporteDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarLaptopsPorVencer()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_laptops_por_vencer ;");
        }
    }
}
