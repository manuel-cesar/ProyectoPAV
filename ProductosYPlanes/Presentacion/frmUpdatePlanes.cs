using System;
using System.Drawing;
using System.Windows.Forms;

using ProductosYPlanes.Negocio.Servicios;
using ProductosYPlanes.Negocio.Entidades;



namespace ProductosYPlanes.Presentacion
{
    public partial class frmUpdatePlanes : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly PlanService oPlanService;
        private Plan oPlanSelected;

        private  UsuarioService usuarioSerive;
        private  ProyectoService proyectoService;


        public frmUpdatePlanes()
        {
            InitializeComponent();
            oPlanService = new PlanService();

            usuarioSerive = new UsuarioService();
            proyectoService = new ProyectoService();

        }

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
        
        private void frmUpdatePlanes_Load(System.Object sender, System.EventArgs e)
        {
            LlenarCombo(cboProy, proyectoService.ConsultarTodos(), "descripcion", "id_proyecto");
            LlenarCombo(cboRESP, usuarioSerive.ObtenerTodos(), "usuario", "id_usuario");

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Plan";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Plan";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtplanMod.Enabled = false;
                        cboProy.Enabled = true;
                        TxtNombre.Enabled = true;

                        cboRESP.Enabled = true;

                        txtDescripcion.Enabled = true;
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oPlanSelected != null)
            {
                txtplanMod.Text = oPlanSelected.Id_Plan_Prueba.ToString();
                cboProy.Text = oPlanSelected.Id_Proyecto.ToString();
                TxtNombre.Text = oPlanSelected.Nombre.ToString();

                cboRESP.Text = oPlanSelected.Id_Responsable.ToString();

                txtDescripcion.Text = oPlanSelected.Descripcion.ToString();
            }
        }
        public void InicializarFormulario(FormMode op, Plan PlanSelected)
        {
            formMode = op;
            oPlanSelected = PlanSelected;
        }

        private bool ValidarCampos()
        {

            // campos obligatorios
            if (txtplanMod.Text == string.Empty)
            {
                txtplanMod.BackColor = Color.Red;
                txtplanMod.Focus();
                return false;
            }
            else
                txtplanMod.BackColor = Color.White;

            if (cboProy.SelectedIndex == -1)
            {
                cboProy.BackColor = Color.Red;
                cboProy.Focus();
                return false;
            }
            else
                cboProy.BackColor = Color.White;

            if (TxtNombre.Text == string.Empty)
            {
                TxtNombre.BackColor = Color.Red;
                TxtNombre.Focus();
                return false;
            }
            else
                TxtNombre.BackColor = Color.White;


            if (cboRESP.SelectedIndex == -1)
            {
                cboRESP.BackColor = Color.Red;
                cboRESP.Focus();
                return false;
            }
            else
                cboRESP.BackColor = Color.White;


            if (txtDescripcion.Text == string.Empty)
            {
                txtDescripcion.BackColor = Color.Red;
                txtDescripcion.Focus();
                return false;
            }
            else
                txtDescripcion.BackColor = Color.White;

            return true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {
                            int newId = Convert.ToInt32(oPlanService.consultarMaxId());
                            newId++;
                            txtplanMod.Text = newId.ToString();
                            var oPlan = new Plan
                            {

                                Id_Plan_Prueba = Convert.ToInt32(txtplanMod.Text),
                                Id_Proyecto = Convert.ToInt32(cboProy.SelectedValue),
                                Nombre = TxtNombre.Text,
                                Id_Responsable = Convert.ToInt32(cboRESP.SelectedValue),

                                Descripcion = txtDescripcion.Text,
                                Borrado = false
                            };
                            if (oPlanService.crearPlan(oPlan))
                            {
                                //btnConsultar_Click(sender, e); //Esto lo use en el otro cuando elimina para q actualice
                                MessageBox.Show("Plan insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }

                        else
                            MessageBox.Show("Plan encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {

                            oPlanSelected.Id_Plan_Prueba = Convert.ToInt32(txtplanMod.Text);
                            oPlanSelected.Id_Proyecto = Convert.ToInt32(cboProy.SelectedValue);
                            oPlanSelected.Nombre = TxtNombre.Text;

                            oPlanSelected.Id_Responsable = Convert.ToInt32(cboRESP.SelectedValue);

                            oPlanSelected.Descripcion = txtDescripcion.Text;

                            if (oPlanService.ActualizarPlan(oPlanSelected))
                            {
                                MessageBox.Show("Plan actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Plan!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
