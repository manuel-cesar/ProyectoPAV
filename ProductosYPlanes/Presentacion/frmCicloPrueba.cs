using ProductosYPlanes.Negocio.Entidades;
using ProductosYPlanes.Negocio.Servicios;

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProductosYPlanes.Presentacion
{
    public partial class frmCicloPrueba : Form
    {
        private readonly CicloPruebaService cicloPruebaService;
        private readonly BindingList<CicloPruebaDetalle> listaCicloDetalle;
        private readonly UsuarioService usuarioService;
        private readonly PlanService planService;
        private readonly CasoPruebaService casoPruebaService;
        public frmCicloPrueba()
        {
            InitializeComponent();
            dgvCiclo.AutoGenerateColumns = false;

            cicloPruebaService = new CicloPruebaService();
            usuarioService = new UsuarioService();
            planService = new PlanService();
            casoPruebaService = new CasoPruebaService();

            listaCicloDetalle = new BindingList<CicloPruebaDetalle>();
        }

        private void frmCicloPrueba_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            LlenarCombo(cboPlan, planService.ConsultarTodos(), "nombre", "id_plan_prueba");
            LlenarCombo(cboResponsable, usuarioService.ObtenerTodos(), "usuario", "id_usuario");
            LlenarCombo(cboTester, usuarioService.ObtenerTodos(), "usuario", "id_usuario");
            LlenarCombo(cboCaso, casoPruebaService.ConsultarTodos(), "titulo", "id_caso_prueba");
            

            dgvCiclo.DataSource = listaCicloDetalle;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            btnAgregar.Enabled = false;
            cboPlan.SelectedIndex = -1;
            cboResponsable.SelectedIndex = -1;

            InicializarDetalle();

            dgvCiclo.DataSource = null;
        }

        private void InicializarDetalle()
        {
            txtHoras.Text = (0).ToString();
            cboCaso.SelectedIndex = -1;
            cboTester.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int horas = 0;
            int.TryParse(txtHoras.Text, out horas);

            var tester = (Usuario) cboTester.SelectedItem;
            var caso = (CasoPrueba)cboCaso.SelectedItem;
            var fecha = dtpFecha.Value;
            listaCicloDetalle.Add(new CicloPruebaDetalle()
            {
                Horas = horas,
                Tester = tester,
                CasoPrueba = caso,
                Fecha = fecha,
                Aceptado = true,
                Borrado = false,
            });

            InicializarDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                int newId = Convert.ToInt32(cicloPruebaService.consultarMaxId());
                newId++;

                var ciclo = new CicloPrueba
                {
                    Id_Ciclo_Prueba = newId,
                    Id_Plan_Prueba = cboPlan.SelectedIndex,
                    Fecha_Inicio = dtpInicio.Value,
                    Fecha_Fin = dtpFin.Value,
                    Id_Responsable = cboResponsable.SelectedIndex,
                    CicloPruebaDetalle = listaCicloDetalle,
                };

                if (cicloPruebaService.ValidarDatos(ciclo))
                {
                    cicloPruebaService.Crear(ciclo);
                    MessageBox.Show(string.Concat("El ciclo de Prueba:", ciclo.Id_Ciclo_Prueba, " Se guardo correctamente."), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InicializarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el Ciclo De Prueba! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCiclo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboCaso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaso.SelectedItem != null)
            {
                var caso = (CasoPrueba)cboCaso.SelectedItem;
                if(cboTester.SelectedItem != null)
                    btnAgregar.Enabled = true;
            }
            else
                btnAgregar.Enabled = false;

        }

        private void cboTester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTester.SelectedItem != null)
            {
                var tester = (Usuario)cboTester.SelectedItem;
                if (cboCaso.SelectedItem != null)
                    btnAgregar.Enabled = true;
            }
            else
                btnAgregar.Enabled = false;

        }
    }
}
    

