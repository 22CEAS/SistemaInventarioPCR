using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private BindingList<Licencia> licencias;
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
            this.Modelo = new Modelo();
            this.Procesador = new Procesador();
            this.Video = new Video();
            this.Discos = new BindingList<DiscoDuro>();
            this.Memorias = new BindingList<Memoria>();
            this.Licencias = new BindingList<Licencia>();

        }

        public LC(int idLC, string codigo, Modelo modelo, string descripcion, double tamanoPantalla, Procesador procesador, Video video, BindingList<DiscoDuro> discos, BindingList<Memoria> memorias, BindingList<Licencia> licencias, string partNumber, string serieFabrica, int garantia, DateTime fecInicioSeguro, DateTime fecFinSeguro, string ubicacion, string observacion, int estado)
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
        public string PartNumber { get => partNumber; set => partNumber = value; }
        public string SerieFabrica { get => serieFabrica; set => serieFabrica = value; }
        public int Garantia { get => garantia; set => garantia = value; }
        public DateTime FecInicioSeguro { get => fecInicioSeguro; set => fecInicioSeguro = value; }
        public DateTime FecFinSeguro { get => fecFinSeguro; set => fecFinSeguro = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public BindingList<Licencia> Licencias { get => licencias; set => licencias = value; }

        public void SetDisco(DataTable data) 
        {
            int rec = 0;
            while (rec < data.Rows.Count)
            {
                DiscoDuro disco = new DiscoDuro();
                disco.IdDisco = Convert.ToInt32(data.Rows[rec]["idDisco"].ToString());
                disco.Tipo.NombreModelo = data.Rows[rec]["tamanoDisco"].ToString();
                disco.Tamano = Convert.ToDouble(data.Rows[rec]["idDisco"].ToString());
                disco.Capacidad = Convert.ToInt32(data.Rows[rec]["capacidadDisco"].ToString());
                disco.Cantidad = Convert.ToInt32(data.Rows[rec]["cantidadDiscoLC"].ToString());
                this.Discos.Add(disco);
                rec++;
            }
        }

        public void SetMemoria(DataTable data)
        {
            int rec = 0;
            while (rec < data.Rows.Count)
            {
                Memoria memoria = new Memoria();
                memoria.IdMemoria = Convert.ToInt32(data.Rows[rec]["idMemoria"].ToString());
                memoria.Modelo.NombreModelo = data.Rows[rec]["tipoMemoria"].ToString();
                memoria.Capacidad = Convert.ToInt32(data.Rows[rec]["capacidadMemoria"].ToString());
                memoria.Cantidad = Convert.ToInt32(data.Rows[rec]["cantidadMemoriaLC"].ToString());
                this.Memorias.Add(memoria);
                rec++;
            }
        }

        public void SetLicencia(DataTable data)
        {
            int rec = 0;
            while (rec < data.Rows.Count)
            {
                Licencia licencia = new Licencia();
                licencia.IdLicencia = Convert.ToInt32(data.Rows[rec]["idLicencia"].ToString());
                licencia.IdCategoria = Convert.ToInt32(data.Rows[rec]["idCategoria"].ToString());
                licencia.Categoria = data.Rows[rec]["categoria"].ToString();
                licencia.Modelo.IdMarca = Convert.ToInt32(data.Rows[rec]["idMarca"].ToString());
                licencia.Modelo.NombreMarca = data.Rows[rec]["marca"].ToString();
                licencia.Modelo.IdModelo = Convert.ToInt32(data.Rows[rec]["idModelo"].ToString());
                licencia.Modelo.NombreModelo = data.Rows[rec]["version"].ToString();
                licencia.Clave = data.Rows[rec]["clave"].ToString();
                licencia.Ubicacion = data.Rows[rec]["ubicacion"].ToString();
                this.Licencias.Add(licencia);
                rec++;
            }
        }
    }
}
