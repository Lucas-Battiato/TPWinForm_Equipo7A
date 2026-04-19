using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_Equipo7A {
    public partial class frmAltaArticulo : Form {
        public frmAltaArticulo() {
            InitializeComponent();
        }


        private void frmABMArticulo_Load(object sender, EventArgs e) {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbMarca.DataSource = marcaNegocio.listar();

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbCategoria.DataSource = categoriaNegocio.listar();

        }


        private void btnAgregarImagen_Click(object sender, EventArgs e) {
            if (tbImagenUrl.Text != "") {
                dgvURLs.Rows.Add(tbImagenUrl.Text);
                tbImagenUrl.Text = "";

                //dgvURLs.ClearSelection();
                //dgvURLs.Rows[dgvURLs.Rows.Count - 1].Selected = true; // Selecciono la ultima URL ingresada para que se vaya actualizando el PictureBox
                dgvURLs.CurrentCell = dgvURLs.Rows[dgvURLs.Rows.Count - 1].Cells[0];
                actualizarImagen();

            } else MessageBox.Show("No es posible ingresar URLs vacias");
        }


        private void dgvURLs_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) dgvURLs.Rows.RemoveAt(e.RowIndex); // Si hago doble click en el header me devuelve -1. Con el if prevengo eso.
        }


        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e) {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try {
                articulo.Codigo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;

                articuloNegocio.guardar(articulo);


                if (dgvURLs.Rows.Count > 0) {
                    List<Imagen> listaImagenes = new List<Imagen>();

                    foreach (DataGridViewRow fila in dgvURLs.Rows) {
                        Imagen imagen = new Imagen();
                        imagen.IdArticulo = articuloNegocio.obtenerIdArticulo(articulo); // Obtengo el ID del articulo recien subido a la DB y lo uso para el obj de Imagen.
                        imagen.ImagenUrl = fila.Cells[0].Value.ToString();
                        imagenNegocio.guardar(imagen);
                    }

                }

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvURLs_SelectionChanged(object sender, EventArgs e) {
            actualizarImagen();
        }

        private void actualizarImagen() {
            pbImagen.ImageLocation = dgvURLs.CurrentRow.Cells[0].Value.ToString(); // Obtengo la URL de la fila seleccionada y la uso para el PictureBox
        }
    }
}
