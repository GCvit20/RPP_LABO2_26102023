namespace FabricaDeVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstVehiculos = new ListBox();
            txtTipoDeVehiculo = new Label();
            cmbTipo = new ComboBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            pcbFabrica = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 15);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(525, 424);
            lstVehiculos.TabIndex = 0;
            lstVehiculos.SelectedIndexChanged += lstVehiculos_SelectedIndexChanged;
            // 
            // txtTipoDeVehiculo
            // 
            txtTipoDeVehiculo.AutoSize = true;
            txtTipoDeVehiculo.Location = new Point(647, 29);
            txtTipoDeVehiculo.Name = "txtTipoDeVehiculo";
            txtTipoDeVehiculo.Size = new Size(94, 15);
            txtTipoDeVehiculo.TabIndex = 1;
            txtTipoDeVehiculo.Text = "Tipo de vehiculo";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(600, 60);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(180, 23);
            cmbTipo.TabIndex = 2;
            cmbTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(600, 266);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(188, 68);
            btnFabricar.TabIndex = 3;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(600, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 68);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pcbFabrica
            // 
            pcbFabrica.ErrorImage = null;
            pcbFabrica.Image = Properties.Resources.icons8_vehicles_64;
            pcbFabrica.InitialImage = null;
            pcbFabrica.Location = new Point(665, 129);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(64, 73);
            pcbFabrica.TabIndex = 5;
            pcbFabrica.TabStop = false;
            pcbFabrica.Click += pcbFabrica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbFabrica);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(cmbTipo);
            Controls.Add(txtTipoDeVehiculo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Fabrica de Vehiculos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label txtTipoDeVehiculo;
        private ComboBox cmbTipo;
        private Button btnFabricar;
        private Button btnEliminar;
        private PictureBox pcbFabrica;
    }
}