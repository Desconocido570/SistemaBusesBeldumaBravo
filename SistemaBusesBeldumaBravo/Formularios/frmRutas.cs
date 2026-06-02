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
    public partial class frmRutas : Form
    {
        private RutaDAO rutaDAO = new RutaDAO();

        private int idRutaSeleccionada = 0;
        public frmRutas()
        {
            InitializeComponent();
        }
        private void CargarRutas()
        {
            dgvRutas.DataSource =
                rutaDAO.Listar();
        }
        private void LimpiarCampos()
        {
            txtOrigen.Clear();
            txtDestino.Clear();
            txtDistancia.Clear();
            txtPrecio.Clear();

            idRutaSeleccionada = 0;
        }
        private void frmRutas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ruta ruta = new Ruta();

                ruta.Origen = txtOrigen.Text;
                ruta.Destino = txtDestino.Text;
                ruta.Distancia = Convert.ToDecimal(txtDistancia.Text);
                ruta.Precio = Convert.ToDecimal(txtPrecio.Text);

                if (rutaDAO.Insertar(ruta))
                {
                    MessageBox.Show(
                        "Ruta registrada correctamente");

                    CargarRutas();

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
            if (idRutaSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una ruta");

                return;
            }

            Ruta ruta = new Ruta();

            ruta.IdRuta = idRutaSeleccionada;
            ruta.Origen = txtOrigen.Text;
            ruta.Destino = txtDestino.Text;
            ruta.Distancia = Convert.ToDecimal(txtDistancia.Text);
            ruta.Precio = Convert.ToDecimal(txtPrecio.Text);

            if (rutaDAO.Actualizar(ruta))
            {
                MessageBox.Show(
                    "Ruta actualizada correctamente");

                CargarRutas();

                LimpiarCampos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idRutaSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una ruta");

                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "¿Eliminar ruta?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (rutaDAO.Eliminar(idRutaSeleccionada))
                {
                    MessageBox.Show(
                        "Ruta eliminada");

                    CargarRutas();

                    LimpiarCampos();
                }
            }
        }

        private void dgvRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvRutas.Rows[e.RowIndex];

            idRutaSeleccionada =
                Convert.ToInt32(
                fila.Cells["IdRuta"].Value);

            txtOrigen.Text =
                fila.Cells["Origen"].Value.ToString();

            txtDestino.Text =
                fila.Cells["Destino"].Value.ToString();

            txtDistancia.Text =
                fila.Cells["Distancia"].Value.ToString();

            txtPrecio.Text =
                fila.Cells["Precio"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla =
      rutaDAO.Listar();

            tabla.DefaultView.RowFilter =
                $"Origen LIKE '%{txtBuscar.Text}%' OR Destino LIKE '%{txtBuscar.Text}%'";

            dgvRutas.DataSource =
                tabla;
        }
    }
}
