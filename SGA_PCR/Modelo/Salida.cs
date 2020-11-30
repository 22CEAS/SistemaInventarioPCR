using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Salida
    {
        private int idSalida;
        private int idCliente;
        private int idSucursal;
        private Cliente cliente;
        private BindingList<SalidaDetalle> detalles;
        private int idPedido;
        private DateTime fechaSalida;
        private DateTime fecInicioContrato;
        private DateTime fecFinContrato;
        private string observacion;
        private int estado;

        public Salida()
        {
            this.Cliente = new Cliente();
            this.Detalles = new BindingList<SalidaDetalle>();

        }

        public Salida(int idSalida, int idCliente, int idSucursal, Cliente cliente, BindingList<SalidaDetalle> detalles, int idPedido, DateTime fechaSalida, DateTime fecInicioContrato, DateTime fecFinContrato, string observacion, int estado)
        {
            this.IdSalida = idSalida;
            this.IdCliente = idCliente;
            this.IdSucursal = idSucursal;
            this.Cliente = cliente;
            this.Detalles = detalles;
            this.IdPedido = idPedido;
            this.FechaSalida = fechaSalida;
            this.FecInicioContrato = fecInicioContrato;
            this.FecFinContrato = fecFinContrato;
            this.Observacion = observacion;
            this.Estado = estado;
        }

        public int IdSalida { get => idSalida; set => idSalida = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public BindingList<SalidaDetalle> Detalles { get => detalles; set => detalles = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public DateTime FecInicioContrato { get => fecInicioContrato; set => fecInicioContrato = value; }
        public DateTime FecFinContrato { get => fecFinContrato; set => fecFinContrato = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
