using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RenovacionProductosAuxiliar
    {
        private int idLC;
        private string codigo;
        private string codigoAntiguo;
        private string marcaLC;
        private string nombreModeloLC;
        private int idSalidaDetalle;
        private int idSucursal;
        private DateTime _fecIniContrato;
        private DateTime _fecFinContrato;
        private bool seleccion;

        public RenovacionProductosAuxiliar()
        {

        }

        public int IdLC { get => idLC; set => idLC = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string MarcaLC { get => marcaLC; set => marcaLC = value; }
        public string NombreModeloLC { get => nombreModeloLC; set => nombreModeloLC = value; }
        public int IdSalidaDetalle { get => idSalidaDetalle; set => idSalidaDetalle = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public DateTime fecIniContrato { get => _fecIniContrato; set => _fecIniContrato = value; }
        public DateTime fecFinContrato { get => _fecFinContrato; set => _fecFinContrato = value; }
        public bool Seleccion { get => seleccion; set => seleccion = value; }
        public string CodigoAntiguo { get => codigoAntiguo; set => codigoAntiguo = value; }
    }
}
