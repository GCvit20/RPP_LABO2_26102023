namespace Recuperatorio_primer_parcial
{
    public abstract class Vehiculo
    {
        public enum EPropulsion { Combustion, Hibrida, Electrica };
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public EPropulsion Propulsion { get { return this.propulsion; } }
        protected abstract string Tipo { get; }

        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
            this.numeroDeChasis = Guid.NewGuid();
            this.esAWD = false;

        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) : this(propulsion)
        {
            this.esAWD = esAWD;
        }

        /// <summary>
        /// Este metodo devuelve un string con todos los datos de un vehiculo
        /// </summary>
        /// <returns>Retorna un string</returns>

        protected virtual string GetInfo()
        {
            string resultado = String.Format($"{this.Tipo} con propulsión a {this.Propulsion}, {this.esAWD} es AWD, numero de chasis {this.numeroDeChasis}.");
            return resultado;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Vehiculo && ((Vehiculo)obj).numeroDeChasis == this.numeroDeChasis;
        }
    }
}