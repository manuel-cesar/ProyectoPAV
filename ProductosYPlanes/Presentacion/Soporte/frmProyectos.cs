using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ProductosYPlanes.Negocio.Servicios;
using ProductosYPlanes.Negocio.Entidades;

namespace ProductosYPlanes.Presentacion
{
    public partial class frmProyectos : Form
    {
        private readonly ProyectoService proyectoService;
        private ProductoService productoService;
        private UsuarioService usuarioService;
        public frmProyectos()
        {
            InitializeComponent();
            InitializeDataGridView();
            proyectoService = new ProyectoService();

            productoService = new ProductoService();
            usuarioService = new UsuarioService(); ;

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

 

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtIdProyectos.Text))
            {
                var idProyecto = txtIdProyectos.Text;
                parametros.Add("id_proyecto", idProyecto);
            }

            if (!string.IsNullOrEmpty(txtProducto.Text))
            {
                var idProducto = txtProducto.Text;
                parametros.Add("id_producto", idProducto);
            }
            if (!string.IsNullOrEmpty(txtVersion.Text))
            {
                var version = txtVersion.Text;
                parametros.Add("version", version);
            }

            if (!string.IsNullOrEmpty(txtAlcance.Text))
            {
                var Alcance = txtAlcance.Text;
                parametros.Add("alcance", Alcance);
            }

            if (!string.IsNullOrEmpty(txtResponsable.Text))
            {
                var idResponsable = txtResponsable.Text;
                parametros.Add("id_responsable", idResponsable);
            }

            IList<Proyecto> listadoProyecto = proyectoService.ConsultarProyectoConFiltros(parametros);

            dgvProyectos.DataSource = listadoProyecto;

            if (dgvProyectos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvProyectos.ColumnCount = 6;
            dgvProyectos.ColumnHeadersVisible = true;
            dgvProyectos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvProyectos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvProyectos.Columns[0].Name = "ID proyecto";
            dgvProyectos.Columns[0].DataPropertyName = "id_proyecto";

            dgvProyectos.Columns[1].Name = "ID Producto";
            dgvProyectos.Columns[1].DataPropertyName = "id_producto";

            dgvProyectos.Columns[2].Name = "Responsable";
            dgvProyectos.Columns[2].DataPropertyName = "id_Responsable";

            dgvProyectos.Columns[3].Name = "Alcance";
            dgvProyectos.Columns[3].DataPropertyName = "Alcance";

            dgvProyectos.Columns[4].Name = "version";
            dgvProyectos.Columns[4].DataPropertyName = "version";
        

            dgvProyectos.Columns[5].Name = "Descripcion";
            dgvProyectos.Columns[5].DataPropertyName = "descripcion";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvProyectos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvProyectos.AutoResizeRows(
                    DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmUpdateProyectos modificarVentana = new frmUpdateProyectos();
            var proyecto = (Proyecto)dgvProyectos.CurrentRow.DataBoundItem;
            modificarVentana.InicializarFormulario(frmUpdateProyectos.FormMode.update, proyecto);
            modificarVentana.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el proyecto seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idProyecto = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["ID proyecto"].Value);
                    if (proyectoService.EliminarProyecto(idProyecto))
                    {
                        btnConsultar_Click(sender, e);
                        MessageBox.Show("Proyecto eliminado", "Aviso");

                    }
                    else
                        MessageBox.Show("Ho ocurrido un error al intentar borrar el proyecto", "Error");
                }
            }
            else
                btnEliminar.Enabled = false;
        }

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            frmUpdateProyectos modificarVentana = new frmUpdateProyectos();
            var proyecto = (Proyecto)dgvProyectos.CurrentRow.DataBoundItem;
            modificarVentana.InicializarFormulario(frmUpdateProyectos.FormMode.update, proyecto);
            modificarVentana.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvProyectos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el proyecto seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idProyecto = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["ID proyecto"].Value);
                    if (proyectoService.EliminarProyecto(idProyecto))
                    {
                        btnConsultar_Click(sender, e);
                        MessageBox.Show("Proyecto eliminado", "Aviso");

                    }
                    else
                        MessageBox.Show("Ho ocurrido un error al intentar borrar el proyecto", "Error");
                }
            }
            else
                btnEliminar.Enabled = false;
        }
 

    }
}
