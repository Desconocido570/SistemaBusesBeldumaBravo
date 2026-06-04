using SistemaBusesBeldumaBravo.Datos;
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
    public partial class frmReportes : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        ConductorDAO conductorDAO = new ConductorDAO();
        BusDAO busDAO = new BusDAO();
        RutaDAO rutaDAO = new RutaDAO();
        ViajeDAO viajeDAO = new ViajeDAO();
        PasajeroDAO pasajeroDAO = new PasajeroDAO();
        BoletoDAO boletoDAO = new BoletoDAO();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            cmbReporte.Items.Add("Usuarios");
            cmbReporte.Items.Add("Empleados");
            cmbReporte.Items.Add("Conductores");
            cmbReporte.Items.Add("Buses");
            cmbReporte.Items.Add("Rutas");
            cmbReporte.Items.Add("Viajes");
            cmbReporte.Items.Add("Pasajeros");
            cmbReporte.Items.Add("Boletos");

            cmbReporte.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (cmbReporte.Text)
            {
                case "Usuarios":
                    dgvReportes.DataSource =
                        usuarioDAO.Listar();
                    break;

                case "Empleados":
                    dgvReportes.DataSource =
                        empleadoDAO.Listar();
                    break;

                case "Conductores":
                    dgvReportes.DataSource =
                        conductorDAO.Listar();
                    break;

                case "Buses":
                    dgvReportes.DataSource =
                        busDAO.Listar();
                    break;

                case "Rutas":
                    dgvReportes.DataSource =
                        rutaDAO.Listar();
                    break;

                case "Viajes":
                    dgvReportes.DataSource =
                        viajeDAO.Listar();
                    break;

                case "Pasajeros":
                    dgvReportes.DataSource =
                        pasajeroDAO.Listar();
                    break;

                case "Boletos":
                    dgvReportes.DataSource =
                        boletoDAO.Listar();
                    break;
            }
        }
    }
}
