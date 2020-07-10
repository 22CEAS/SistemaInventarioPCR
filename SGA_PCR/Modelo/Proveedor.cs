using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        private int idProveedor;
        private string ruc;
        private string razonSocial;
        private string abreviacion;
        private string direccion;
        private string telefono;
        private string fax;
        private string email;
        private string observacion;
        private string estado;

        public Proveedor()
        {

        }

        public Proveedor(int idProveedor, string ruc, string razonSocial, string abreviacion, string direccion, string telefono, string fax, string email, string observacion, string estado)
        {
            this.IdProveedor = idProveedor;
            this.Ruc = ruc;
            this.RazonSocial = razonSocial;
            this.Abreviacion = abreviacion;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Fax = fax;
            this.Email = email;
            this.Observacion = observacion;
            this.Estado = estado;
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Abreviacion { get => abreviacion; set => abreviacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
