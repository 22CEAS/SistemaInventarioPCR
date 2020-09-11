using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ingreso
    {
        private int idIngreso;
        private int idTipoIngreso;//Compra o arrendamiento
        private int idProveedor;
        private string ruc;
        private string razonSocial;
        private string factura;
        private string guia;
        private DateTime fechaIngreso;
        private string observacion;
        private int estado;
        private Usuario usuarioRegistro;
        private BindingList<IngresoDetalle> detalles;
        private BindingList<Memoria> memorias;
        private BindingList<Licencia> licencias;
        private BindingList<DiscoDuro> discos;

        public Ingreso()
        {
            Memorias = new BindingList<Memoria>();
            Detalles = new BindingList<IngresoDetalle>();
            Licencias = new BindingList<Licencia>();
            Discos = new BindingList<DiscoDuro>();
        }

        public int IdIngreso { get => idIngreso; set => idIngreso = value; }
        public int IdTipoIngreso { get => idTipoIngreso; set => idTipoIngreso = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Factura { get => factura; set => factura = value; }
        public string Guia { get => guia; set => guia = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public Usuario UsuarioRegistro { get => usuarioRegistro; set => usuarioRegistro = value; }
        public BindingList<IngresoDetalle> Detalles { get => detalles; set => detalles = value; }
        public BindingList<Memoria> Memorias { get => memorias; set => memorias = value; }
        public BindingList<Licencia> Licencias { get => licencias; set => licencias = value; }
        public BindingList<DiscoDuro> Discos { get => discos; set => discos = value; }
    }
}
