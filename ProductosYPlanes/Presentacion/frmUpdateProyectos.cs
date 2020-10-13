﻿using System;
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
    public partial class frmUpdateProyectos : Form
    {
        private FormMode formMode = FormMode.insert;
        private readonly ProyectoService oProyectoService;
        private Proyecto oProyectoSelected;

        public frmUpdateProyectos()
        {
            InitializeComponent();
            oProyectoService = new ProyectoService();

        }

        public enum FormMode
        {
            insert,
            update
        }

        private void frmUpdateProyectos_Load(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Proyecto";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Proyecto";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtProyecto.Enabled = true;
                        txtProducto.Enabled = true;
                        txtDescripcion.Enabled = true;
                        txtAlcance.Enabled = true;
                        txtVersion.Enabled = true;
                        txtIdResponsable.Enabled = true;
                        break;
                    }

            }
        }

        private void MostrarDatos()
        {
            if (oProyectoSelected != null)
            {
                txtProyecto.Text = oProyectoSelected.Id_Proyecto.ToString();
                txtProducto.Text = oProyectoSelected.Id_Producto.ToString();
                txtDescripcion.Text = oProyectoSelected.Descripcion.ToString();
                txtAlcance.Text = oProyectoSelected.Alcance.ToString();
                txtVersion.Text = oProyectoSelected.Version.ToString();
                txtIdResponsable.Text = oProyectoSelected.Id_Responsable.ToString();


            }
        }

        public void InicializarFormulario(FormMode op, Proyecto ProyectoSelected)
        {
            formMode = op;
            oProyectoSelected = ProyectoSelected;

        }

        private void txtProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {
                            var oProyecto = new Proyecto
                            {
                                Id_Proyecto = Convert.ToInt32(txtProyecto.Text),
                                Id_Producto = Convert.ToInt32(txtProducto.Text),
                                Descripcion = txtDescripcion.Text,
                                Alcance = Convert.ToInt32(txtAlcance.Text),
                                Version = Convert.ToInt32(txtVersion.Text),
                                Id_Responsable = Convert.ToInt32(txtIdResponsable.Text),

                                Borrado = false
                            };
                            if (oProyectoService.crearProyecto(oProyecto))
                            {
                                //btnConsultar_Click(sender, e); /Esto lo use en el otro cuando elimina para q actualice
                                MessageBox.Show("Proyecto insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }

                        else
                            MessageBox.Show("id de proyecto encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oProyectoSelected.Id_Proyecto = Convert.ToInt32(txtProyecto.Text);
                            oProyectoSelected.Id_Producto = Convert.ToInt32(txtProducto.Text);
                            oProyectoSelected.Descripcion = txtDescripcion.Text;
                            oProyectoSelected.Alcance = Convert.ToInt32(txtAlcance.Text);
                            oProyectoSelected.Version = Convert.ToInt32(txtVersion.Text);
                            oProyectoSelected.Id_Responsable = Convert.ToInt32(txtIdResponsable.Text);


                            if (oProyectoService.ActualizarProyecto(oProyectoSelected))
                            {
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
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtProyecto.Text == string.Empty)
            {
                txtProyecto.BackColor = Color.Red;
                txtProyecto.Focus();
                return false;
            }
            else
                txtProyecto.BackColor = Color.White;

            if (txtProducto.Text == string.Empty)
            {
                txtProducto.BackColor = Color.Red;
                txtProducto.Focus();
                return false;
            }
            else
                txtProducto.BackColor = Color.White;
            if (txtDescripcion.Text == string.Empty)
            {
                txtDescripcion.BackColor = Color.Red;
                txtDescripcion.Focus();
                return false;
            }
            else
                txtDescripcion.BackColor = Color.White;

            if (txtAlcance.Text == string.Empty)
            {
                txtAlcance.BackColor = Color.Red;
                txtAlcance.Focus();
                return false;
            }
            else
                txtAlcance.BackColor = Color.White;

            if (txtVersion.Text == string.Empty)
            {
                txtVersion.BackColor = Color.Red;
                txtVersion.Focus();
                return false;
            }
            else
                txtVersion.BackColor = Color.White;

            if (txtIdResponsable.Text == string.Empty)
            {
                txtIdResponsable.BackColor = Color.Red;
                txtIdResponsable.Focus();
                return false;
            }
            else
                txtIdResponsable.BackColor = Color.White;




            return true;
        }
    }
}

