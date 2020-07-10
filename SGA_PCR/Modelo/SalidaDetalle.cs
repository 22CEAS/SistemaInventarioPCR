using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SalidaDetalle
    {
        private int idSalidaDet;
        private int idSalida;
        private LC equipo;
        private string caracteristicas;
        private string guiaSalida;
        private string motivoNoRecojo;
        private string observacion;
        private int estado;

        public SalidaDetalle()
        {
            this.Equipo = null;
        }

        public SalidaDetalle(int idSalidaDet, int idSalida, LC equipo, string caracteristicas, string guiaSalida, string motivoNoRecojo, string observacion, int estado)
        {
            this.IdSalidaDet = idSalidaDet;
            this.IdSalida = idSalida;
            this.Equipo = equipo;
            this.Caracteristicas = caracteristicas;
            this.GuiaSalida = guiaSalida;
            this.MotivoNoRecojo = motivoNoRecojo;
            this.Observacion = observacion;
            this.Estado = estado;
        }

        public int IdSalidaDet { get => idSalidaDet; set => idSalidaDet = value; }
        public int IdSalida { get => idSalida; set => idSalida = value; }
        public LC Equipo { get => equipo; set => equipo = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public string GuiaSalida { get => guiaSalida; set => guiaSalida = value; }
        public string MotivoNoRecojo { get => motivoNoRecojo; set => motivoNoRecojo = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
