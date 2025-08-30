namespace Datos.Aleatorios
{
    partial class frmDatosAleatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            lblFecha = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            radMasculino = new RadioButton();
            radFemenino = new RadioButton();
            label1 = new Label();
            txtSueld = new Label();
            cmbGrupo = new ComboBox();
            chkSeguroMedico = new CheckBox();
            btnGenerar = new Button();
            txtSueldo = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Datos del empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 48);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(81, 41);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 123);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(81, 116);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(276, 27);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // radMasculino
            // 
            radMasculino.AutoSize = true;
            radMasculino.Location = new Point(81, 165);
            radMasculino.Name = "radMasculino";
            radMasculino.Size = new Size(97, 24);
            radMasculino.TabIndex = 7;
            radMasculino.TabStop = true;
            radMasculino.Text = "Masculino";
            radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            radFemenino.AutoSize = true;
            radFemenino.Location = new Point(81, 195);
            radFemenino.Name = "radFemenino";
            radFemenino.Size = new Size(95, 24);
            radFemenino.TabIndex = 8;
            radFemenino.TabStop = true;
            radFemenino.Text = "Femenino";
            radFemenino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 232);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "Grupo";
            // 
            // txtSueld
            // 
            txtSueld.AutoSize = true;
            txtSueld.Location = new Point(12, 274);
            txtSueld.Name = "txtSueld";
            txtSueld.Size = new Size(55, 20);
            txtSueld.TabIndex = 10;
            txtSueld.Text = "Sueldo";
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(81, 229);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(151, 28);
            cmbGrupo.TabIndex = 11;
            // 
            // chkSeguroMedico
            // 
            chkSeguroMedico.AutoSize = true;
            chkSeguroMedico.Location = new Point(81, 309);
            chkSeguroMedico.Name = "chkSeguroMedico";
            chkSeguroMedico.Size = new Size(132, 24);
            chkSeguroMedico.TabIndex = 12;
            chkSeguroMedico.Text = "Seguro médico";
            chkSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(286, 409);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(199, 29);
            btnGenerar.TabIndex = 13;
            btnGenerar.Text = "Generar datos aleatorios";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(81, 271);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(151, 27);
            txtSueldo.TabIndex = 14;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSueldo);
            Controls.Add(btnGenerar);
            Controls.Add(chkSeguroMedico);
            Controls.Add(cmbGrupo);
            Controls.Add(txtSueld);
            Controls.Add(label1);
            Controls.Add(radFemenino);
            Controls.Add(radMasculino);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFecha);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmDatosAleatorios";
            Text = "Empleado con datos aleatorios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private Label lblFecha;
        private DateTimePicker dtpFechaNacimiento;
        private RadioButton radMasculino;
        private RadioButton radFemenino;
        private Label label1;
        private Label txtSueld;
        private ComboBox cmbGrupo;
        private CheckBox chkSeguroMedico;
        private Button btnGenerar;
        private TextBox txtSueldo;
    }
}