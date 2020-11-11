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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCicloPrueba));
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCaso = new System.Windows.Forms.ComboBox();
            this.lblCaso = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.cboTester = new System.Windows.Forms.ComboBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblTeste = new System.Windows.Forms.Label();
            this.dgvCiclo = new System.Windows.Forms.DataGridView();
            this.TituloCasoPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceptado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblActual = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(49, 23);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(34, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Plan: ";
            // 
            // cboPlan
            // 
            this.cboPlan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboPlan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(87, 20);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 21);
            this.cboPlan.TabIndex = 1;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(275, 23);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(86, 13);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Fecha de Inicio: ";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(11, 50);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(75, 13);
            this.lblResponsable.TabIndex = 6;
            this.lblResponsable.Text = "Responsable: ";
            // 
            // dtpInicio
            // 
            this.dtpInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(362, 23);
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
            this.groupBox1.Controls.Add(this.cboPlan);
            this.groupBox1.Controls.Add(this.lblPlan);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciclo de Prueba";
            // 
            // cboResponsable
            // 
            this.cboResponsable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboResponsable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(87, 47);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(121, 21);
            this.cboResponsable.TabIndex = 9;
            this.cboResponsable.SelectedIndexChanged += new System.EventHandler(this.cboResponsable_SelectedIndexChanged);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(281, 49);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(75, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fecha de Fin: ";
            // 
            // dtpFin
            // 
            this.dtpFin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(361, 49);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(95, 20);
            this.dtpFin.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.cboCaso);
            this.groupBox2.Controls.Add(this.lblCaso);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lblHoras);
            this.groupBox2.Controls.Add(this.cboTester);
            this.groupBox2.Controls.Add(this.txtHoras);
            this.groupBox2.Controls.Add(this.lblTeste);
            this.groupBox2.Location = new System.Drawing.Point(547, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(249, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 1);
            this.panel2.TabIndex = 18;
            // 
            // cboCaso
            // 
            this.cboCaso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboCaso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCaso.FormattingEnabled = true;
            this.cboCaso.Location = new System.Drawing.Point(94, 19);
            this.cboCaso.Name = "cboCaso";
            this.cboCaso.Size = new System.Drawing.Size(98, 21);
            this.cboCaso.TabIndex = 17;
            this.cboCaso.SelectedIndexChanged += new System.EventHandler(this.cboCaso_SelectedIndexChanged);
            // 
            // lblCaso
            // 
            this.lblCaso.AutoSize = true;
            this.lblCaso.Location = new System.Drawing.Point(6, 22);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(91, 13);
            this.lblCaso.TabIndex = 16;
            this.lblCaso.Text = "Caso De Prueba: ";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.BackgroundImage")));
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(257, 79);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(57, 31);
            this.btnQuitar.TabIndex = 15;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(208, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(249, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(40, 79);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(57, 31);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(208, 49);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(41, 13);
            this.lblHoras.TabIndex = 11;
            this.lblHoras.Text = "Horas: ";
            // 
            // cboTester
            // 
            this.cboTester.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboTester.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTester.FormattingEnabled = true;
            this.cboTester.Location = new System.Drawing.Point(94, 44);
            this.cboTester.Name = "cboTester";
            this.cboTester.Size = new System.Drawing.Size(98, 21);
            this.cboTester.TabIndex = 11;
            this.cboTester.SelectedIndexChanged += new System.EventHandler(this.cboTester_SelectedIndexChanged);
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.SystemColors.Control;
            this.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoras.Location = new System.Drawing.Point(250, 47);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(93, 13);
            this.txtHoras.TabIndex = 10;
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(48, 47);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(40, 13);
            this.lblTeste.TabIndex = 10;
            this.lblTeste.Text = "Tester:";
            // 
            // dgvCiclo
            // 
            this.dgvCiclo.AllowUserToAddRows = false;
            this.dgvCiclo.AllowUserToDeleteRows = false;
            this.dgvCiclo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TituloCasoPrueba,
            this.NombreTester,
            this.Horas,
            this.Fecha,
            this.Aceptado});
            this.dgvCiclo.Location = new System.Drawing.Point(12, 136);
            this.dgvCiclo.Name = "dgvCiclo";
            this.dgvCiclo.ReadOnly = true;
            this.dgvCiclo.RowHeadersWidth = 72;
            this.dgvCiclo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiclo.Size = new System.Drawing.Size(919, 230);
            this.dgvCiclo.TabIndex = 12;
            this.dgvCiclo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiclo_CellContentClick);
            // 
            // TituloCasoPrueba
            // 
            this.TituloCasoPrueba.DataPropertyName = "TituloCasoPrueba";
            this.TituloCasoPrueba.HeaderText = "Caso de Prueba";
            this.TituloCasoPrueba.MinimumWidth = 9;
            this.TituloCasoPrueba.Name = "TituloCasoPrueba";
            this.TituloCasoPrueba.ReadOnly = true;
            this.TituloCasoPrueba.Width = 175;
            // 
            // NombreTester
            // 
            this.NombreTester.DataPropertyName = "NombreTester";
            this.NombreTester.HeaderText = "Tester";
            this.NombreTester.MinimumWidth = 9;
            this.NombreTester.Name = "NombreTester";
            this.NombreTester.ReadOnly = true;
            this.NombreTester.Width = 175;
            // 
            // Horas
            // 
            this.Horas.DataPropertyName = "Horas";
            this.Horas.HeaderText = "Horas";
            this.Horas.MinimumWidth = 9;
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Width = 175;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 9;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 175;
            // 
            // Aceptado
            // 
            this.Aceptado.DataPropertyName = "Aceptado";
            this.Aceptado.HeaderText = "Aceptado";
            this.Aceptado.MinimumWidth = 9;
            this.Aceptado.Name = "Aceptado";
            this.Aceptado.ReadOnly = true;
            this.Aceptado.Width = 175;
            // 
            // btnCrear
            // 
            this.btnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrear.BackgroundImage")));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(12, 384);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(86, 39);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(845, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 39);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(171, 105);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(218, 13);
            this.lblActual.TabIndex = 15;
            this.lblActual.Text = "Texto para mostrar que ciclo esta agregando";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(105, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 39);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCicloPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 427);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvCiclo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloCasoPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aceptado;
        private System.Windows.Forms.Panel panel2;
    }
}