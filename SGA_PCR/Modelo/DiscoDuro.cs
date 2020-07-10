using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DiscoDuro
    {
        private int idDisco;
        private string codigo;
        private int idModelo;
        private Modelo modelo;
        private double tamano;
        private int capacidad;
        private int cantidad;
        private string ubicacion;
        private string observacion;
        private string _estado;

        public DiscoDuro()
        {
            this.Modelo = null;
        }

        public DiscoDuro(int idDisco, string codigo, int idModelo, Modelo modelo, double tamano, int capacidad, int cantidad, string ubicacion, string observacion, string estado)
        {
            this.IdDisco = idDisco;
            this.Codigo = codigo;
            this.IdModelo = idModelo;
            this.Modelo = modelo;
            this.Tamano = tamano;
            this.Capacidad = capacidad;
            this.Cantidad = cantidad;
            this.Ubicacion = ubicacion;
            this.Observacion = observacion;
            Estado = estado;
        }

        public int IdDisco { get => idDisco; set => idDisco = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public double Tamano { get => tamano; set => tamano = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Estado { get => _estado; set => _estado = value; }
    }
}
