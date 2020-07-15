using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Alquiler
    {
        private int idAlquiler;
        private Cliente cliente;
        private DateTime fechaSalida;
        private DateTime fechaIniContrato;
        private DateTime fechaFinContrato;
        private string observacion;
        private int estado;
        private Usuario usuarioRegistro;
        private BindingList<AlquilerDetalle> detalles;

        public Alquiler()
        {
            this.IdAlquiler = 0;
            cliente = new Cliente();
            usuarioRegistro = new Usuario();
            detalles = new BindingList<AlquilerDetalle>();
        }

        public Alquiler(int idAlquiler, Cliente cliente, DateTime fechaSalida, DateTime fechaIniContrato, DateTime fechaFinContrato, string observacion, int estado, Usuario usuarioRegistro, BindingList<AlquilerDetalle> detalles)
        {
            this.IdAlquiler = idAlquiler;
            this.Cliente = cliente;
            this.FechaSalida = fechaSalida;
            this.FechaIniContrato = fechaIniContrato;
            this.FechaFinContrato = fechaFinContrato;
            this.Observacion = observacion;
            this.Estado = estado;
            this.UsuarioRegistro = usuarioRegistro;
            this.Detalles = detalles;
        }

        public int IdAlquiler { get => idAlquiler; set => idAlquiler = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public DateTime FechaIniContrato { get => fechaIniContrato; set => fechaIniContrato = value; }
        public DateTime FechaFinContrato { get => fechaFinContrato; set => fechaFinContrato = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public Usuario UsuarioRegistro { get => usuarioRegistro; set => usuarioRegistro = value; }
        public BindingList<AlquilerDetalle> Detalles { get => detalles; set => detalles = value; }


    }
}
