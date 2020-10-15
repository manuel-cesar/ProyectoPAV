namespace ProductosYPlanes.Presentacion
{
    partial class frmCicloPrueba
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
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCaso = new System.Windows.Forms.ComboBox();
            this.lblCaso = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHoras = new System.Windows.Forms.Label();
            this.cboTester = new System.Windows.Forms.ComboBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblTeste = new System.Windows.Forms.Label();
            this.dgvCiclo = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblActual = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.id_plan_prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(12, 16);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(34, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Plan: ";
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(52, 16);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 21);
            this.cboPlan.TabIndex = 1;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(52, 43);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(100, 20);
            this.txtCiclo.TabIndex = 2;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(10, 43);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(36, 13);
            this.lblCiclo.TabIndex = 3;
            this.lblCiclo.Text = "Ciclo: ";
            this.lblCiclo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(202, 19);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(86, 13);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Fecha de Inicio: ";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(407, 32);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(75, 13);
            this.lblResponsable.TabIndex = 6;
            this.lblResponsable.Text = "Responsable: ";
            // 
            // dtpInicio
            // 
            this.dtpInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(294, 17);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(95, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboResponsable);
            this.groupBox1.Controls.Add(this.lblFin);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.lblResponsable);
            this.groupBox1.Controls.Add(this.lblCiclo);
            this.groupBox1.Controls.Add(this.txtCiclo);
            this.groupBox1.Controls.Add(this.cboPlan);
            this.groupBox1.Controls.Add(this.lblPlan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciclo de Prueba";
            // 
            // cboResponsable
            // 
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(488, 29);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(121, 21);
            this.cboResponsable.TabIndex = 9;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(202, 50);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(75, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fecha de Fin: ";
            // 
            // dtpFin
            // 
            this.dtpFin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(294, 44);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(95, 20);
            this.dtpFin.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboCaso);
            this.groupBox2.Controls.Add(this.lblCaso);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.lblHoras);
            this.groupBox2.Controls.Add(this.cboTester);
            this.groupBox2.Controls.Add(this.txtHoras);
            this.groupBox2.Controls.Add(this.lblTeste);
            this.groupBox2.Location = new System.Drawing.Point(647, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // cboCaso
            // 
            this.cboCaso.FormattingEnabled = true;
            this.cboCaso.Location = new System.Drawing.Point(103, 84);
            this.cboCaso.Name = "cboCaso";
            this.cboCaso.Size = new System.Drawing.Size(95, 21);
            this.cboCaso.TabIndex = 17;
            // 
            // lblCaso
            // 
            this.lblCaso.AutoSize = true;
            this.lblCaso.Location = new System.Drawing.Point(6, 92);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(91, 13);
            this.lblCaso.TabIndex = 16;
            this.lblCaso.Text = "Caso De Prueba: ";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(216, 49);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(57, 31);
            this.btnQuitar.TabIndex = 15;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(153, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(57, 31);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 58);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(52, 51);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(164, 19);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(41, 13);
            this.lblHoras.TabIndex = 11;
            this.lblHoras.Text = "Horas: ";
            this.lblHoras.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboTester
            // 
            this.cboTester.FormattingEnabled = true;
            this.cboTester.Location = new System.Drawing.Point(52, 19);
            this.cboTester.Name = "cboTester";
            this.cboTester.Size = new System.Drawing.Size(95, 21);
            this.cboTester.TabIndex = 11;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(211, 16);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(50, 20);
            this.txtHoras.TabIndex = 10;
            this.txtHoras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(6, 27);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(40, 13);
            this.lblTeste.TabIndex = 10;
            this.lblTeste.Text = "Tester:";
            // 
            // dgvCiclo
            // 
            this.dgvCiclo.AllowUserToAddRows = false;
            this.dgvCiclo.AllowUserToDeleteRows = false;
            this.dgvCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_plan_prueba,
            this.Ciclo,
            this.FechaInicio,
            this.FechaFin,
            this.Responsable,
            this.Detalle,
            this.Tester,
            this.Fecha,
            this.Horas});
            this.dgvCiclo.Location = new System.Drawing.Point(-1, 134);
            this.dgvCiclo.Name = "dgvCiclo";
            this.dgvCiclo.ReadOnly = true;
            this.dgvCiclo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiclo.Size = new System.Drawing.Size(921, 213);
            this.dgvCiclo.TabIndex = 12;
            this.dgvCiclo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiclo_CellContentClick);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 370);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(86, 53);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(843, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 53);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(392, 115);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(218, 13);
            this.lblActual.TabIndex = 15;
            this.lblActual.Text = "Texto para mostrar que ciclo esta agregando";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(134, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 53);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // id_plan_prueba
            // 
            this.id_plan_prueba.HeaderText = "Plan";
            this.id_plan_prueba.Name = "id_plan_prueba";
            this.id_plan_prueba.ReadOnly = true;
            // 
            // Ciclo
            // 
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Tester
            // 
            this.Tester.HeaderText = "Tester";
            this.Tester.Name = "Tester";
            this.Tester.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            // 
            // frmCicloPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 439);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvCiclo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCicloPrueba";
            this.Text = "frmCicloPrueba";
            this.Load += new System.EventHandler(this.frmCicloPrueba_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.ComboBox cboTester;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvCiclo;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cboCaso;
        private System.Windows.Forms.Label lblCaso;
        private System.Windows.Forms.Label lblActual;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan_prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
    }
}