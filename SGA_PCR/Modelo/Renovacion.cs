using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Renovacion
    {
        private int idSalidaDetalle;
        private int idSucursal;
        private int idLC;
        private string codigoLC;
        private string marcaLC;
        private string modeloLC;
        private DateTime fechaIniContrato;
        private DateTime fechaFinContrato;
        private string observacion;
        
        public int IdSalidaDetalle { get => idSalidaDetalle; set => idSalidaDetalle = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int IdLC { get => idLC; set => idLC = value; }
        public string CodigoLC { get => codigoLC; set => codigoLC = value; }
        public string MarcaLC { get => marcaLC; set => marcaLC = value; }
        public string ModeloLC { get => modeloLC; set => modeloLC = value; }
        public DateTime FechaIniContrato { get => fechaIniContrato; set => fechaIniContrato = value; }
        public DateTime FechaFinContrato { get => fechaFinContrato; set => fechaFinContrato = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
