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
    public partial class frmUsuarios : Form
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        private int idUsuarioSeleccionado = 0;
        public frmUsuarios()
        {

            InitializeComponent();
        }
        private void Limpiar()
        {
            txtUsuario.Clear();
            txtClave.Clear();

            chkEstado.Checked = true;

            idUsuarioSeleccionado = 0;
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = usuarioDAO.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Clave = txtClave.Text;

            usuario.IdRol =
                Convert.ToInt32(cmbRol.SelectedValue);

            usuario.Estado = chkEstado.Checked;

            if (usuarioDAO.Insertar(usuario))
            {
                MessageBox.Show("Usuario guardado correctamente");

                CargarUsuarios();

                Limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            Usuario usuario = new Usuario();

            usuario.IdUsuario = idUsuarioSeleccionado;
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Clave = txtClave.Text;
            usuario.Estado = chkEstado.Checked;

            if (usuarioDAO.Actualizar(usuario))
            {
                MessageBox.Show("Usuario actualizado");

                CargarUsuarios();

                Limpiar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Eliminar usuario?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                usuarioDAO.Eliminar(idUsuarioSeleccionado);

                CargarUsuarios();

                Limpiar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             dgvUsuarios.DataSource =
        usuarioDAO.Buscar(txtUsuario.Text);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["IdUsuario"].Value);

                txtUsuario.Text =
                    fila.Cells["Usuario"].Value.ToString();

                txtClave.Text =
                    fila.Cells["Clave"].Value.ToString();

                chkEstado.Checked =
                    Convert.ToBoolean(
                        fila.Cells["Estado"].Value);
            }
        }
    }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
