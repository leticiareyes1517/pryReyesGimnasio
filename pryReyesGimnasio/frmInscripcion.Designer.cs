namespace pryReyesGimnasio
{
    partial class frmInscripción
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
            lblNombre = new Label();
            lblEdad = new Label();
            chkEstudiante = new CheckBox();
            lblPlan = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblTurno = new Label();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            lblMeses = new Label();
            grpDatosPersonales = new GroupBox();
            txtMeses = new TextBox();
            grpPlan = new GroupBox();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            grpFormadePago = new GroupBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            chkCasillero = new CheckBox();
            grpDatosPersonales.SuspendLayout();
            grpPlan.SuspendLayout();
            grpFormadePago.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(184, 52);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(10, 55);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(22, 134);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 3;
            lblPlan.Text = "Plan";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 49);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(223, 49);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(169, 134);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "Turno";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(58, 131);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(100, 23);
            cboPlan.TabIndex = 7;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(209, 15);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(100, 23);
            cboTurno.TabIndex = 8;
            cboTurno.SelectedIndexChanged += cboTurno_SelectedIndexChanged;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(12, 175);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 9;
            lblMeses.Text = "Meses";
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(chkEstudiante);
            grpDatosPersonales.Location = new Point(12, 23);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(345, 87);
            grpDatosPersonales.TabIndex = 11;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(58, 172);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(47, 23);
            txtMeses.TabIndex = 12;
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Location = new Point(5, 116);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(352, 92);
            grpPlan.TabIndex = 13;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(168, 30);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 16;
            lblCuotas.Text = "Cuotas";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(218, 25);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(100, 23);
            cboCuotas.TabIndex = 17;
            // 
            // grpFormadePago
            // 
            grpFormadePago.Controls.Add(cboCuotas);
            grpFormadePago.Controls.Add(rbtTarjeta);
            grpFormadePago.Controls.Add(lblCuotas);
            grpFormadePago.Controls.Add(rbtEfectivo);
            grpFormadePago.Location = new Point(5, 224);
            grpFormadePago.Name = "grpFormadePago";
            grpFormadePago.Size = new Size(352, 66);
            grpFormadePago.TabIndex = 18;
            grpFormadePago.TabStop = false;
            grpFormadePago.Text = "Forma de Pago";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(17, 29);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(93, 28);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(184, 311);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(265, 311);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(132, 59);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(142, 19);
            chkCasillero.TabIndex = 0;
            chkCasillero.Text = "Casillero ($3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // frmInscripción
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 351);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtMeses);
            Controls.Add(lblMeses);
            Controls.Add(cboPlan);
            Controls.Add(lblTurno);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblPlan);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(grpDatosPersonales);
            Controls.Add(grpPlan);
            Controls.Add(grpFormadePago);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo -- Inscripción";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpFormadePago.ResumeLayout(false);
            grpFormadePago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private CheckBox chkEstudiante;
        private Label lblPlan;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblTurno;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private Label lblMeses;
        private GroupBox grpDatosPersonales;
        private TextBox txtMeses;
        private GroupBox grpPlan;
        private Label lblCuotas;
        private ComboBox cboCuotas;
        private GroupBox grpFormadePago;
        private CheckBox chkCasillero;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
