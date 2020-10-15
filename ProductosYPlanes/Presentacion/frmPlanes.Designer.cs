namespace ProductosYPlanes.Presentacion
{
    partial class frmPlanes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.IdPlanPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResposable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdPlan = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblIdPlan = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtResponsable);
            this.groupBox1.Controls.Add(this.lblResponsable);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtIdProyecto);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.dgvPlanes);
            this.groupBox1.Controls.Add(this.txtIdPlan);
            this.groupBox1.Controls.Add(this.lblProyecto);
            this.groupBox1.Controls.Add(this.lblIdPlan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(671, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes - Filtros de busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(346, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 1);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(347, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(97, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 1);
            this.panel2.TabIndex = 16;
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.SystemColors.Control;
            this.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponsable.Location = new System.Drawing.Point(347, 75);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(135, 14);
            this.txtResponsable.TabIndex = 4;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(241, 75);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(99, 15);
            this.lblResponsable.TabIndex = 12;
            this.lblResponsable.Text = "Id Responsable :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(97, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 1);
            this.panel1.TabIndex = 15;
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProyecto.Location = new System.Drawing.Point(96, 75);
            this.txtIdProyecto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(118, 14);
            this.txtIdProyecto.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(347, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 14);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(281, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre :";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(519, 36);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 61);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPlanPrueba,
            this.IdProyecto,
            this.Nombre,
            this.IdResposable,
            this.Descripcion});
            this.dgvPlanes.Location = new System.Drawing.Point(20, 115);
            this.dgvPlanes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.RowHeadersWidth = 72;
            this.dgvPlanes.Size = new System.Drawing.Size(634, 269);
            this.dgvPlanes.TabIndex = 6;
            this.dgvPlanes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellClick);
            this.dgvPlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellContentClick_1);
            // 
            // IdPlanPrueba
            // 
            this.IdPlanPrueba.HeaderText = "Id Plan";
            this.IdPlanPrueba.MinimumWidth = 9;
            this.IdPlanPrueba.Name = "IdPlanPrueba";
            this.IdPlanPrueba.ReadOnly = true;
            // 
            // IdProyecto
            // 
            this.IdProyecto.HeaderText = "Id proyecto";
            this.IdProyecto.MinimumWidth = 9;
            this.IdProyecto.Name = "IdProyecto";
            this.IdProyecto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 9;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IdResposable
            // 
            this.IdResposable.HeaderText = "Id Responsable";
            this.IdResposable.MinimumWidth = 9;
            this.IdResposable.Name = "IdResposable";
            this.IdResposable.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 9;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // txtIdPlan
            // 
            this.txtIdPlan.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPlan.Location = new System.Drawing.Point(96, 37);
            this.txtIdPlan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIdPlan.Name = "txtIdPlan";
            this.txtIdPlan.ShortcutsEnabled = false;
            this.txtIdPlan.Size = new System.Drawing.Size(118, 14);
            this.txtIdPlan.TabIndex = 1;
            this.txtIdPlan.TextChanged += new System.EventHandler(this.txtProyecto_TextChanged);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(12, 75);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(73, 15);
            this.lblProyecto.TabIndex = 3;
            this.lblProyecto.Text = "Id Proyecto :";
            this.lblProyecto.Click += new System.EventHandler(this.lblProyecto_Click);
            // 
            // lblIdPlan
            // 
            this.lblIdPlan.AutoSize = true;
            this.lblIdPlan.Location = new System.Drawing.Point(35, 36);
            this.lblIdPlan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdPlan.Name = "lblIdPlan";
            this.lblIdPlan.Size = new System.Drawing.Size(51, 15);
            this.lblIdPlan.TabIndex = 1;
            this.lblIdPlan.Text = "Id Plan :";
            this.lblIdPlan.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 446);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(555, 446);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 42);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(179, 446);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(344, 446);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 42);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmPlanes
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(721, 496);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmPlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.frmPlanes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblIdPlan;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdPlan;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlanPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResposable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}