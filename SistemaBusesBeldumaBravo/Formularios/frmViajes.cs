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
    public partial class frmViajes : Form
    {
        private ViajeDAO viajeDAO = new ViajeDAO();
        private BusDAO busDAO = new BusDAO();
        private ConductorDAO conductorDAO = new ConductorDAO();
        private RutaDAO rutaDAO = new RutaDAO();

        private int idViajeSeleccionado = 0;
        public frmViajes()
        {
            InitializeComponent();
        }
        private void CargarViajes()
        {
            dgvViajes.DataSource =
                viajeDAO.Listar();
        }
        private void CargarBuses()
        {
            cmbBus.DataSource =
                busDAO.Listar();

            cmbBus.DisplayMember = "Placa";
            cmbBus.ValueMember = "IdBus";
        }
        private void CargarConductores()
        {
            cmbConductor.DataSource =
                conductorDAO.Listar();

            cmbConductor.DisplayMember = "Licencia";
            cmbConductor.ValueMember = "IdConductor";
        }
        private void CargarRutas()
        {
            cmbRuta.DataSource =
                rutaDAO.Listar();

            cmbRuta.DisplayMember = "Origen";
            cmbRuta.ValueMember = "IdRuta";
        }
        private void LimpiarCampos()
        {
            idViajeSeleccionado = 0;

            dtpFechaSalida.Value = DateTime.Now;
            dtpFechaLlegada.Value = DateTime.Now;

            cmbEstado.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Viaje viaje = new Viaje();

                viaje.IdBus =
                    Convert.ToInt32(cmbBus.SelectedValue);

                viaje.IdConductor =
                    Convert.ToInt32(cmbConductor.SelectedValue);

                viaje.IdRuta =
                    Convert.ToInt32(cmbRuta.SelectedValue);

                viaje.FechaSalida =
                    dtpFechaSalida.Value;

                viaje.FechaLlegada =
                    dtpFechaLlegada.Value;

                viaje.Estado =
                    cmbEstado.Text;

                if (viajeDAO.Insertar(viaje))
                {
                    MessageBox.Show(
                        "Viaje registrado correctamente");

                    CargarViajes();

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmViajes_Load(object sender, EventArgs e)
        {
            CargarViajes();
            CargarBuses();
            CargarConductores();
            CargarRutas();

            cmbEstado.Items.Add("Programado");
            cmbEstado.Items.Add("En Ruta");
            cmbEstado.Items.Add("Finalizado");
            cmbEstado.Items.Add("Cancelado");

            cmbEstado.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idViajeSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un viaje");

                return;
            }

            Viaje viaje = new Viaje();

            viaje.IdViaje = idViajeSeleccionado;

            viaje.IdBus =
                Convert.ToInt32(cmbBus.SelectedValue);

            viaje.IdConductor =
                Convert.ToInt32(cmbConductor.SelectedValue);

            viaje.IdRuta =
                Convert.ToInt32(cmbRuta.SelectedValue);

            viaje.FechaSalida =
                dtpFechaSalida.Value;

            viaje.FechaLlegada =
                dtpFechaLlegada.Value;

            viaje.Estado =
                cmbEstado.Text;

            if (viajeDAO.Actualizar(viaje))
            {
                MessageBox.Show(
                    "Viaje actualizado");

                CargarViajes();

                LimpiarCampos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idViajeSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un viaje");

                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "¿Eliminar viaje?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (viajeDAO.Eliminar(idViajeSeleccionado))
                {
                    MessageBox.Show(
                        "Viaje eliminado");

                    CargarViajes();

                    LimpiarCampos();
                }
            }
        }

        private void dgvViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvViajes.Rows[e.RowIndex];

            idViajeSeleccionado =
                Convert.ToInt32(
                fila.Cells["IdViaje"].Value);

            cmbBus.SelectedValue =
                Convert.ToInt32(
                fila.Cells["IdBus"].Value);

            cmbConductor.SelectedValue =
                Convert.ToInt32(
                fila.Cells["IdConductor"].Value);

            cmbRuta.SelectedValue =
                Convert.ToInt32(
                fila.Cells["IdRuta"].Value);

            dtpFechaSalida.Value =
                Convert.ToDateTime(
                fila.Cells["FechaSalida"].Value);

            dtpFechaLlegada.Value =
                Convert.ToDateTime(
                fila.Cells["FechaLlegada"].Value);

            cmbEstado.Text =
                fila.Cells["Estado"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla =
       viajeDAO.Listar();

            tabla.DefaultView.RowFilter =
                $"Estado LIKE '%{txtBuscar.Text}%'";

            dgvViajes.DataSource =
                tabla;
        }
    }
}
