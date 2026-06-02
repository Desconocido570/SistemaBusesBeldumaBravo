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
    public partial class frmBoletos : Form
    {
        private BoletoDAO boletoDAO = new BoletoDAO();
        private PasajeroDAO pasajeroDAO = new PasajeroDAO();
        private ViajeDAO viajeDAO = new ViajeDAO();

        private int idBoletoSeleccionado = 0;
        public frmBoletos()
        {
            InitializeComponent();
        }

        private void frmBoletos_Load(object sender, EventArgs e)
        {
            CargarBoletos();
            CargarPasajeros();
            CargarViajes();

        }
        private void LimpiarCampos()
        {
            txtNumAsiento.Clear();
            txtValor.Clear();

            dtpFechaCompra.Value =
                DateTime.Now;

            idBoletoSeleccionado = 0;
        }
        private void CargarViajes()
        {
            cmbViaje.DataSource =
                viajeDAO.Listar();

            cmbViaje.DisplayMember = "IdViaje";
            cmbViaje.ValueMember = "IdViaje";
        }
        private void CargarBoletos()
        {
            dgvBoletos.DataSource =
                boletoDAO.Listar();
        }
        private void CargarPasajeros()
        {
            cmbPasajero.DataSource =
                pasajeroDAO.Listar();

            cmbPasajero.DisplayMember = "Nombre";
            cmbPasajero.ValueMember = "IdPasajero";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Boleto boleto = new Boleto();

                boleto.IdPasajero =
                    Convert.ToInt32(cmbPasajero.SelectedValue);

                boleto.IdViaje =
                    Convert.ToInt32(cmbViaje.SelectedValue);

                boleto.NumeroAsiento =
                    Convert.ToInt32(txtNumAsiento.Text);

                boleto.Valor =
                    Convert.ToDecimal(txtValor.Text);

                boleto.FechaCompra =
                    dtpFechaCompra.Value;

                if (boletoDAO.Insertar(boleto))
                {
                    MessageBox.Show(
                        "Boleto registrado correctamente");

                    CargarBoletos();

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
            if (idBoletoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un boleto");

                return;
            }

            Boleto boleto = new Boleto();

            boleto.IdBoleto = idBoletoSeleccionado;

            boleto.IdPasajero =
                Convert.ToInt32(cmbPasajero.SelectedValue);

            boleto.IdViaje =
                Convert.ToInt32(cmbViaje.SelectedValue);

            boleto.NumeroAsiento =
                Convert.ToInt32(txtNumAsiento.Text);

            boleto.Valor =
                Convert.ToDecimal(txtValor.Text);

            boleto.FechaCompra =
                dtpFechaCompra.Value;

            if (boletoDAO.Actualizar(boleto))
            {
                MessageBox.Show(
                    "Boleto actualizado");

                CargarBoletos();

                LimpiarCampos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idBoletoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un boleto");

                return;
            }

            if (boletoDAO.Eliminar(idBoletoSeleccionado))
            {
                MessageBox.Show(
                    "Boleto eliminado");

                CargarBoletos();

                LimpiarCampos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvBoletos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvBoletos.Rows[e.RowIndex];

            idBoletoSeleccionado =
                Convert.ToInt32(
                fila.Cells["IdBoleto"].Value);

            cmbPasajero.SelectedValue =
                Convert.ToInt32(
                fila.Cells["IdPasajero"].Value);

            cmbViaje.SelectedValue =
                Convert.ToInt32(
                fila.Cells["IdViaje"].Value);

            txtNumAsiento.Text =
                fila.Cells["NumeroAsiento"].Value.ToString();

            txtValor.Text =
                fila.Cells["Valor"].Value.ToString();

            dtpFechaCompra.Value =
                Convert.ToDateTime(
                fila.Cells["FechaCompra"].Value);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla =
       boletoDAO.Listar();

            tabla.DefaultView.RowFilter =
                $"Convert(IdBoleto, 'System.String') LIKE '%{txtBuscar.Text}%'";

            dgvBoletos.DataSource =
                tabla;
        }
    }
}
