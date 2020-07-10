using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Modelo
    {
        private int idModelo;
        private string nombreModelo;
        private int idMarca;
        private int estado;

        public Modelo()
        {

        }
            public Modelo(int idModelo, string nombreModelo, int idMarca, int estado)
        {
            this.IdModelo = idModelo;
            this.NombreModelo = nombreModelo;
            this.IdMarca = idMarca;
            this.Estado = estado;
        }

        public int IdModelo { get => idModelo; set => idModelo = value; }
        public string NombreModelo { get => nombreModelo; set => nombreModelo = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
