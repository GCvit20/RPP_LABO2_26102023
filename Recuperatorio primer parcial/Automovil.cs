using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_primer_parcial
{
    public class Automovil : Vehiculo
    {
        
        public Automovil() : base(Automovil.EPropulsion.Hibrida){ }

        protected override string Tipo { get { return "Automovil"; } }
    }
}
