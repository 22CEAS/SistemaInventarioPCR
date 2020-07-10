using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Licencia
    {
        private int idLicencia;
        private string codigo;
        private int idModelo;
        private Modelo modelo;
        private int idLC;
        private string clave;
        private DateTime fechaActivacion;
        private string Ubicacion;
        private string observacion;
        private string estado;

        public Licencia()
        {
            this.Modelo = null;
        }

        public Licencia(int idLicencia, string codigo, int idModelo, Modelo modelo, int idLC, string clave, DateTime fechaActivacion, string ubicacion, string observacion, string estado)
        {
            this.IdLicencia = idLicencia;
            this.Codigo = codigo;
            this.IdModelo = idModelo;
            this.Modelo = modelo;
            this.IdLC = idLC;
            this.Clave = clave;
            this.FechaActivacion = fechaActivacion;
            Ubicacion1 = ubicacion;
            this.Observacion = observacion;
            this.Estado = estado;
        }

        public int IdLicencia { get => idLicencia; set => idLicencia = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public int IdLC { get => idLC; set => idLC = value; }
        public string Clave { get => clave; set => clave = value; }
        public DateTime FechaActivacion { get => fechaActivacion; set => fechaActivacion = value; }
        public string Ubicacion1 { get => Ubicacion; set => Ubicacion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
