namespace ProductosYPlanes.Presentacion
{
    partial class frmProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyectos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResposable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblIdProyecto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIdResp = new System.Windows.Forms.Label();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtIdProyectos = new System.Windows.Forms.TextBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.txtResponsable);
            this.groupBox1.Controls.Add(this.txtIdProyectos);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.txtAlcance);
            this.groupBox1.Controls.Add(this.lblIdResp);
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.lblAlcance);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.dgvProyectos);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.lblIdProyecto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(825, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proyectos - Filtros de busqueda";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(472, 38);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(54, 15);
            this.lblVersion.TabIndex = 18;
            this.lblVersion.Text = "Version :";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(268, 75);
            this.lblAlcance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(56, 15);
            this.lblAlcance.TabIndex = 12;
            this.lblAlcance.Text = "Alcance :";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(689, 36);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 61);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProyectos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProyecto,
            this.IdProducto,
            this.IdResposable,
            this.Alcance,
            this.Version,
            this.Descripcion});
            this.dgvProyectos.Location = new System.Drawing.Point(20, 115);
            this.dgvProyectos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.ReadOnly = true;
            this.dgvProyectos.RowHeadersWidth = 72;
            this.dgvProyectos.Size = new System.Drawing.Size(791, 269);
            this.dgvProyectos.TabIndex = 6;
            this.dgvProyectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellClick);
            // 
            // IdProyecto
            // 
            this.IdProyecto.HeaderText = "Id Proyecto";
            this.IdProyecto.MinimumWidth = 9;
            this.IdProyecto.Name = "IdProyecto";
            this.IdProyecto.ReadOnly = true;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.MinimumWidth = 9;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // IdResposable
            // 
            this.IdResposable.HeaderText = "Id Responsable";
            this.IdResposable.MinimumWidth = 9;
            this.IdResposable.Name = "IdResposable";
            this.IdResposable.ReadOnly = true;
            // 
            // Alcance
            // 
            this.Alcance.HeaderText = "Alcance";
            this.Alcance.MinimumWidth = 9;
            this.Alcance.Name = "Alcance";
            this.Alcance.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.HeaderText = "Version";
            this.Version.MinimumWidth = 9;
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 9;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(21, 75);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(75, 15);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Id Producto :";
            // 
            // lblIdProyecto
            // 
            this.lblIdProyecto.AutoSize = true;
            this.lblIdProyecto.Location = new System.Drawing.Point(22, 37);
            this.lblIdProyecto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdProyecto.Name = "lblIdProyecto";
            this.lblIdProyecto.Size = new System.Drawing.Size(73, 15);
            this.lblIdProyecto.TabIndex = 1;
            this.lblIdProyecto.Text = "Id Proyecto :";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(11, 421);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(145, 421);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 43);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(279, 421);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 43);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(700, 421);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 43);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIdResp
            // 
            this.lblIdResp.AutoSize = true;
            this.lblIdResp.Location = new System.Drawing.Point(235, 39);
            this.lblIdResp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdResp.Name = "lblIdResp";
            this.lblIdResp.Size = new System.Drawing.Size(91, 15);
            this.lblIdResp.TabIndex = 22;
            this.lblIdResp.Text = "Id responsable:";
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(335, 74);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(121, 21);
            this.txtAlcance.TabIndex = 23;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(535, 38);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(121, 21);
            this.txtVersion.TabIndex = 24;
            // 
            // txtIdProyectos
            // 
            this.txtIdProyectos.Location = new System.Drawing.Point(105, 37);
            this.txtIdProyectos.Name = "txtIdProyectos";
            this.txtIdProyectos.Size = new System.Drawing.Size(121, 21);
            this.txtIdProyectos.TabIndex = 25;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(335, 37);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(121, 21);
            this.txtResponsable.TabIndex = 26;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(105, 74);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(121, 21);
            this.txtProducto.TabIndex = 27;
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 476);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProyectos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblIdProyecto;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResposable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alcance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdProyectos;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label lblIdResp;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtResponsable;
    }
}