using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Memoria
    {
        private int idMemoria;
        private string codigo;
        private int idModelo;
        private Modelo modelo;
        private double busFrecuencia;
        private int capacidad;
        private string tipo;
        private int cantidad;
        private string ubicacion;
        private int estado;

        public int IdMemoria { get => idMemoria; set => idMemoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public double BusFrecuencia { get => busFrecuencia; set => busFrecuencia = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }

        public Memoria(int idMemoria, string codigo, int idModelo, Modelo modelo, double busFrecuencia, int capacidad, string tipo, int cantidad, string ubicacion, int estado)
        {
            this.IdMemoria = idMemoria;
            this.Codigo = codigo;
            this.IdModelo = idModelo;
            this.Modelo = modelo;
            this.BusFrecuencia = busFrecuencia;
            this.Capacidad = capacidad;
            this.Tipo = tipo;
            this.Cantidad = cantidad;
            this.Ubicacion = ubicacion;
            this.Estado = estado;
        }

        public Memoria()
        {
            this.Modelo = null;
        }

}
