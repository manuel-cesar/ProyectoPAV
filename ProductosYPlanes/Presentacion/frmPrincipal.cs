using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductosYPlanes.Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanes form = new frmPlanes();
            form.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frmLogin login = new frmLogin();
            login.ShowDialog();
            toolStripStatusLabelUsuario.Text = login.UsuarioLogueado;
        }


        private void casosDePruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCasosPrueba form = new frmCasosPrueba();
        }
        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectos form = new frmProyectos();
            form.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto form = new frmProducto();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void casosDePruebaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCasosPrueba form = new frmCasosPrueba();
            form.ShowDialog();
        }
    }
}
