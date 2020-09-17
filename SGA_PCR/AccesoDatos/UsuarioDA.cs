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
    }
}
