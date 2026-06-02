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

private int idEmpleadoSeleccionado;
        public frmEmpleados()
        {
            InitializeComponent();

        }

        private void CargarEmpleados()
        {
            dgvEmpleados.DataSource =
                empleadoDAO.Listar();
        }
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtSueldo.Clear();

            dtpFechaNacimiento.Value =
                DateTime.Now;

            dtpFechaIngreso.Value =
                DateTime.Now;

            chkEstado.Checked = false;

            idEmpleadoSeleccionado = 0;
        }



        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado();

                empleado.Cedula = txtCedula.Text;
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Telefono = txtTelefono.Text;
                empleado.Correo = txtCorreo.Text;

                empleado.FechaNacimiento =
                    dtpFechaNacimiento.Value;

                empleado.FechaIngreso =
                    dtpFechaIngreso.Value;

                empleado.Sueldo =
                    decimal.Parse(txtSueldo.Text);

                empleado.Estado =
                    chkEstado.Checked;

                if (empleadoDAO.Insertar(empleado))
                {
                    MessageBox.Show(
                        "Empleado guardado correctamente");

                    CargarEmpleados();

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
            if (idEmpleadoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un empleado");
                return;
            }

            Empleado empleado = new Empleado();

            empleado.IdEmpleado =
                idEmpleadoSeleccionado;

            empleado.Cedula =
                txtCedula.Text;

            empleado.Nombre =
                txtNombre.Text;

            empleado.Apellido =
                txtApellido.Text;

            empleado.Telefono =
                txtTelefono.Text;

            empleado.Correo =
                txtCorreo.Text;

            empleado.FechaNacimiento =
                dtpFechaNacimiento.Value;

            empleado.FechaIngreso =
                dtpFechaIngreso.Value;

            empleado.Sueldo =
                decimal.Parse(txtSueldo.Text);

            empleado.Estado =
                chkEstado.Checked;

            if (empleadoDAO.Actualizar(empleado))
            {
                MessageBox.Show(
                    "Empleado actualizado");

                CargarEmpleados();

                LimpiarCampos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un empleado");
                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "¿Desea eliminar este empleado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (empleadoDAO.Eliminar(txtCedula.Text))
                {
                    MessageBox.Show(
                        "Empleado eliminado");

                    CargarEmpleados();

                    LimpiarCampos();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                CargarEmpleados();
                return;
            }

            Empleado empleado =
                empleadoDAO.BuscarPorCedula(
                    txtBuscar.Text.Trim());

            if (empleado != null)
            {
                txtCedula.Text = empleado.Cedula;
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtTelefono.Text = empleado.Telefono;
                txtCorreo.Text = empleado.Correo;

                dtpFechaNacimiento.Value =
                    empleado.FechaNacimiento;

                dtpFechaIngreso.Value =
                    empleado.FechaIngreso;

                txtSueldo.Text =
                    empleado.Sueldo.ToString();

                chkEstado.Checked =
                    empleado.Estado;

                idEmpleadoSeleccionado =
                    empleado.IdEmpleado;
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvEmpleados.Rows[e.RowIndex];

            idEmpleadoSeleccionado =
                Convert.ToInt32(
                fila.Cells["IdEmpleado"].Value);

            txtCedula.Text =
                fila.Cells["Cedula"].Value.ToString();

            txtNombre.Text =
                fila.Cells["Nombre"].Value.ToString();

            txtApellido.Text =
                fila.Cells["Apellido"].Value.ToString();

            txtTelefono.Text =
                fila.Cells["Telefono"].Value.ToString();

            txtCorreo.Text =
                fila.Cells["Correo"].Value.ToString();

            dtpFechaNacimiento.Value =
                Convert.ToDateTime(
                fila.Cells["FechaNacimiento"].Value);

            dtpFechaIngreso.Value =
                Convert.ToDateTime(
                fila.Cells["FechaIngreso"].Value);

            txtSueldo.Text =
                fila.Cells["Sueldo"].Value.ToString();

            chkEstado.Checked =
                Convert.ToBoolean(
                fila.Cells["Estado"].Value);
        }
    }
}
