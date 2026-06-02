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
    public partial class frmBitacora : Form
    {
        private BitacoraDAO bitacoraDAO =
    new BitacoraDAO();
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            CargarBitacora();
        }
        private void CargarBitacora()
        {
            dgvBitacora.DataSource =
                bitacoraDAO.Listar();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla =
        bitacoraDAO.Listar();

            tabla.DefaultView.RowFilter =
                $"Usuario LIKE '%{txtBuscar.Text}%' OR Accion LIKE '%{txtBuscar.Text}%'";

            dgvBitacora.DataSource =
                tabla;
        }
    }
}
