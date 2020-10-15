﻿namespace ProductosYPlanes.Presentacion
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdResponsable = new System.Windows.Forms.TextBox();
            this.lblIdResponsable = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResposable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdProyectos = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblIdProyecto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtAlcance);
            this.groupBox1.Controls.Add(this.lblAlcance);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtIdProducto);
            this.groupBox1.Controls.Add(this.txtIdResponsable);
            this.groupBox1.Controls.Add(this.lblIdResponsable);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.dgvProyectos);
            this.groupBox1.Controls.Add(this.txtIdProyectos);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(535, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 1);
            this.panel5.TabIndex = 19;
            // 
            // txtVersion
            // 
            this.txtVersion.BackColor = System.Drawing.SystemColors.Control;
            this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVersion.Location = new System.Drawing.Point(535, 37);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(6);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(135, 14);
            this.txtVersion.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(321, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 1);
            this.panel4.TabIndex = 16;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(322, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(94, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 1);
            this.panel2.TabIndex = 16;
            // 
            // txtAlcance
            // 
            this.txtAlcance.BackColor = System.Drawing.SystemColors.Control;
            this.txtAlcance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlcance.Location = new System.Drawing.Point(322, 75);
            this.txtAlcance.Margin = new System.Windows.Forms.Padding(6);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(135, 14);
            this.txtAlcance.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(94, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 1);
            this.panel1.TabIndex = 15;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProducto.Location = new System.Drawing.Point(93, 75);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(118, 14);
            this.txtIdProducto.TabIndex = 2;
            // 
            // txtIdResponsable
            // 
            this.txtIdResponsable.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdResponsable.Location = new System.Drawing.Point(322, 36);
            this.txtIdResponsable.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdResponsable.Name = "txtIdResponsable";
            this.txtIdResponsable.Size = new System.Drawing.Size(135, 14);
            this.txtIdResponsable.TabIndex = 3;
            // 
            // lblIdResponsable
            // 
            this.lblIdResponsable.AutoSize = true;
            this.lblIdResponsable.Location = new System.Drawing.Point(229, 37);
            this.lblIdResponsable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdResponsable.Name = "lblIdResponsable";
            this.lblIdResponsable.Size = new System.Drawing.Size(99, 15);
            this.lblIdResponsable.TabIndex = 10;
            this.lblIdResponsable.Text = "Id Responsable :";
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
            // txtIdProyectos
            // 
            this.txtIdProyectos.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProyectos.Location = new System.Drawing.Point(93, 37);
            this.txtIdProyectos.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdProyectos.Name = "txtIdProyectos";
            this.txtIdProyectos.ShortcutsEnabled = false;
            this.txtIdProyectos.Size = new System.Drawing.Size(118, 14);
            this.txtIdProyectos.TabIndex = 1;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdResponsable;
        private System.Windows.Forms.Label lblIdResponsable;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.TextBox txtIdProyectos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblIdProyecto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtVersion;
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
    }
}