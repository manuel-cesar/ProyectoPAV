using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Negocio.Servicios;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ProductosYPlanes.Presentacion
{
    public partial class frmProducto : Form
    {
        private readonly ProductoService productoService;
        public frmProducto()
        {
            InitializeComponent();
            InitializeDataGridView();
            productoService = new ProductoService();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvProducto.ColumnCount = 2;
            dgvProducto.ColumnHeadersVisible = true;
            dgvProducto.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvProducto.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvProducto.Columns[0].Name = "ID";
            dgvProducto.Columns[0].DataPropertyName = "id_producto";

            dgvProducto.Columns[1].Name = "Nombre";
            dgvProducto.Columns[1].DataPropertyName = "nombre";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvProducto.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvProducto.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtIdProducto.Text))
            {
                var idProducto = txtIdProducto.Text;
                parametros.Add("id_producto", idProducto);
            }

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var nombre = txtNombre.Text;
                parametros.Add("nombre", nombre);
            }

            IList<Producto> listadoPlanes = productoService.ConsultarProductoConFiltros(parametros);

            dgvProducto.DataSource = listadoPlanes;

            if (dgvProducto.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUpdateProducto agregarVentana = new frmUpdateProducto();
            agregarVentana.Text = "Agregar Producto";
            agregarVentana.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmUpdateProducto modificarVentana = new frmUpdateProducto();
            var producto = (Producto)dgvProducto.CurrentRow.DataBoundItem;
            modificarVentana.InicializarFormulario(frmUpdateProducto.FormMode.update, producto);
            modificarVentana.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Rows.Count > 0)
            {
                if (MessageBox.Show("Desea eliminar el plan seleccionado", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idProducto = Convert.ToInt32(dgvProducto.CurrentRow.Cells["ID"].Value);
                    if (productoService.EliminarProducto(idProducto))
                    {
                        btnConsultar_Click(sender, e);
                        MessageBox.Show("Producto eliminado", "Aviso");

                    }
                    else
                        MessageBox.Show("Ha ocurrido un error al intentar borrar el producto", "Error");
                }
            }
            else
                btnEliminar.Enabled = false;
        }
        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
