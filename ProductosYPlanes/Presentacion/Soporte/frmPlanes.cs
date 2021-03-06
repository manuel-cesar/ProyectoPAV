﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ProductosYPlanes.Negocio.Servicios;
using ProductosYPlanes.Negocio.Entidades;



namespace ProductosYPlanes.Presentacion
{
    public partial class frmPlanes : Form
    {
        private readonly PlanService planService;

        private UsuarioService usuarioSerive;
        private ProyectoService proyectoService;

        public frmPlanes()
        {
            InitializeComponent();
            // Inicializamos la grilla de Planes
            InitializeDataGridView();
            planService = new PlanService();

            usuarioSerive = new UsuarioService();
            proyectoService = new ProyectoService();

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtId_plan.Text))
            {
                var idPlan = txtId_plan.Text;
                parametros.Add("id_plan_prueba", idPlan);
            }

            if (!string.IsNullOrEmpty(cboProyecto.Text))
            {
                var idProyecto = cboProyecto.Text;
                parametros.Add("id_proyecto", idProyecto);
            }

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var nombre = txtNombre.Text;
                parametros.Add("nombre", nombre);
            }

            if (!string.IsNullOrEmpty(cboResp.Text))
            {
                var idResponsable = cboResp.Text;
                parametros.Add("id_responsable", idResponsable);
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
            dgvPlanes.Columns[3].DataPropertyName = "id_responsable";

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUpdatePlanes agregarVentana = new frmUpdatePlanes();
            agregarVentana.Text = "Agregar Plan";
            agregarVentana.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdatePlanes modificarVentana = new frmUpdatePlanes();
            var plan = (Plan)dgvPlanes.CurrentRow.DataBoundItem;
            modificarVentana.InicializarFormulario(frmUpdatePlanes.FormMode.update, plan);
            modificarVentana.ShowDialog();
            btnConsultar_Click(sender, e);
        }
            private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.Rows.Count > 0)
            {
                if (MessageBox.Show("Desea eliminar el plan seleccionado", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idPlan = Convert.ToInt32(dgvPlanes.CurrentRow.Cells["ID"].Value);
                    if (planService.EliminarPlan(idPlan))
                    {
                        btnConsultar_Click(sender, e);
                        MessageBox.Show("Plan eliminado", "Aviso");

                    }
                    else
                        MessageBox.Show("Ho ocurrido un error al intentar borrar el plan", "Error");
                }
            }
            else
                btnEliminar.Enabled = false;
        }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void frmPlanes_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPlanes_Load_1(object sender, EventArgs e)
        {
            LlenarCombo(cboProyecto, proyectoService.ConsultarTodos(), "id_proyecto", "Id_proyecto");
            LlenarCombo(cboResp, usuarioSerive.ObtenerTodos(), "idusuario", "id_usuario");
        }
    }
}
