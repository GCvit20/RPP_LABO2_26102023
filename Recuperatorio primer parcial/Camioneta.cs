using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_primer_parcial
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        protected override string Tipo { get { return "Camioneta"; } }

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GetInfo());
            sb.AppendLine($"con cabina simple: {this.cabinaSimple}");
            
            return sb.ToString();
        }
    }
}
