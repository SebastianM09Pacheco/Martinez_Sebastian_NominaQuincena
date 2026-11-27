


using System.Drawing;
using System.Windows.Forms;

namespace Martinez_Sebastian_NominaQuincena
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmpleado = new TextBox();
            label5 = new Label();
            cmbCargo = new ComboBox();
            label6 = new Label();
            txtHoras = new TextBox();
            chkTransporte = new CheckBox();
            rdbFijo = new RadioButton();
            rdbTemporal = new RadioButton();
            btnRegistrar = new Button();
            btnMostrarResumen = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            IstNomina = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            lblNeto = new Label();
            lblEducciones = new Label();
            lblBruto = new Label();
            lblEmpleados = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Contrato:";
            // 
            // txtEmpleado
            // 
            txtEmpleado.ForeColor = SystemColors.InactiveCaption;
            txtEmpleado.Location = new Point(157, 55);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(284, 27);
            txtEmpleado.TabIndex = 2;
            txtEmpleado.Text = "ej: ana maria polo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 23);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            cmbCargo.ForeColor = SystemColors.InactiveCaption;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(99, 23);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(284, 28);
            cmbCargo.TabIndex = 9;
            cmbCargo.Text = "Seleccione el cargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 107);
            label6.Name = "label6";
            label6.Size = new Size(222, 20);
            label6.TabIndex = 10;
            label6.Text = "Horas trabajadas en la quincena";
            // 
            // txtHoras
            // 
            txtHoras.ForeColor = SystemColors.InactiveCaption;
            txtHoras.Location = new Point(45, 146);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(156, 27);
            txtHoras.TabIndex = 11;
            txtHoras.Text = "ej: 88";
            // 
            // chkTransporte
            // 
            chkTransporte.AutoSize = true;
            chkTransporte.Location = new Point(45, 207);
            chkTransporte.Name = "chkTransporte";
            chkTransporte.Size = new Size(233, 24);
            chkTransporte.TabIndex = 12;
            chkTransporte.Text = "Recibe incentivo de transporte";
            chkTransporte.UseVisualStyleBackColor = true;
            // 
            // rdbFijo
            // 
            rdbFijo.AutoSize = true;
            rdbFijo.Location = new Point(88, 134);
            rdbFijo.Name = "rdbFijo";
            rdbFijo.Size = new Size(54, 24);
            rdbFijo.TabIndex = 13;
            rdbFijo.TabStop = true;
            rdbFijo.Text = "Fijo";
            rdbFijo.UseVisualStyleBackColor = true;
            // 
            // rdbTemporal
            // 
            rdbTemporal.AutoSize = true;
            rdbTemporal.Location = new Point(186, 134);
            rdbTemporal.Name = "rdbTemporal";
            rdbTemporal.Size = new Size(93, 24);
            rdbTemporal.TabIndex = 14;
            rdbTemporal.TabStop = true;
            rdbTemporal.Text = "Temporal";
            rdbTemporal.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(31, 247);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(368, 63);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar Empleado";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnMostrarResumen
            // 
            btnMostrarResumen.Location = new Point(26, 592);
            btnMostrarResumen.Name = "btnMostrarResumen";
            btnMostrarResumen.Size = new Size(222, 49);
            btnMostrarResumen.TabIndex = 16;
            btnMostrarResumen.Text = "Mostrar Resumen";
            btnMostrarResumen.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(300, 592);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(225, 49);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(588, 592);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(272, 49);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // IstNomina
            // 
            IstNomina.FormattingEnabled = true;
            IstNomina.Location = new Point(6, 26);
            IstNomina.Name = "IstNomina";
            IstNomina.Size = new Size(386, 244);
            IstNomina.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmpleado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdbTemporal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbFijo);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 171);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmbCargo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtHoras);
            groupBox2.Controls.Add(chkTransporte);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Location = new Point(26, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 319);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de pagos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(IstNomina);
            groupBox3.Location = new Point(479, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(408, 291);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nomina Registrada";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblNeto);
            groupBox5.Controls.Add(lblEducciones);
            groupBox5.Controls.Add(lblBruto);
            groupBox5.Controls.Add(lblEmpleados);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(6, 40);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(379, 183);
            groupBox5.TabIndex = 34;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(88, 137);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(17, 20);
            lblNeto.TabIndex = 29;
            lblNeto.Text = "0";
            // 
            // lblEducciones
            // 
            lblEducciones.AutoSize = true;
            lblEducciones.Location = new Point(132, 94);
            lblEducciones.Name = "lblEducciones";
            lblEducciones.Size = new Size(17, 20);
            lblEducciones.TabIndex = 28;
            lblEducciones.Text = "0";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(94, 49);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(17, 20);
            lblBruto.TabIndex = 27;
            lblBruto.Text = "0";
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(177, 4);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(17, 20);
            lblEmpleados.TabIndex = 26;
            lblEmpleados.Text = "0";
            lblEmpleados.Click += lblEmpleados_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 137);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 25;
            label12.Text = "Total neto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 94);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 24;
            label11.Text = "Total Educciones:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 49);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 23;
            label10.Text = "Total Bruto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 4);
            label9.Name = "label9";
            label9.Size = new Size(168, 20);
            label9.TabIndex = 22;
            label9.Text = "Empleados Registrados:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(479, 338);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(408, 248);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resumen";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 649);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrarResumen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmpleado;
        private Label label5;
        private ComboBox cmbCargo;
        private Label label6;
        private TextBox txtHoras;
        private CheckBox chkTransporte;
        private RadioButton rdbFijo;
        private RadioButton rdbTemporal;
        private Button btnRegistrar;
        private Button btnMostrarResumen;
        private Button btnLimpiar;
        private Button btnSalir;
        private ListBox IstNomina;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Label lblNeto;
        private Label lblEducciones;
        private Label lblBruto;
        private Label lblEmpleados;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox groupBox4;
    }
}
