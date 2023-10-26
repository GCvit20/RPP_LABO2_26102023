using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_primer_parcial
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculo;

        private Fabrica()
        {
            this.vehiculo = new List<Vehiculo>();
        }

        public Fabrica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public List<Vehiculo> Vehiculos { get { return this.vehiculo; } }



        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculo.Count < fabrica.capacidad)
            {
                fabrica.vehiculo.Add(vehiculo);
            }

            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            for (int i = 0; i < fabrica.vehiculo.Count; i++)
            {
                if (fabrica.vehiculo[i].GetType() == vehiculo.GetType() && vehiculo.Equals(vehiculo))
                {
                    fabrica.vehiculo.RemoveAt(i);
                    break;
                }
            }
            return fabrica;
        }

    }
}
