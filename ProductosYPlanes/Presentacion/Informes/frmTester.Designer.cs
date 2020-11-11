namespace ProductosYPlanes.Presentacion.Informes
{
    partial class frmTester
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
            this.dsTester = new ProductosYPlanes.Presentacion.Informes.dsTester();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TestersTableAdapter = new ProductosYPlanes.Presentacion.Informes.dsTesterTableAdapters.TestersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTester
            // 
            this.dsTester.DataSetName = "dsTester";
            this.dsTester.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsTester";
            reportDataSource1.Value = this.TestersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductosYPlanes.Presentacion.Informes.ReporteTester.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TestersBindingSource
            // 
            this.TestersBindingSource.DataMember = "Testers";
            this.TestersBindingSource.DataSource = this.dsTester;
            // 
            // TestersTableAdapter
            // 
            this.TestersTableAdapter.ClearBeforeFill = true;
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTester";
            this.Text = "frmTester";
            this.Load += new System.EventHandler(this.frmTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsTester dsTester;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TestersBindingSource;
        private dsTesterTableAdapters.TestersTableAdapter TestersTableAdapter;
    }
}