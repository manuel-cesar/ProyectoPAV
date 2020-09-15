namespace ActualizarUsuarios.Presentacion
{
    partial class frmUpdatePlanes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePlanes));
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();

            this.SuspendLayout();
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;

            this.lblPlan.Location = new System.Drawing.Point(113, 39);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);

            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(40, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Id Plan";
            this.lblPlan.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtProyecto
            // 

            this.txtPlan.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlan.Location = new System.Drawing.Point(197, 92);
            this.txtPlan.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(256, 22);
            this.txtPlan.TabIndex = 2;

            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;

            this.lblProyecto.Location = new System.Drawing.Point(74, 93);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);

            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(61, 13);
            this.lblProyecto.TabIndex = 2;
            this.lblProyecto.Text = "Id Proyecto";
            // 
            // TxtNombre
            // 

            this.TxtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Location = new System.Drawing.Point(197, 151);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(256, 22);
            this.TxtNombre.TabIndex = 3;

            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;

            this.lblNombre.Location = new System.Drawing.Point(113, 152);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);

            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtResp
            // 

            this.txtContraseña1.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseña1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña1.Location = new System.Drawing.Point(197, 209);
            this.txtContraseña1.Margin = new System.Windows.Forms.Padding(6);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(256, 22);
            this.txtContraseña1.TabIndex = 4;

            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;

            this.lblResponsable.Location = new System.Drawing.Point(38, 209);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);

            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(81, 13);
            this.lblResponsable.TabIndex = 6;
            this.lblResponsable.Text = "Id Responsable";
            // 
            // txtDescripcion
            // 

            this.txtContraseña2.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseña2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña2.Location = new System.Drawing.Point(197, 265);
            this.txtContraseña2.Margin = new System.Windows.Forms.Padding(6);
            this.txtContraseña2.MaximumSize = new System.Drawing.Size(256, 60);
            this.txtContraseña2.MinimumSize = new System.Drawing.Size(256, 60);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(256, 60);
            this.txtContraseña2.TabIndex = 5;

            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;

            this.lblDescripcion.Location = new System.Drawing.Point(71, 272);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
>
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion";
            // 

            // cboPlan
            // 
            this.cboPlan.BackColor = System.Drawing.SystemColors.Control;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(197, 34);
            this.cboPlan.Margin = new System.Windows.Forms.Padding(6);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(256, 32);
            this.cboPlan.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(66, 368);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(176, 68);
            this.btnAceptar.TabIndex = 6;

            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 

            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(300, 368);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 68);

            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 

            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(198, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(198, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(198, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(198, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 1);
            this.panel4.TabIndex = 16;

            // 
            // frmUpdatePlanes
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(543, 478);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);

            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.lblPlan);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);

            this.MaximizeBox = false;
            this.Name = "frmUpdatePlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar o Agregar Plan";
            this.Load += new System.EventHandler(this.frmUpdatePlanes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

    }
}