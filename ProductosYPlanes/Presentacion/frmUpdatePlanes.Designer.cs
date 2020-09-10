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
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(74, 23);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(40, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Id Plan";
            this.lblPlan.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(120, 49);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(100, 20);
            this.txtPlan.TabIndex = 1;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(53, 52);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(61, 13);
            this.lblProyecto.TabIndex = 2;
            this.lblProyecto.Text = "Id Proyecto";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(120, 83);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(154, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Location = new System.Drawing.Point(120, 112);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña1.TabIndex = 7;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(33, 115);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(81, 13);
            this.lblResponsable.TabIndex = 6;
            this.lblResponsable.Text = "Id Responsable";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(120, 146);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña2.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(51, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(120, 20);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 21);
            this.cboPlan.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(39, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(157, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmUpdatePlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 259);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboPlan);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.lblPlan);
            this.Name = "frmUpdatePlanes";
            this.Text = "Actualizar Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}