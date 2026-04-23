using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_Equipo7A {
    public partial class frmDetalleArticulo : Form {
        private Articulo articulo;

        public frmDetalleArticulo(Articulo articulo) {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e) {
            lblId.Text = "ID: " + articulo.Id.ToString();
            lblCodigo.Text = "Código: " + articulo.Codigo;
            lblNombre.Text = "Nombre: " + articulo.Nombre;
            lblDescripcion.Text = "Descripción: " + articulo.Descripcion;
            lblMarca.Text = "Marca: " + articulo.Marca.Descripcion;
            lblCategoria.Text = "Categoría: " + articulo.Categoria.Descripcion;
            lblPrecio.Text = "Precio: $" + articulo.Precio.ToString("N2");

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imagenNegocio.obtenerImagenPorArticulo(articulo);

            if (imagenes.Count > 0) {
                foreach (Imagen img in imagenes)
                    lbImagenes.Items.Add(img.ImagenUrl);
                lbImagenes.SelectedIndex = 0;
            } else {
                pbImagen.ImageLocation = "..\\..\\..\\assets\\images\\NoImageLoaded.png";
            }
        }

        private void lbImagenes_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbImagenes.SelectedItem != null)
                pbImagen.LoadAsync(lbImagenes.SelectedItem.ToString());
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
