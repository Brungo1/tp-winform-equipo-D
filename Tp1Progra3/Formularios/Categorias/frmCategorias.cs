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
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategorias;
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro que desea eliminar la categoría \"" + seleccionada.descripcion + "\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();

                    try
                    {
                        negocio.Eliminar(seleccionada.id);
                        MessageBox.Show("Categoría eliminada correctamente.");
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
                MessageBox.Show("Por favor, seleccione una categoría de la lista primero.");
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscarCategoria.Text.ToLower();
            List<Categoria> resultado = listaCategorias.Where(c => c.descripcion.ToLower().Contains(textoBuscar)).ToList();
            dgvCategoria.DataSource = resultado;
        }

        private void btnLimpiarFiltroCategoria_Click(object sender, EventArgs e)
        {
            txtBuscarCategoria.Text = "";
            dgvCategoria.DataSource = listaCategorias;
        }

        private void tlsArticulos_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainMenu"].Show();
            this.Close();
        }

        private void tlsMarcasC_Click(object sender, EventArgs e)
        {
            
            frmMarcas frmMarcas = new frmMarcas();
            frmMarcas.Show();
            this.Close();

        }

        private void frmCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmMarcas"] == null)
            {
                Application.OpenForms["MainMenu"].Show();
            }
        }
        private void CargarDatos()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategorias = negocio.Listar();

                dgvCategoria.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
            {
                CargarDatos();
            }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria frmAltaCategoria = new frmAltaCategoria();
            frmAltaCategoria.ShowDialog();
            CargarDatos();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

                frmAltaCategoria modificar = new frmAltaCategoria(seleccionada);
                modificar.ShowDialog();
                CargarDatos();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría para modificar.");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["MainMenu"].Close();
        }
    }
}
