using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Video
    {
        private int idVideo;
        private string codigo;
        private int idModelo;
        private Modelo modelo;
        private int capacidad;
        private string tipo;
        private int cantidad;
        private string ubicacion;
        private string observacion;
        private int estado;
        public Video()
        {
            this.Modelo = null;
        }
        public Video(int idVideo, string codigo, int idModelo, Modelo modelo, int capacidad, string tipo, int cantidad, string ubicacion, string observacion, int estado)
        {
            this.IdVideo = idVideo;
            this.Codigo = codigo;
            this.IdModelo = idModelo;
            this.Modelo = modelo;
            this.Capacidad = capacidad;
            this.Tipo = tipo;
            this.Cantidad = cantidad;
            this.Ubicacion = ubicacion;
            this.Observacion = observacion;
            this.Estado = estado;
        }

        public int IdVideo { get => idVideo; set => idVideo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
