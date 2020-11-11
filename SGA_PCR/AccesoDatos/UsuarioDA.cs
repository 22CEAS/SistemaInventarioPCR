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
    public class UsuarioDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public UsuarioDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarUsuario()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM usuario ; ");
        }

        public string Obtener_clave_usuario(string idUsuario)
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
    }
}
