using ProductosYPlanes.Datos.Conexion;
using ProductosYPlanes.Negocio.Entidades;
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
    public partial class frmCicloPrueba : Form
    {
        public frmCicloPrueba()
        {
            InitializeComponent();
            LlenarCombo(cboPlan, "PlanesDePrueba", "nombre", "id_plan_prueba");
            LlenarCombo(cboResponsable, "Usuarios", "usuario", "id_usuario");
            LlenarCombo(cboTester, "Usuarios", "usuario", "id_usuario");
            LlenarCombo(cboCaso, "CasosDePrueba", "titulo", "id_caso_prueba");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCicloPrueba_Load(object sender, EventArgs e)
        {

        }

        private void LlenarCombo(ComboBox cbo, string tabla, string display, string value)
        {
            cbo.DataSource = DBHelper.getDBHelper().ConsultarTabla(tabla);
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            btnCrear.Enabled = false;

            InicializarDetalle();
            dgvCiclo.DataSource = null;            
        }

        private void InicializarDetalle()
        {
            cboTester.SelectedIndex = -1;
        }


        }
    }

