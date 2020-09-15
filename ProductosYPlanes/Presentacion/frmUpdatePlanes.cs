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
    public partial class frmUpdatePlanes : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly PlanService oPlanService;
        private  Plan oPlanSelected;

        public frmUpdatePlanes()
        {
            InitializeComponent();
            oPlanService = new PlanService();

        }

        public enum FormMode
        {
            insert,
            update
        }

        private void frmUpdatePlanes_Load(System.Object sender, System.EventArgs e)
        { 
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
                        txtplanMod.Enabled = true;
                        txtProyecto.Enabled = true;
                        TxtNombre.Enabled = true;
                        txtResp.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
            
            }
        }

        private void MostrarDatos()
        { 
            if(oPlanSelected != null)
            {
                txtplanMod.Text = oPlanSelected.Id_Plan_Prueba.ToString();
                txtProyecto.Text = oPlanSelected.Id_Proyecto.ToString();
                TxtNombre.Text = oPlanSelected.Nombre.ToString();
                txtResp.Text = oPlanSelected.Id_Responsable.ToString();
                txtDescripcion.Text = oPlanSelected.Descripcion.ToString();


            }
        }
        public void InicializarFormulario(FormMode op, Plan PlanSelected)
        {
            formMode = op;
            oPlanSelected = PlanSelected;
        }



        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

     
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {
                            var oPlan = new Plan
                            {
                                Id_Plan_Prueba = Convert.ToInt32(txtplanMod.Text),
                                Id_Proyecto = Convert.ToInt32(txtProyecto.Text),
                                Nombre = TxtNombre.Text,
                                Id_Responsable = Convert.ToInt32(txtResp.Text),
                                Descripcion = txtDescripcion.Text,
                                Borrado = false
                            };                            
                            if (oPlanService.crearPlan(oPlan))
                            {
                                //btnConsultar_Click(sender, e); /Esto lo use en el otro cuando elimina para q actualice
                                MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }

                        else
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    }

                case FormMode.update:
                    {
                        txtplanMod.Text = oPlanSelected.Id_Plan_Prueba.ToString();
                        txtProyecto.Text = oPlanSelected.Id_Proyecto.ToString();
                        TxtNombre.Text = oPlanSelected.Nombre;
                        txtResp.Text = oPlanSelected.Id_Responsable.ToString();
                        txtDescripcion.Text = oPlanSelected.Descripcion;

                        if (ValidarCampos())
                        {
                            var oPlan = new Plan
                            {
                                Id_Plan_Prueba = Convert.ToInt32(txtplanMod.Text),
                                Id_Proyecto = Convert.ToInt32(txtProyecto.Text),
                                Nombre = TxtNombre.Text,
                                Id_Responsable = Convert.ToInt32(txtResp.Text),
                                Descripcion = txtDescripcion.Text,
                                Borrado = false
                            };

                            if (oPlanService.ActualizarPlan(oPlan))
                            {
                                // btnConsultar_Click(sender, e); / Esto lo use en el otro cuando elimina para q actualice
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtplanMod_TextChanged(object sender, EventArgs e){

        }

        private void txtPlan_TextChanged(object sender, EventArgs e)
        {

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

            if (txtProyecto.Text == string.Empty)
            {
                txtProyecto.BackColor = Color.Red;
                txtProyecto.Focus();
                return false;
            }
            else
                txtProyecto.BackColor = Color.White;

            if (TxtNombre.Text == string.Empty)
            {
                TxtNombre.BackColor = Color.Red;
                TxtNombre.Focus();
                return false;
            }
            else
                TxtNombre.BackColor = Color.White;

            if (txtResp.Text == string.Empty)
            {
                txtResp.BackColor = Color.Red;
                txtResp.Focus();
                return false;
            }
            else
                txtResp.BackColor = Color.White;

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
    }
}
