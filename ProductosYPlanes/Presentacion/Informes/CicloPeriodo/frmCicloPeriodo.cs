using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosYPlanes.Presentacion.Informes.CicloPeriodo
{
    public partial class frmCicloPeriodo : Form
    {
        public frmCicloPeriodo()
        {
            InitializeComponent();
        }

        private void frmCicloPeriodo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCicloPeriodo.CicloPeriodo' Puede moverla o quitarla según sea necesario.
            this.CicloPeriodoTableAdapter.Fill(this.dsCicloPeriodo.CicloPeriodo);


            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}
