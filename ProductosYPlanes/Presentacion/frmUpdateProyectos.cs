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
    public partial class frmUpdateProyectos : Form
    {
        public frmUpdateProyectos()
        {
            InitializeComponent();
        }

        private void txtProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
