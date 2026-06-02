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
    public partial class frmBuses : Form
    {
        private BusDAO busDAO = new BusDAO();

        private int idBusSeleccionado = 0;
        public frmBuses()
        {
            InitializeComponent();
           
        }

        private void frmBuses_Load(object sender, EventArgs e)
        {
            CargarBuses();

            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("En Ruta");
            cmbEstado.Items.Add("Mantenimiento");

            cmbEstado.SelectedIndex = 0;
        }
        private void CargarBuses()
        {
            dgvBuses.DataSource =
                busDAO.Listar();
        }
        private void LimpiarCampos()
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAnio.Clear();
            txtCapacidad.Clear();

            cmbEstado.SelectedIndex = 0;

            idBusSeleccionado = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bus bus = new Bus();

                bus.Placa = txtPlaca.Text;
                bus.Marca = txtMarca.Text;
                bus.Modelo = txtModelo.Text;
                bus.Anio = Convert.ToInt32(txtAnio.Text);
                bus.Capacidad = Convert.ToInt32(txtCapacidad.Text);
                bus.Estado = cmbEstado.Text;

                if (busDAO.Insertar(bus))
                {
                    MessageBox.Show(
                        "Bus registrado correctamente");

                    CargarBuses();

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
            if (idBusSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un bus");

                return;
            }

            Bus bus = new Bus();

            bus.IdBus = idBusSeleccionado;
            bus.Placa = txtPlaca.Text;
            bus.Marca = txtMarca.Text;
            bus.Modelo = txtModelo.Text;
            bus.Anio = Convert.ToInt32(txtAnio.Text);
            bus.Capacidad = Convert.ToInt32(txtCapacidad.Text);
            bus.Estado = cmbEstado.Text;

            if (busDAO.Actualizar(bus))
            {
                MessageBox.Show(
                    "Bus actualizado correctamente");

                CargarBuses();

                LimpiarCampos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idBusSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un bus");

                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "¿Desea eliminar este bus?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (busDAO.Eliminar(idBusSeleccionado))
                {
                    MessageBox.Show(
                        "Bus eliminado");

                    CargarBuses();

                    LimpiarCampos();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void dgvBuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvBuses.Rows[e.RowIndex];

            idBusSeleccionado =
                Convert.ToInt32(
                fila.Cells["IdBus"].Value);

            txtPlaca.Text =
                fila.Cells["Placa"].Value.ToString();

            txtMarca.Text =
                fila.Cells["Marca"].Value.ToString();

            txtModelo.Text =
                fila.Cells["Modelo"].Value.ToString();

            txtAnio.Text =
                fila.Cells["Anio"].Value.ToString();

            txtCapacidad.Text =
                fila.Cells["Capacidad"].Value.ToString();

            cmbEstado.Text =
                fila.Cells["Estado"].Value.ToString();
        }
    }
}
