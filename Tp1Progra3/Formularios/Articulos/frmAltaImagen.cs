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

namespace TPWinForm_equipoD
{
    public partial class frmAltaImagen : Form
    {
        private Articulo articuloLocal = null;
        private Imagen imagenActual = null;
        public frmAltaImagen(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloLocal = articuloSeleccionado;
        }

        public frmAltaImagen(Imagen imagenSeleccionada)
        {
            InitializeComponent();
            this.imagenActual = imagenSeleccionada;

            txtUrlImagen.Text = imagenActual.urlimagen;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {

                if (string.IsNullOrWhiteSpace(txtUrlImagen.Text))
                {
                    MessageBox.Show("Por favor, ingrese la URL de la imagen.");
                    return;
                }

                if (imagenActual == null)
                {
                    Imagen nueva = new Imagen();
                    nueva.idarticulo = articuloLocal.id;
                    nueva.urlimagen = txtUrlImagen.Text;
                    negocio.Agregar(nueva);
                    MessageBox.Show("Imagen agregada.");
                }

                else
                {
                    imagenActual.urlimagen = txtUrlImagen.Text;
                    negocio.Modificar(imagenActual);
                    MessageBox.Show("Imagen modificada.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar la imagen: " + ex.Message);
            }
        }
    }
}
