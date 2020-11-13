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
    public class SubmoduloDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public SubmoduloDA()
        {
            objManager = new DBManager();
        }

        
        public DataTable ListarSubmodulosPermisos(int idModuloP, int idUsuario)
        {
            return objManager.MostrarTablaDatos(
                "Select * from submodulos" +
                $" where idModuloP={idModuloP}" +
                $" and idSubmodulo not in (select idSubmodulo from accesos_usuarios where idUsuario={idUsuario});"
                );
        }

        public DataTable ListarPermisosUsuario(int idModuloP, int idUsuario)
        {

            return objManager.MostrarTablaDatos(
                "select * from accesos_usuarios" +
                $" where idUsuario={idUsuario}" +
                $" and idSubmodulo in (select idSubmodulo from submodulos" +
                $"                      where idModuloP={idModuloP});"
                );

        }

    }
}
