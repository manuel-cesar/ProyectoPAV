namespace ProductosYPlanes.Presentacion.Informes.CicloPeriodo
{
    partial class frmCicloPeriodo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.fecha_desde2 = new System.Windows.Forms.DateTimePicker();
            this.fecha_hasta2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CicloPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCicloPeriodo = new ProductosYPlanes.Presentacion.Informes.CicloPeriodo.dsCicloPeriodo();
            this.CicloPeriodoTableAdapter = new ProductosYPlanes.Presentacion.Informes.CicloPeriodo.dsCicloPeriodoTableAdapters.CicloPeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CicloPeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCicloPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_desde2
            // 
            this.fecha_desde2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_desde2.Location = new System.Drawing.Point(179, 12);
            this.fecha_desde2.Name = "fecha_desde2";
            this.fecha_desde2.Size = new System.Drawing.Size(87, 20);
            this.fecha_desde2.TabIndex = 1;
            this.fecha_desde2.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            // 
            // fecha_hasta2
            // 
            this.fecha_hasta2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_hasta2.Location = new System.Drawing.Point(367, 12);
            this.fecha_hasta2.Name = "fecha_hasta2";
            this.fecha_hasta2.Size = new System.Drawing.Size(87, 20);
            this.fecha_hasta2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(484, 9);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(141, 23);
            this.btnInforme.TabIndex = 6;
            this.btnInforme.Text = "Crear Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsCicloPeriodo";
            reportDataSource1.Value = this.CicloPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductosYPlanes.Presentacion.Informes.CicloPeriodo.ReporteCicloPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 386);
            this.reportViewer1.TabIndex = 7;
            // 
            // CicloPeriodoBindingSource
            // 
            this.CicloPeriodoBindingSource.DataMember = "CicloPeriodo";
            this.CicloPeriodoBindingSource.DataSource = this.dsCicloPeriodo;
            // 
            // dsCicloPeriodo
            // 
            this.dsCicloPeriodo.DataSetName = "dsCicloPeriodo";
            this.dsCicloPeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CicloPeriodoTableAdapter
            // 
            this.CicloPeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCicloPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha_hasta2);
            this.Controls.Add(this.fecha_desde2);
            this.Name = "frmCicloPeriodo";
            this.Text = "frmCicloPeriodo";
            this.Load += new System.EventHandler(this.frmCicloPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CicloPeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCicloPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha_desde2;
        private System.Windows.Forms.DateTimePicker fecha_hasta2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInforme;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CicloPeriodoBindingSource;
        private dsCicloPeriodo dsCicloPeriodo;
        private dsCicloPeriodoTableAdapters.CicloPeriodoTableAdapter CicloPeriodoTableAdapter;
    }
}