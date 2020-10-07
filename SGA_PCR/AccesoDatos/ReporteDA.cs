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

        public DataTable ListarLaptopsPorFacturar()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_productos_por_facturar ;");
        }

        public DataTable ListarLaptopsFacturasPorVencer()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_facturas_por_vencer ;");
        }

        public DataTable ListarLaptopsPorRecoger()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_productos_por_recoger ;");
        }

        public DataTable ListarLaptopsInventario()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_inventario_laptops ;");
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
            return objManager.MostrarTablaDatos("Select * from vista_licencia_lc_lista where idLC=" + idLC + " ;");
        }

        public DataTable ListarMemorias()
        {
            return objManager.MostrarTablaDatos("Select * from vista_inventario_memoria;");
        }
        public DataTable ListarDiscos()
        {
            return objManager.MostrarTablaDatos("Select * from vista_inventario_discos;");
        }
        public DataTable ListarLicencias()
        {
            return objManager.MostrarTablaDatos("Select * from vista_stockDisponible_licencia_libre;");
        }

        public DataTable ListarObservaciones()
        {
            return objManager.MostrarTablaDatos("Select * from vista_lista_observaciones ;");
        }

        public DataTable ListarReparaciones()
        {
            return objManager.MostrarTablaDatos("Select * from vista_lista_reparaciones v ;");
        }

    }
}
