using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Recuperatorio_primer_parcial.Vehiculo;

namespace Recuperatorio_primer_parcial
{
    public class Moto : Vehiculo
    {
        public Moto(EPropulsion propulsion) : base(propulsion) { }

        protected override string Tipo { get { return "Moto"; } }
    }
}
