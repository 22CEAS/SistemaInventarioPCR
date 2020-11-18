using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MarcaDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public MarcaDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM marca; ");
        }

        public int GuardarNuevaMarca(Marca marca, string usuario)
        {
            string sql = "Select * From marca where cod_tabla ='" + marca.IdCategoria + "' and nombre= '" + marca.NombreMarca + "' ;";
            MySqlDataReader reader;
            reader = objManager.MostrarInformacion(sql);

            if (!(reader.HasRows))
            {
                objManager.conexion.Close();
                objManager.conexion.Dispose();
                objManager.cmd.Dispose();

                parametrosEntrada = new MySqlParameter[4];
                parametrosEntrada[0] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_nombre", MySqlDbType.VarChar, 255);
                parametrosEntrada[2] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idMarca", MySqlDbType.Int32);

                parametrosEntrada[0].Value = marca.IdCategoria;
                parametrosEntrada[1].Value = marca.NombreMarca;
                parametrosEntrada[2].Value = marca.Estado;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_marca",
                    3, 4, out datosSalida, 1);

                if (datosSalida != null)
                {
                    int idMarca = Convert.ToInt32(datosSalida[0]);
                    return idMarca;
                }
                return -1;
            }
            else
            {
                objManager.conexion.Close();
                objManager.conexion.Dispose();
                objManager.cmd.Dispose();
                return 0;
            }
        }
        public int ModificarMarca(Marca marca, string usuario, int actualizarEstado)
        {
            string sql = "";
            if (actualizarEstado == 1)
            {
                sql = "Select * From marca where idCategoria ='" + marca.IdCategoria + "' and nombre= '" + marca.NombreMarca + "' and estado=" + marca.Estado + " ;";
            }
            else
            {
                sql = "Select * From marca where idCategoria ='" + marca.IdCategoria + "' and nombre= '" + marca.NombreMarca + "' ;";
            }

            MySqlDataReader reader;
            reader = objManager.MostrarInformacion(sql);

            if (!(reader.HasRows))
            {
                objManager.conexion.Close();
                objManager.conexion.Dispose();
                objManager.cmd.Dispose();

                parametrosEntrada = new MySqlParameter[4];
                parametrosEntrada[0] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_nombre", MySqlDbType.VarChar, 255);
                parametrosEntrada[2] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idMarca", MySqlDbType.Int32);

                parametrosEntrada[0].Value = marca.IdCategoria;
                parametrosEntrada[1].Value = marca.NombreMarca;
                parametrosEntrada[2].Value = marca.Estado;
                parametrosEntrada[3].Value = marca.IdMarca;

                bool aux = objManager.EjecutarProcedure(parametrosEntrada, "update_marca");
                return ((aux) ? 1 : -1);
            }
            else
            {
                objManager.conexion.Close();
                objManager.conexion.Dispose();
                objManager.cmd.Dispose();
                return 0;
            }
        }
    }
}
