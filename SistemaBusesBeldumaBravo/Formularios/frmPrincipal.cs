using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBusesBeldumaBravo.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        
            Application.Exit();
        }

        private void conductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConductores frm = new frmConductores();
            frm.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.Show();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuses frm = new frmBuses();
            frm.Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRutas frm = new frmRutas();
            frm.Show();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViajes frm = new frmViajes();
            frm.Show();
        }

        private void pasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasajeros frm = new frmPasajeros();
            frm.Show();
        }

        private void boletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoletos frm = new frmBoletos();
            frm.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora frm = new frmBitacora();
            frm.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.Show();
        }
    }
    }

