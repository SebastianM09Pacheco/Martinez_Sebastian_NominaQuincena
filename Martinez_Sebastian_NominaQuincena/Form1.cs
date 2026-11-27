using System;
using System.Windows.Forms;

namespace Martinez_Sebastian_NominaQuincena
{
    public partial class Form1 : Form
    {
        private const int HORAS_NORMALES = 88;
        private const decimal FACTOR_EXTRA = 1.35m;
        private const decimal INCENTIVO_TRANSPORTE = 1500m;
        private const decimal AFP = 0.0287m;
        private const decimal SFS = 0.0304m;

        private int cantidadEmpleados = 0;
        private decimal totalBruto = 0;
        private decimal totalDeducciones = 0;
        private decimal totalNeto = 0;

        public Form1()
        {
            InitializeComponent();

            btnMostrarResumen.Click += btnMostrarResumen_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCargo.Items.Clear();
            cmbCargo.Items.Add("Auxiliar");
            cmbCargo.Items.Add("Técnico");
            cmbCargo.Items.Add("Supervisor");
            cmbCargo.Items.Add("Gerente");

            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.SelectedIndex = -1;

            txtEmpleado.Text = "";
            txtHoras.Text = "";

            ActualizarResumen();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtEmpleado.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del empleado.");
                txtEmpleado.Focus();
                return;
            }

            if (!rdbFijo.Checked && !rdbTemporal.Checked)
            {
                MessageBox.Show("Seleccione el tipo de contrato.");
                return;
            }

            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el cargo del empleado.");
                cmbCargo.Focus();
                return;
            }

            int horas;

            if (!int.TryParse(txtHoras.Text, out horas))
            {
                MessageBox.Show("Ingrese las horas como un número entero.");
                txtHoras.Focus();
                return;
            }

            if (horas < 1 || horas > 120)
            {
                MessageBox.Show("Las horas deben estar entre 1 y 120.");
                txtHoras.Focus();
                return;
            }

            decimal tarifa = 0;

            switch (cmbCargo.SelectedItem.ToString())
            {
                case "Auxiliar":
                    tarifa = 180;
                    break;

                case "Técnico":
                    tarifa = 250;
                    break;

                case "Supervisor":
                    tarifa = 350;
                    break;

                case "Gerente":
                    tarifa = 500;
                    break;
            }

            int horasRegulares;
            int horasExtra;

            if (horas > HORAS_NORMALES)
            {
                horasRegulares = HORAS_NORMALES;
                horasExtra = horas - HORAS_NORMALES;
            }
            else
            {
                horasRegulares = horas;
                horasExtra = 0;
            }

            decimal salarioRegular = horasRegulares * tarifa;
            decimal salarioExtra = horasExtra * tarifa * FACTOR_EXTRA;

            decimal incentivo = 0;

            if (chkTransporte.Checked)
            {
                incentivo = INCENTIVO_TRANSPORTE;
            }

            decimal bruto = salarioRegular + salarioExtra + incentivo;

            decimal deducciones = 0;

            if (rdbFijo.Checked)
            {
                deducciones =
                    (salarioRegular + salarioExtra) * AFP +
                    (salarioRegular + salarioExtra) * SFS;
            }

            decimal neto = bruto - deducciones;

            IstNomina.Items.Add(
                nombre + " - " +
                cmbCargo.SelectedItem.ToString() +
                " - RD$ " + neto.ToString("N2")
            );

            cantidadEmpleados++;
            totalBruto += bruto;
            totalDeducciones += deducciones;
            totalNeto += neto;

            ActualizarResumen();

            txtEmpleado.Clear();
            txtHoras.Clear();
            cmbCargo.SelectedIndex = -1;
            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;
            chkTransporte.Checked = false;

            txtEmpleado.Focus();
        }

        private void ActualizarResumen()
        {
            lblEmpleados.Text = cantidadEmpleados.ToString();
            lblBruto.Text = "RD$ " + totalBruto.ToString("N2");
            lblEducciones.Text = "RD$ " + totalDeducciones.ToString("N2");
            lblNeto.Text = "RD$ " + totalNeto.ToString("N2");
        }

        private void btnMostrarResumen_Click(object sender, EventArgs e)
        {
            if (cantidadEmpleados == 0)
            {
                MessageBox.Show("No hay empleados registrados.");
                return;
            }

            MessageBox.Show(
                "RESUMEN DE NÓMINA\n\n" +
                "Empleados registrados: " + cantidadEmpleados + "\n" +
                "Total bruto: RD$ " + totalBruto.ToString("N2") + "\n" +
                "Total deducciones: RD$ " + totalDeducciones.ToString("N2") + "\n" +
                "Total neto: RD$ " + totalNeto.ToString("N2"),
                "Resumen de nómina"
            );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtHoras.Clear();

            cmbCargo.SelectedIndex = -1;

            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;
            chkTransporte.Checked = false;

            IstNomina.Items.Clear();

            cantidadEmpleados = 0;
            totalBruto = 0;
            totalDeducciones = 0;
            totalNeto = 0;

            ActualizarResumen();

            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}