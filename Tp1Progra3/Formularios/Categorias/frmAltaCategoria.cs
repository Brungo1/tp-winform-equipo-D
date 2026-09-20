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
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoriaActual = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categoria categoriaSeleccionada)
        {
            InitializeComponent();
            this.categoriaActual = categoriaSeleccionada;

            txtDescripcion.Text = categoriaActual.descripcion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la categoría.");
                    return;
                }
                if (categoriaActual == null)
                {
                    Categoria nueva = new Categoria();
                    nueva.descripcion = txtDescripcion.Text;
                    negocio.Agregar(nueva);
                    MessageBox.Show("Agregado exitosamente.");
                }
                else
                {
                    categoriaActual.descripcion = txtDescripcion.Text;
                    negocio.Modificar(categoriaActual);
                    MessageBox.Show("Modificado exitosamente.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar agregar: " + ex.Message);
            }
        }
    }
}
