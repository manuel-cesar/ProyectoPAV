using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActualizarUsuarios.Presentacion
{
    public partial class frmProyectos : Form
    {
        public frmProyectos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUpdateProyectos agregarVentana = new frmUpdateProyectos();
            agregarVentana.Text = "Agregar Proyecto";
            agregarVentana.Show();
        }
    }
}
