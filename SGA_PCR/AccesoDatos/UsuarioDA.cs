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

        public string Obtener_clave_usuario(string usuario)
        {

            MySqlDataReader reader;
            string sql = "";
            string clave = "";

            sql = $"Select * From usuario where usuario='{usuario}';";

            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                clave = reader.GetString("claveUsuario");
            }

            objManager.conexion.Close(); objManager.conexion.Dispose(); objManager.cmd.Dispose();

            return clave;
        }

        public string Obtener_idUsuario(string usuario)
        {

            MySqlDataReader reader;
            string sql = "";
            string id = "";

            sql = $"Select * From usuario where usuario='{usuario}';";

            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                id = reader.GetString("idUsuario");
            }

            objManager.conexion.Close(); objManager.conexion.Dispose(); objManager.cmd.Dispose();

            return id;
        }



        public int InsertarNuevoUsuario(string dni,string nombre,string usuario,string claveUsuario,string email,int idArea)
        {
            parametrosEntrada = new MySqlParameter[6];

            parametrosEntrada[0] = new MySqlParameter("@_dni", MySqlDbType.VarChar, 255);
            parametrosEntrada[1] = new MySqlParameter("@_nombre", MySqlDbType.VarChar, 255);
            parametrosEntrada[2] = new MySqlParameter("@_usuario", MySqlDbType.VarChar, 20);
            parametrosEntrada[3] = new MySqlParameter("@_claveUsuario", MySqlDbType.VarChar, 255);
            parametrosEntrada[4] = new MySqlParameter("@_email", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_idArea", MySqlDbType.Int32);


            parametrosEntrada[0].Value = dni;
            parametrosEntrada[1].Value = nombre;
            parametrosEntrada[2].Value = usuario;
            parametrosEntrada[3].Value = claveUsuario;
            parametrosEntrada[4].Value = email;
            parametrosEntrada[5].Value = idArea;



            bool x = objManager.EjecutarProcedure(parametrosEntrada, "insert_usuario");

            if (!x)
            {
                MessageBox.Show("OCURRIÓ UN ERROR");
            }

            objManager.conexion.Close(); objManager.conexion.Dispose(); objManager.cmd.Dispose();
            return 1;
        }


        //USADO EN FORMULARIO DE CONFIGURACION DE PERMISOS
        public DataTable ListarUsuarios()
        {
            return objManager.MostrarTablaDatos("Select * from vista_usuarios;"); //SOLO RETORNA idUsuario y usuario
        }
    }
}
