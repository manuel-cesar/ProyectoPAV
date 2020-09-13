using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProductosYPlanes.Negocio.Servicios;
using ProductosYPlanes.Negocio.Entidades;
namespace ProductosYPlanes.Presentacion
{
    public partial class frmPlanes : Form
    {
        private readonly PlanService planService;
        public frmPlanes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblProyecto_Click(object sender, EventArgs e)
        {

        }

        private void txtProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPlanes_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();


            if (!string.IsNullOrEmpty(txtIdPlan.Text))
            {
                var idPlan = txtIdPlan.Text;
                parametros.Add("id_plan_prueba", idPlan);
            }

            if (!string.IsNullOrEmpty(txtIdProyecto.Text))
            {
                var idProyecto = txtIdProyecto.Text;
                parametros.Add("id_proyecto", idProyecto);
            }

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var nombre = txtNombre.Text;
                parametros.Add("nombre", nombre);
            }

            if (!string.IsNullOrEmpty(txtResponsable.Text))
            {
                var idResponsable = txtResponsable.Text;
                parametros.Add("id_Responsable", idResponsable);
            }

            IList<Plan> listadoPlanes = planService.ConsultarPlanConFiltros(parametros);

            dgvPlanes.DataSource = listadoPlanes;

            if (dgvPlanes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
