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
    public partial class frmPasajeros : Form
    {
        private PasajeroDAO pasajeroDAO = new PasajeroDAO();

        private int idPasajeroSeleccionado = 0;
        public frmPasajeros()
        {
            InitializeComponent();
        }

        private void frmPasajeros_Load(object sender, EventArgs e)
        {
            CargarPasajeros();

        }
        private void CargarPasajeros()
        {
            dgvPasajeros.DataSource =
                pasajeroDAO.Listar();
        }
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();

            idPasajeroSeleccionado = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pasajero pasajero = new Pasajero();

            pasajero.Cedula = txtCedula.Text;
            pasajero.Nombre = txtNombre.Text;
            pasajero.Apellido = txtApellido.Text;
            pasajero.Telefono = txtTelefono.Text;

            if (pasajeroDAO.Insertar(pasajero))
            {
                MessageBox.Show("Pasajero registrado");

                CargarPasajeros();

                LimpiarCampos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idPasajeroSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un pasajero");
                return;
            }

            Pasajero pasajero = new Pasajero();

            pasajero.IdPasajero = idPasajeroSeleccionado;
            pasajero.Cedula = txtCedula.Text;
            pasajero.Nombre = txtNombre.Text;
            pasajero.Apellido = txtApellido.Text;
            pasajero.Telefono = txtTelefono.Text;

            if (pasajeroDAO.Actualizar(pasajero))
            {
                MessageBox.Show("Pasajero actualizado");

                CargarPasajeros();

                LimpiarCampos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idPasajeroSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un pasajero");
                return;
            }

            if (pasajeroDAO.Eliminar(idPasajeroSeleccionado))
            {
                MessageBox.Show("Pasajero eliminado");

                CargarPasajeros();

                LimpiarCampos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void dgvPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvPasajeros.Rows[e.RowIndex];

            idPasajeroSeleccionado =
                Convert.ToInt32(
                fila.Cells["IdPasajero"].Value);

            txtCedula.Text =
                fila.Cells["Cedula"].Value.ToString();

            txtNombre.Text =
                fila.Cells["Nombre"].Value.ToString();

            txtApellido.Text =
                fila.Cells["Apellido"].Value.ToString();

            txtTelefono.Text =
                fila.Cells["Telefono"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla =
        pasajeroDAO.Listar();

            tabla.DefaultView.RowFilter =
                $"Cedula LIKE '%{txtBuscar.Text}%' OR Nombre LIKE '%{txtBuscar.Text}%'";

            dgvPasajeros.DataSource =
                tabla;
        }
    }
}
