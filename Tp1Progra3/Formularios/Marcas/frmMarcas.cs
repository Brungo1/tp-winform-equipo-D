using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipoD.Formularios
{
    public partial class frmMarcas : Form
    {
        List<Marca> listaMarcas;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarcas = negocio.Listar();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro que desea eliminar la marca \"" + seleccionada.descripcion + "\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    MarcaNegocio negocio = new MarcaNegocio();

                    try
                    {
                        negocio.Eliminar(seleccionada.id);
                        MessageBox.Show("Marca eliminada correctamente.");
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una marca de la lista primero.");
            }
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscarMarca.Text.ToLower();
            List<Marca> resultado = listaMarcas.Where(m => m.descripcion.ToLower().Contains(textoBuscar)).ToList();
            dgvMarcas.DataSource = resultado;
        }

        private void btnLimpiarFiltroMarca_Click(object sender, EventArgs e)
        {
            txtBuscarMarca.Text = "";
            dgvMarcas.DataSource = listaMarcas;
        }

        private void tlsCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias();
            frmCategorias.Show();
            this.Close();
        }

        private void tlsArticulos_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainMenu"].Show();
            this.Close();
        }

        private void frmMarcas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmCategorias"] == null)
            {
                Application.OpenForms["MainMenu"].Show();
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarca frmAltaMarca = new frmAltaMarca();
            frmAltaMarca.ShowDialog();
            CargarDatos();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                frmAltaMarca modificar = new frmAltaMarca(seleccionada);
                modificar.ShowDialog();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una marca para modificar.");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["MainMenu"].Close();
        }
    }
}
