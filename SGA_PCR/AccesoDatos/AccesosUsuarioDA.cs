using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class AccesosUsuarioDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public AccesosUsuarioDA()
        {
            objManager = new DBManager();
        }

        public string permisos(string idUsuario)
        {

            MySqlDataReader reader;
            string sql = "";
            string clave = "";

            sql = $"Select * From usuarios where idUsuario='{idUsuario}';";

            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                clave = reader.GetString("claveUsuario");
            }

            objManager.conexion.Close(); objManager.conexion.Dispose(); objManager.cmd.Dispose();

            return clave;
        }

        public List<string> Obtener_accessos(string idUsuario,int idModuloP)
        {

            List<string> lista = new List<string>();

            MySqlDataReader reader;
            string sql = "";
            string idSubmodulo = "";

            sql = $"select * from accesos_usuarios " +
                $"where 1 = 1 " +
                $"and idUsuario = '{idUsuario}' " +
                $"and idSubmodulo in (select idSubmodulo " +
                $"                    from submodulos " +
                $"                    where 1 = 1 " +
                $"                    and idModuloP = {idModuloP})";

            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                idSubmodulo = reader.GetString("idSubmodulo");
                lista.Add(idSubmodulo);
            }

            return lista;

        }
    }
}
