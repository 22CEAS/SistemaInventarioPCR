using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LC
    {
        private int idLC;
        private string codigo;
        private Modelo modelo;
        private string descripcion;
        private double tamanoPantalla;
        private Procesador procesador;
        private Video video;
        private BindingList<DiscoDuro> discos;
        private BindingList<Memoria> memorias;
        private Licencia windows;
        private Licencia office;
        private Licencia antivirus;
        private string partNumber;
        private string serieFabrica;
        private int garantia;
        private DateTime fecInicioSeguro;
        private DateTime fecFinSeguro;
        private string ubicacion;
        private string observacion;
        private int estado;


        public LC()
        {
            this.Modelo = null;
            this.Procesador = null;
            this.Video = null;
            this.Discos = new BindingList<DiscoDuro>();
            this.Memorias = new BindingList<Memoria>();
            this.Windows = null;
            this.Office = null;
            this.Antivirus = null;

        }

        public LC(int idLC, string codigo, Modelo modelo, string descripcion, double tamanoPantalla, Procesador procesador, Video video, BindingList<DiscoDuro> discos, BindingList<Memoria> memorias, Licencia windows, Licencia office, Licencia antivirus, string partNumber, string serieFabrica, int garantia, DateTime fecInicioSeguro, DateTime fecFinSeguro, string ubicacion, string observacion, int estado)
        {
            this.IdLC = idLC;
            this.Codigo = codigo;
            this.Modelo = modelo;
            this.Descripcion = descripcion;
            this.TamanoPantalla = tamanoPantalla;
            this.Procesador = procesador;
            this.Video = video;
            this.Discos = discos;
            this.Memorias = memorias;
            this.Windows = windows;
            this.Office = office;
            this.Antivirus = antivirus;
            this.PartNumber = partNumber;
            this.SerieFabrica = serieFabrica;
            this.Garantia = garantia;
            this.FecInicioSeguro = fecInicioSeguro;
            this.FecFinSeguro = fecFinSeguro;
            this.Ubicacion = ubicacion;
            this.Observacion = observacion;
            this.Estado = estado;
        }

        public int IdLC { get => idLC; set => idLC = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double TamanoPantalla { get => tamanoPantalla; set => tamanoPantalla = value; }
        public Procesador Procesador { get => procesador; set => procesador = value; }
        public Video Video { get => video; set => video = value; }
        public BindingList<DiscoDuro> Discos { get => discos; set => discos = value; }
        public BindingList<Memoria> Memorias { get => memorias; set => memorias = value; }
        public Licencia Windows { get => windows; set => windows = value; }
        public Licencia Office { get => office; set => office = value; }
        public Licencia Antivirus { get => antivirus; set => antivirus = value; }
        public string PartNumber { get => partNumber; set => partNumber = value; }
        public string SerieFabrica { get => serieFabrica; set => serieFabrica = value; }
        public int Garantia { get => garantia; set => garantia = value; }
        public DateTime FecInicioSeguro { get => fecInicioSeguro; set => fecInicioSeguro = value; }
        public DateTime FecFinSeguro { get => fecFinSeguro; set => fecFinSeguro = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
