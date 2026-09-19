using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipoD.Formularios
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo;
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private List<Imagen> listaImagenes = new List<Imagen>();
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        private bool ValidarAlta()
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un código.");
                txtCodigo.Focus();
                return false;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre.");
                txtNombre.Focus();
                return false;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripción.");
                txtDescripcion.Focus();
                return false;
            }

            if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un precio.");
                txtPrecio.Focus();
                return false;
            }

            decimal precio;

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser numérico.");
                txtPrecio.Focus();
                return false;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.");
                txtPrecio.Focus();
                return false;
            }

            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarAlta())
                return;

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.codigo = txtCodigo.Text.Trim();
                articulo.nombre = txtNombre.Text.Trim();
                articulo.descripcion = txtDescripcion.Text.Trim();
                articulo.marca = (Marca)cboIdMarca.SelectedItem;
                articulo.categoria = (Categoria)cboIdCategoria.SelectedItem;
                articulo.precio = decimal.Parse(txtPrecio.Text);

                if (articulo.id != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Artículo modificado correctamente");
                }
                else
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Artículo agregado correctamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboIdMarca.DataSource = marcaNegocio.Listar();
                cboIdMarca.ValueMember = "id";
                cboIdMarca.DisplayMember = "descripcion";

                cboIdCategoria.DataSource = categoriaNegocio.Listar();
                cboIdCategoria.ValueMember = "id";
                cboIdCategoria.DisplayMember = "descripcion";

                if (articulo != null)
                {
                    Text = "Modificar Artículo";

                    txtCodigo.Text = articulo.codigo;
                    txtNombre.Text = articulo.nombre;
                    txtDescripcion.Text = articulo.descripcion;
                    txtPrecio.Text = articulo.precio.ToString();

                    cboIdMarca.SelectedValue = articulo.marca.id;
                    cboIdCategoria.SelectedValue = articulo.categoria.id;
                }
                else
                {
                    cboIdMarca.SelectedIndex = 0;
                    cboIdCategoria.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

