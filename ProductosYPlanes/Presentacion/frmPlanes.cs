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
            // Inicializamos la grilla de Planes
            InitializeDataGridView();
            planService = new PlanService();

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

            if (!string.IsNullOrEmpty(txtNombre.Text))
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

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvPlanes.ColumnCount = 5;
            dgvPlanes.ColumnHeadersVisible = true;
            dgvPlanes.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvPlanes.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvPlanes.Columns[0].Name = "ID";
            dgvPlanes.Columns[0].DataPropertyName = "id_plan_prueba";


            dgvPlanes.Columns[1].Name = "ID Proyecto";
            dgvPlanes.Columns[1].DataPropertyName = "id_proyecto";

            dgvPlanes.Columns[2].Name = "Nombre";
            dgvPlanes.Columns[2].DataPropertyName = "nombre";

            dgvPlanes.Columns[3].Name = "Responsable";
            dgvPlanes.Columns[3].DataPropertyName = "id_Responsable";

            dgvPlanes.Columns[4].Name = "Descripcion";
            dgvPlanes.Columns[4].DataPropertyName = "descripcion";


            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvPlanes.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvPlanes.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
