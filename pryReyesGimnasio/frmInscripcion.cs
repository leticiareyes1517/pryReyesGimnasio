namespace pryReyesGimnasio
{
    public partial class frmInscripción : Form
    {
        private const decimal precioMusculación = 15000;
        private const decimal precioFuncional = 18000;
        private const decimal precioNatación = 22000;
        private const int edadMinima = 14;
        private const decimal precioCasillero = 3000;
        private const decimal descuentoEstudiante = 0.15m;
        private const decimal descuentomenor = 0.25m;
        private const decimal descuentomayor = 0.30m;
        private const decimal recargoEfectivo = 0.10m;
        private const decimal recargo3cuotas = 0.10m;
        private const decimal recargo6cuotas = 0.20m;

        public frmInscripción()
        {
            InitializeComponent();

            // Conexión de eventos por código (no hace falta hacer doble clic)
         
            btnLimpiar.Click += btnLimpiar_Click;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;

            cboCuotas.Enabled = false;
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboCuotas.Enabled = rbtTarjeta.Checked;
            if (!rbtTarjeta.Checked) cboCuotas.SelectedIndex = -1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtNombre.Focus();
                return;
            }
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < edadMinima)
            {
                MessageBox.Show($"Ingrese una edad válida (mínimo {edadMinima} años).");
                txtEdad.Focus();
                return;
            }
            if (cboPlan.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un plan.");
                cboPlan.Focus();
                return;
            }
            if (cboTurno.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un turno.");
                cboTurno.Focus();
                return;
            }
            if (!int.TryParse(txtMeses.Text, out int meses) || meses <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de meses válida.");
                txtMeses.Focus();
                return;
            }
            if (!rbtEfectivo.Checked && !rbtTarjeta.Checked)
            {
                MessageBox.Show("Seleccione la forma de pago.");
                return;
            }

            // Precio del plan
            decimal precio = cboPlan.SelectedIndex switch
            {
                0 => precioMusculación,
                1 => precioFuncional,
                2 => precioNatación,
                _ => 0
            };

            // Descuento (el mayor que corresponda)
            decimal descuento = 0;
            if (chkEstudiante.Checked) descuento = descuentoEstudiante;
            if (edad < 18) descuento = Math.Max(descuento, descuentomenor);
            if (edad >= 60) descuento = Math.Max(descuento, descuentomayor);

            decimal mensual = precio * (1 - descuento);
            if (chkCasillero.Checked) mensual += precioCasillero;
            decimal subtotal = mensual * meses;

            // Forma de pago
            decimal recargo = 0;
            int cuotas = 1;
            if (rbtEfectivo.Checked)
            {
                recargo = recargoEfectivo;
            }
            else
            {
                if (!int.TryParse(cboCuotas.Text, out cuotas))
                {
                    MessageBox.Show("Seleccione la cantidad de cuotas.");
                    cboCuotas.Focus();
                    return;
                }
                if (cuotas == 3) recargo = recargo3cuotas;
                else if (cuotas == 6) recargo = recargo6cuotas;
            }

            decimal total = subtotal * (1 + recargo);

            MessageBox.Show(
                $"Socio: {txtNombre.Text}\n" +
                $"Plan: {cboPlan.Text} - Turno: {cboTurno.Text}\n" +
                $"Meses: {meses}\n" +
                $"Descuento: {descuento:P0}\n" +
                $"Recargo: {recargo:P0}\n" +
                $"TOTAL: {total:C2}\n" +
                $"{cuotas} cuota(s) de {total / cuotas:C2}",
                "Gimnasio Siglo");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();
            cboPlan.SelectedIndex = -1;
            cboTurno.SelectedIndex = -1;
            cboCuotas.SelectedIndex = -1;
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = false;
            txtNombre.Focus();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

        }
    }
}