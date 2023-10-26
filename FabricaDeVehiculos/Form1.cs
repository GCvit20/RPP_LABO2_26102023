using Recuperatorio_primer_parcial;
namespace FabricaDeVehiculos
{
    public partial class Form1 : Form
    {
        Fabrica fabrica;
        public Form1()
        {
            InitializeComponent();
            InicializarFabrica();
        }

        private void InicializarFabrica()
        {
            fabrica = new Fabrica(10);
            Camioneta camioneta = new Camioneta(Vehiculo.EPropulsion.Electrica, true);
        }

        private void Refrescar()
        {
            lstVehiculos.DataSource = null; // Asigna null al DataSource del listBox

            // Asigna la lista de vehículos de la fábrica al DataSource del listBox
            lstVehiculos.DataSource = fabrica.Vehiculos;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pcbFabrica_Click(object sender, EventArgs e)
        {

        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] options = new string[] { "Moto", "Automovil", "Camioneta" };

            foreach (string option in options)
            {
                this.cmbTipo.Items.Add(option);
            }
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {

            Vehiculo nuevoVehiculo = CrearVehiculo();

            fabrica += nuevoVehiculo;

            Refrescar();


        }

        private Vehiculo CrearVehiculo()
        {
            string tipo = cmbTipo.SelectedItem?.ToString();

            switch (tipo)
            {
                case "Moto":
                    return new Moto(Vehiculo.EPropulsion.Combustion);
                case "Camioneta":
                    return new Camioneta(Vehiculo.EPropulsion.Combustion, true);
                default:
                    return new Automovil();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedItem != null)
            {
                Vehiculo vehiculoSeleccionado = (Vehiculo)lstVehiculos.SelectedItem;

                fabrica -= vehiculoSeleccionado;

                Refrescar();
            }
        }
    }
}