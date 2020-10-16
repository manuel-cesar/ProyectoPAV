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

        public frmUpdateCasosPrueba()
        {
            InitializeComponent();
            oCasoPruebaService = new CasoPruebaService();
        }
        public enum FormMode
        {
            insert,
            update
        }

        private void frmUpdateCasosPrueba_Load(System.Object sender, System.EventArgs e)
        {
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
                        txtCasoPrueba.Enabled = true;
                        txtPlan.Enabled = true;
                        TxtTitulo.Enabled = true;
                        txtResponsable.Enabled = true;
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
                txtPlan.Text = oCasoPruebaSelected.Id_Plan_Prueba.ToString();
                TxtTitulo.Text = oCasoPruebaSelected.Titulo.ToString();
                txtResponsable.Text = oCasoPruebaSelected.Id_Responsable.ToString();
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
                            var oCasoPrueba = new CasoPrueba
                            {
                                Id_Caso_Prueba = Convert.ToInt32(txtCasoPrueba.Text),
                                Id_Plan_Prueba = Convert.ToInt32(txtPlan.Text),
                                Titulo = TxtTitulo.Text,
                                Id_Responsable = Convert.ToInt32(txtResponsable.Text),
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
                            oCasoPruebaSelected.Id_Plan_Prueba = Convert.ToInt32(txtPlan.Text);
                            oCasoPruebaSelected.Titulo = TxtTitulo.Text;
                            oCasoPruebaSelected.Id_Responsable = Convert.ToInt32(txtResponsable.Text);
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
            if (txtCasoPrueba.Text == string.Empty)
            {
                txtCasoPrueba.BackColor = Color.Red;
                txtCasoPrueba.Focus();
                return false;
            }
            else
                txtCasoPrueba.BackColor = Color.White;

            if (txtPlan.Text == string.Empty)
            {
                txtPlan.BackColor = Color.Red;
                txtPlan.Focus();
                return false;
            }
            else
                txtPlan.BackColor = Color.White;

            if (TxtTitulo.Text == string.Empty)
            {
                TxtTitulo.BackColor = Color.Red;
                TxtTitulo.Focus();
                return false;
            }
            else
                TxtTitulo.BackColor = Color.White;


            return true;
        }


    }
}
