﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosYPlanes.Presentacion.Informes.Tester
{
    public partial class frmTester : Form
    {
        public frmTester()
        {
            InitializeComponent();
        }

        private void frmTester_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTester.Testers' Puede moverla o quitarla según sea necesario.
            this.TestersTableAdapter.Fill(this.dsTester.Testers);

            this.reportViewer1.RefreshReport();
        }
    }
}
