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
    public partial class frmAltaMarca : Form
    {
        private Marca marcaActual = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marcaSeleccionada)
        {
            InitializeComponent();
            this.marcaActual = marcaSeleccionada;

            txtDescripcion.Text = marcaActual.descripcion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la marca.");
                    return;
                }

                if (marcaActual == null)
                {
                    Marca nueva = new Marca();
                    nueva.descripcion = txtDescripcion.Text;
                    negocio.Agregar(nueva);
                    MessageBox.Show("Agregado exitosamente.");
                }

                else
                {
                    marcaActual.descripcion = txtDescripcion.Text;
                    negocio.Modificar(marcaActual);
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
