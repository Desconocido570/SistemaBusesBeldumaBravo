using SistemaBusesBeldumaBravo.Datos;
using SistemaBusesBeldumaBravo.Entidades;
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
    public partial class frmConductores : Form
    {
        private ConductorDAO conductorDAO = new ConductorDAO();
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();

        private int idConductorSeleccionado = 0;
        public frmConductores()
        {
            InitializeComponent();
            CargarConductores();
            CargarEmpleados();
        }
        private void CargarConductores()
        {
            dgvConductores.DataSource =
                conductorDAO.Listar();
        }
        private void CargarEmpleados()
        {
            DataTable tabla =
                empleadoDAO.Listar();

            cmbEmpleado.DataSource = tabla;

            cmbEmpleado.DisplayMember = "Nombre";

            cmbEmpleado.ValueMember = "IdEmpleado";
        }
        private void LimpiarCampos()
        {
            txtLicencia.Clear();
            txtTipoLicencia.Clear();

            dtpFechaVencimiento.Value =
                DateTime.Now;

            idConductorSeleccionado = 0;
        }
        private void frmConductores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conductor conductor = new Conductor();

                conductor.IdEmpleado =
                    Convert.ToInt32(cmbEmpleado.SelectedValue);

                conductor.Licencia =
                    txtLicencia.Text;

                conductor.TipoLicencia =
                    txtTipoLicencia.Text;

                conductor.FechaVencimiento =
                    dtpFechaVencimiento.Value;

                if (conductorDAO.Insertar(conductor))
                {
                    MessageBox.Show(
                        "Conductor registrado correctamente");

                    CargarConductores();

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idConductorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un conductor");

                return;
            }

            Conductor conductor = new Conductor();

            conductor.IdConductor =
                idConductorSeleccionado;

            conductor.IdEmpleado =
                Convert.ToInt32(cmbEmpleado.SelectedValue);

            conductor.Licencia =
                txtLicencia.Text;

            conductor.TipoLicencia =
                txtTipoLicencia.Text;

            conductor.FechaVencimiento =
                dtpFechaVencimiento.Value;

            if (conductorDAO.Actualizar(conductor))
            {
                MessageBox.Show(
                    "Conductor actualizado");

                CargarConductores();

                LimpiarCampos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idConductorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un conductor");

                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "¿Eliminar conductor?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (conductorDAO.Eliminar(
                    idConductorSeleccionado))
                {
                    MessageBox.Show(
                        "Conductor eliminado");

                    CargarConductores();

                    LimpiarCampos();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void dgvConductores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvConductores.Rows[e.RowIndex];

            idConductorSeleccionado =
                Convert.ToInt32(
                fila.Cells["IdConductor"].Value);

            cmbEmpleado.SelectedValue =
                Convert.ToInt32(
                fila.Cells["IdEmpleado"].Value);

            txtLicencia.Text =
                fila.Cells["Licencia"].Value.ToString();

            txtTipoLicencia.Text =
                fila.Cells["TipoLicencia"].Value.ToString();

            dtpFechaVencimiento.Value =
                Convert.ToDateTime(
                fila.Cells["FechaVencimiento"].Value);
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla =
       conductorDAO.Listar();

            tabla.DefaultView.RowFilter =
                $"Licencia LIKE '%{txtBuscar.Text}%'";

            dgvConductores.DataSource =
                tabla;
        }
    }
}
