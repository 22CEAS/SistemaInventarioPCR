using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Procesador
    {
        private int idProcesador;
        private string codigo;
        private int idModelo;
        private Modelo modelo;
        private int generacion;
        private string velocidad;
        private double velocidadMax;
        private string observacion;
        private int estado;

        public Procesador()
        {
            this.Modelo = null;
        }

        public Procesador(int idProcesador, string codigo, int idModelo, Modelo modelo, int generacion, string velocidad, double velocidadMax, string observacion, int estado)
        {
            this.IdProcesador = idProcesador;
            this.Codigo = codigo;
            this.IdModelo = idModelo;
            this.Modelo = modelo;
            this.Generacion = generacion;
            this.Velocidad = velocidad;
            this.VelocidadMax = velocidadMax;
            this.Observacion = observacion;
            this.Estado = estado;
        }

        public int IdProcesador { get => idProcesador; set => idProcesador = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public int Generacion { get => generacion; set => generacion = value; }
        public string Velocidad { get => velocidad; set => velocidad = value; }
        public double VelocidadMax { get => velocidadMax; set => velocidadMax = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
