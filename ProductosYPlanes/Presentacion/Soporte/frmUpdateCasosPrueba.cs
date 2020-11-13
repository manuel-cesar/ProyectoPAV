using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Negocio.Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProductosYPlanes.Presentacion
{
    public partial class frmUpdateCasosPrueba : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly CasoPruebaService oCasoPruebaService;
        private CasoPrueba oCasoPruebaSelected;
        private PlanService planService;
        private UsuarioService usuarioService;

        public frmUpdateCasosPrueba()
        {
            InitializeComponent();
            oCasoPruebaService = new CasoPruebaService();
            planService = new PlanService();
            usuarioService = new UsuarioService();        }
        public enum FormMode
        {
            insert,
            update
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void frmUpdateCasosPrueba_Load(System.Object sender, System.EventArgs e)
        {
            LlenarCombo(cboPlan, planService.ConsultarTodos(), "Id_Plan_Prueba", "Id_Plan_Prueba");
            LlenarCombo(cboResponsable, usuarioService.ObtenerTodos(), "idusuario", "id_usuario");


            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo caso de prueba";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Caso de Prueba";
                        // Recuperar Caso de Prueba seleccionado en la grilla 
                        MostrarDatos();
                        txtCasoPrueba.Enabled = false;
                        cboPlan.Enabled = true;
                        TxtTitulo.Enabled = true;
                        cboResponsable.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oCasoPruebaSelected != null)
            {
                txtCasoPrueba.Text = oCasoPruebaSelected.Id_Caso_Prueba.ToString();
                cboPlan.Text = oCasoPruebaSelected.Id_Plan_Prueba.ToString();
                TxtTitulo.Text = oCasoPruebaSelected.Titulo.ToString();
                cboResponsable.Text = oCasoPruebaSelected.Id_Responsable.ToString();
                txtDescripcion.Text = oCasoPruebaSelected.Descripcion.ToString();
            }

        }

        public void InicializarFormulario(FormMode op, CasoPrueba CasoPruebaSelected)
        {
            formMode = op;
            oCasoPruebaSelected = CasoPruebaSelected;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {
                            int newId = Convert.ToInt32(oCasoPruebaService.consultarMaxId());
                            newId++;

                            var oCasoPrueba = new CasoPrueba
                            {
                                Id_Caso_Prueba = newId,
                                Id_Plan_Prueba = Convert.ToInt32(cboPlan.SelectedIndex),
                                Titulo = TxtTitulo.Text,
                                Id_Responsable = Convert.ToInt32(cboResponsable.SelectedIndex),
                                Descripcion = txtDescripcion.Text,
                                Borrado = false
                            };
                            if (oCasoPruebaService.crearCasoPrueba(oCasoPrueba))
                            {
                                MessageBox.Show("Caso de Prueba!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show("Titulo de Caso de Prueba encontrado!. Ingrese un Titulo diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    }
                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oCasoPruebaSelected.Id_Caso_Prueba = Convert.ToInt32(txtCasoPrueba.Text);
                            oCasoPruebaSelected.Id_Plan_Prueba = Convert.ToInt32(cboPlan.Text);
                            oCasoPruebaSelected.Titulo = TxtTitulo.Text;
                            oCasoPruebaSelected.Id_Responsable = Convert.ToInt32(cboResponsable.SelectedIndex);
                            oCasoPruebaSelected.Descripcion = txtDescripcion.Text;

                            if (oCasoPruebaService.ActualizarCasoPrueba(oCasoPruebaSelected))
                            {
                                MessageBox.Show("Caso Prueba actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Caso de Prueba!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (cboPlan.Text == string.Empty)
            {
                cboPlan.BackColor = Color.Red;
                cboPlan.Focus();
                return false;
            }
            else
                cboPlan.BackColor = Color.White;

            if (TxtTitulo.Text == string.Empty)
            {
                TxtTitulo.BackColor = Color.Red;
                TxtTitulo.Focus();
                return false;
            }
            else
                TxtTitulo.BackColor = Color.White;

            if (cboResponsable.Text == string.Empty)
            {
                cboResponsable.BackColor = Color.Red;
                cboResponsable.Focus();
                return false;
            }
            else
                cboResponsable.BackColor = Color.White;


            return true;
        }


    }
}
