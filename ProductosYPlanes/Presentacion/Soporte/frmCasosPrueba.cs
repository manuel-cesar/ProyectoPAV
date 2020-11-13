using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProductosYPlanes.Presentacion
{
    public partial class frmCasosPrueba : Form
    {
        private readonly CasoPruebaService casoPruebaService;
        public frmCasosPrueba()
        {
            InitializeComponent();
            // Inicializamos la grilla de Casos
            InitializeDataGridView();
            casoPruebaService = new CasoPruebaService();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtIdCaso.Text))
            {
                var idCaso = txtIdCaso.Text;
                parametros.Add("id_caso_prueba", idCaso);
            }

            if (!string.IsNullOrEmpty(txtIdPlan.Text))
            {
                var idPlan  = txtIdPlan.Text;
                parametros.Add("id_plan_prueba", idPlan);
            }

            if (!string.IsNullOrEmpty(txtTitulo.Text))
            {
                var titulo = txtTitulo.Text;
                parametros.Add("titulo", titulo);
            }

            if (!string.IsNullOrEmpty(txtResponsable.Text))
            {
                var idResponsable = txtResponsable.Text;
                parametros.Add("id_responsable", idResponsable);
            }

            if (!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                var descripcion = txtDescripcion.Text;
                parametros.Add("descripcion", descripcion);
            }

            IList<CasoPrueba> listadoCasos = casoPruebaService.ConsultarCasoPruebaConFiltros(parametros);

            dgvCasos.DataSource = listadoCasos;

            if (dgvCasos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvCasos.ColumnCount = 5;
            dgvCasos.ColumnHeadersVisible = true;
            dgvCasos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvCasos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvCasos.Columns[0].Name = "IdCaso";
            dgvCasos.Columns[0].DataPropertyName = "id_caso_prueba";

            dgvCasos.Columns[1].Name = "ID Plan";
            dgvCasos.Columns[1].DataPropertyName = "id_plan_prueba";

            dgvCasos.Columns[2].Name = "Titulo";
            dgvCasos.Columns[2].DataPropertyName = "Titulo";

            dgvCasos.Columns[3].Name = "Responsable";
            dgvCasos.Columns[3].DataPropertyName = "id_Responsable";

            dgvCasos.Columns[4].Name = "Descripcion";
            dgvCasos.Columns[4].DataPropertyName = "descripcion";


            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvCasos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvCasos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUpdateCasosPrueba agregarVentana = new frmUpdateCasosPrueba();
            agregarVentana.Text = "Agregar Caso de Prueba";
            agregarVentana.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateCasosPrueba modificarVentana = new frmUpdateCasosPrueba();
            var caso = (CasoPrueba)dgvCasos.CurrentRow.DataBoundItem;
            modificarVentana.InicializarFormulario(frmUpdateCasosPrueba.FormMode.update, caso);
            modificarVentana.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCasos.Rows.Count > 0)
            {
                if (MessageBox.Show("Desea eliminar el Caso de Prueba seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idCasoPrueba = Convert.ToInt32(dgvCasos.CurrentRow.Cells["IdCaso"].Value);
                    if (casoPruebaService.EliminarCasoPrueba(idCasoPrueba))
                    {
                        btnConsultar_Click(sender, e);
                        MessageBox.Show("Caso de Prueba eliminado", "Aviso");

                    }
                    else
                        MessageBox.Show("Ho ocurrido un error al intentar borrar el Caso.", "Error");
                }
            }
            else
                btnEliminar.Enabled = false;
        }

        private void dgvCasos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
