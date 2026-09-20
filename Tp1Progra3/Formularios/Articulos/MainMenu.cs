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
using TPWinForm_equipoD.Formularios;

namespace TPWinForm_equipoD
{

    public partial class MainMenu : Form
    {
        
        private List<Imagen> listaImagenesActuales;
        private int indiceImagenActual = 0;
        private List<Articulo> listaArticulos;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();

                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            CargarDatos();
            cmbBuscarArticulo.Items.Add("Nombre");
            cmbBuscarArticulo.Items.Add("Código");
            cmbBuscarArticulo.Items.Add("Marca");
            cmbBuscarArticulo.Items.Add("Categoría");
            cmbBuscarArticulo.SelectedIndex = 0;
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (listaImagenesActuales != null && listaImagenesActuales.Count > 0)
            {
                indiceImagenActual++;

                if (indiceImagenActual >= listaImagenesActuales.Count)
                {
                    indiceImagenActual = 0;
                }

                MostrarImagenActual();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaImagenesActuales != null && listaImagenesActuales.Count > 0)
            {
                indiceImagenActual--;

                if (indiceImagenActual < 0)
                {
                    indiceImagenActual = listaImagenesActuales.Count - 1;
                }

                MostrarImagenActual();
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ImagenNegocio imagenNegocio = new ImagenNegocio();


                listaImagenesActuales = imagenNegocio.ListarPorArticulo(seleccionado.id);

                indiceImagenActual = 0;

                MostrarImagenActual();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo Ventana = new frmAltaArticulo();
            Ventana.ShowDialog();
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.Listar();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAltaImagen ventanaImagen = new frmAltaImagen(articuloSeleccionado);
                ventanaImagen.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo de la lista primero.");
            }
        }

        private void MostrarImagenActual()
        {
            try
            {
                if (listaImagenesActuales != null && listaImagenesActuales.Count > 0)
                {
                    pbxImagenProducto.Load(listaImagenesActuales[indiceImagenActual].urlimagen);
                }
                else
                {
                    pbxImagenProducto.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
            catch (Exception)
            {
                pbxImagenProducto.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro que desea eliminar el artículo \"" + seleccionado.nombre + "\" y todas sus imágenes?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();

                    try
                    {
                        negocio.Eliminar(seleccionado.id);
                        MessageBox.Show("Artículo eliminado correctamente.");
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
                MessageBox.Show("Por favor, seleccione un artículo de la lista primero.");
            }
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscarArticulo.Text.ToLower();
            string criterio = cmbBuscarArticulo.SelectedItem.ToString();
            List<Articulo> resultado;

            if (criterio == "Nombre")
                resultado = listaArticulos.Where(a => a.nombre.ToLower().Contains(textoBuscar)).ToList();
            else if (criterio == "Código")
                resultado = listaArticulos.Where(a => a.codigo.ToLower().Contains(textoBuscar)).ToList();
            else if (criterio == "Marca")
                resultado = listaArticulos.Where(a => a.marca.descripcion.ToLower().Contains(textoBuscar)).ToList();
            else
                resultado = listaArticulos.Where(a => a.categoria.descripcion.ToLower().Contains(textoBuscar)).ToList();

            dgvArticulos.DataSource = resultado;
        }

        private void btnLimpiarFiltroArticulo_Click(object sender, EventArgs e)
        {
            txtBuscarArticulo.Text = "";
            dgvArticulos.DataSource = listaArticulos;
        }

        private void tlsMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas ventanaMarcas = new frmMarcas();

            this.Hide();

            ventanaMarcas.Show();
        }

        private void tlsCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventanaCategorias = new frmCategorias();

            this.Hide();

            ventanaCategorias.Show();
        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmDetalleArticulo ventanaDetalle = new frmDetalleArticulo(articuloSeleccionado);
                ventanaDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo de la lista para ver su detalle.");
            }
        }

       
            private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado =
                    (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAltaArticulo ventana =
                    new frmAltaArticulo(seleccionado);

                ventana.ShowDialog(this);

                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = negocio.Listar();
            }
            else
            {
                MessageBox.Show("Seleccione un artículo.");
            }
        }
    }
}
