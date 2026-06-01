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
    public partial class frmEmpleados : Form
    {
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        private int idEmpleado = 0;
        public frmEmpleados()
        {
            InitializeComponent();
            CargarEmpleados();

        }
        private void Limpiar()
        {
            idSeleccionado = 0;

            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtSueldo.Clear();
            txtBuscar.Clear();

            chkEstado.Checked = true;

            dtpFechaNacimiento.Value =
                DateTime.Now;

            dtpFechaIngreso.Value =
                DateTime.Now;
        }
        private void CargarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleadoDAO.Listar();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.Cedula = txtCedula.Text;
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;

            empleado.FechaNacimiento =
                dtpFechaNacimiento.Value;

            empleado.Telefono =
                txtTelefono.Text;

            empleado.Correo =
                txtCorreo.Text;

            empleado.FechaIngreso =
                dtpFechaIngreso.Value;

            empleado.Sueldo =
                Convert.ToDecimal(txtSalario.Text);

            empleado.Estado =
                chkEstado.Checked;

            if (empleadoDAO.Insertar(empleado))
            {
                MessageBox.Show("Empleado registrado");

                CargarEmpleados();

                Limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un empleado");

                return;
            }

            Empleado empleado = new Empleado();

            empleado.IdEmpleado =
                idSeleccionado;

            empleado.Cedula =
                txtCedula.Text;

            empleado.Nombre =
                txtNombre.Text;

            empleado.Apellido =
                txtApellido.Text;

            empleado.FechaNacimiento =
                dtpFechaNacimiento.Value;

            empleado.Telefono =
                txtTelefono.Text;

            empleado.Correo =
                txtCorreo.Text;

            empleado.FechaIngreso =
                dtpFechaIngreso.Value;

            empleado.Sueldo =
                Convert.ToDecimal(txtSalario.Text);

            empleado.Estado =
                chkEstado.Checked;

            if (empleadoDAO.Actualizar(empleado))
            {
                MessageBox.Show("Empleado actualizado");

                CargarEmpleados();

                Limpiar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un empleado");

                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "¿Eliminar empleado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                empleadoDAO.Eliminar(idSeleccionado);

                CargarEmpleados();

                Limpiar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
