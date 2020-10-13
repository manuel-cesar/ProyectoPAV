using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosYPlanes.Presentacion
{
    public partial class frmUpdateProducto : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly ProductoService oProductoService;
        private Producto oProductoSelected;

        public frmUpdateProducto()
        {
            InitializeComponent();
            oProductoService = new ProductoService();
        }

        public enum FormMode
        {
            insert,
            update
        }
        private void frmUpdateProducto_Load(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Producto";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Producto";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtProducto.Enabled = true;
                        txtNombre.Enabled = true;
                        break;
                    }

            }
        }
        private void MostrarDatos()
        {
            if (oProductoSelected != null)
            {
                txtProducto.Text = oProductoSelected.Id_Producto.ToString();
                txtNombre.Text = oProductoSelected.Nombre.ToString();
            }
        }
        public void InicializarFormulario(FormMode op, Producto ProductoSelected)
        {
            formMode = op;
            oProductoSelected = ProductoSelected;
        }
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtProducto.Text == string.Empty)
            {
                txtProducto.BackColor = Color.Red;
                txtProducto.Focus();
                return false;
            }
            else
                txtProducto.BackColor = Color.White;

            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;


            return true;
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
                            var oProducto = new Producto
                            {
                                Id_Producto = Convert.ToInt32(txtProducto.Text),
                                Nombre = txtNombre.Text,
                                Borrado = false
                            };
                            if (oProductoService.crearProducto(oProducto))
                            {
                                //btnConsultar_Click(sender, e); /Esto lo use en el otro cuando elimina para q actualice

                                MessageBox.Show("Producto insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
                        }

                        else
                            MessageBox.Show("Producto encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;

                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {

                            oProductoSelected.Id_Producto = Convert.ToInt32(txtProducto.Text);
                            oProductoSelected.Nombre = txtNombre.Text;

                            if (oProductoService.ActualizarProducto(oProductoSelected))
                            {

                                MessageBox.Show("Producto actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                        }
                        break;
                    }
            }
        }
    }
}
