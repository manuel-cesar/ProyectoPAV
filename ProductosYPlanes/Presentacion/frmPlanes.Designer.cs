namespace ActualizarUsuarios.Presentacion
{
    partial class frmUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblIdPlan = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.IdPlanPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResposable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblResponsable);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtPlan);
            this.groupBox1.Controls.Add(this.cboProyecto);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblProyecto);
            this.groupBox1.Controls.Add(this.lblIdPlan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(509, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 42);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPlanPrueba,
            this.IdProyecto,
            this.Nombre,
            this.IdResposable,
            this.Descripcion,
            this.Borrado});
            this.dataGridView1.Location = new System.Drawing.Point(6, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 295);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(6, 49);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(61, 13);
            this.lblProyecto.TabIndex = 3;
            this.lblProyecto.Text = "Id Proyecto";
            this.lblProyecto.Click += new System.EventHandler(this.lblProyecto_Click);
            // 
            // lblIdPlan
            // 
            this.lblIdPlan.AutoSize = true;
            this.lblIdPlan.Location = new System.Drawing.Point(28, 20);
            this.lblIdPlan.Name = "lblIdPlan";
            this.lblIdPlan.Size = new System.Drawing.Size(39, 13);
            this.lblIdPlan.TabIndex = 1;
            this.lblIdPlan.Text = "Id plan";
            this.lblIdPlan.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(364, 417);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(121, 37);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "Cambiar Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(581, 431);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(209, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // IdPlanPrueba
            // 
            this.IdPlanPrueba.HeaderText = "Id Plan";
            this.IdPlanPrueba.Name = "IdPlanPrueba";
            // 
            // IdProyecto
            // 
            this.IdProyecto.HeaderText = "Id proyecto";
            this.IdProyecto.Name = "IdProyecto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // IdResposable
            // 
            this.IdResposable.HeaderText = "Id Responsable";
            this.IdResposable.Name = "IdResposable";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Borrado
            // 
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            // 
            // cboProyecto
            // 
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(86, 49);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(65, 21);
            this.cboProyecto.TabIndex = 8;
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(86, 17);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(105, 20);
            this.txtPlan.TabIndex = 9;
            this.txtPlan.TextChanged += new System.EventHandler(this.txtProyecto_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(326, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(235, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 13;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(235, 49);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(81, 13);
            this.lblResponsable.TabIndex = 12;
            this.lblResponsable.Text = "Id Responsable";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 473);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUser";
            this.Text = "Planes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblIdPlan;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlanPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResposable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}