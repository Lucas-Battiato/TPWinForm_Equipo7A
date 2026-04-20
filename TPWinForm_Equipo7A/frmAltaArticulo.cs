using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            List<Marca> listaMarcas = marcaNegocio.listar();
            listaMarcas.Insert(0, new Marca(-1, "Seleccionar...")); // Creo una Marca dummy solo para poder mostrar el texto "Seleccionar" en el combobox
            cbMarca.DataSource = listaMarcas;

            List<Categoria> listaCategorias = categoriaNegocio.listar();
            listaCategorias.Insert(0, new Categoria(-1, "Seleccionar...")); // Creo una categoria dummy solo para poder mostrar el texto "Seleccionar" en el combobox
            cbCategoria.DataSource = listaCategorias;

        }


        private void btnAgregarImagen_Click(object sender, EventArgs e) {
            if (tbImagenUrl.Text != "") {
                dgvURLs.Rows.Add(tbImagenUrl.Text);
                tbImagenUrl.Text = "";

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
                bool flagCampoVacio = false;

                if (tbCodigo.Text == "") {
                    //tbCodigo.BackColor = Color.Red;
                    errorProvider.SetError(tbCodigo, "El nombre es obligatorio");
                    flagCampoVacio = true;

                } else articulo.Codigo = tbCodigo.Text;

                
                if (tbPrecio.Text == "") {
                    //tbPrecio.BackColor = Color.Red;
                    errorProvider.SetError(tbPrecio, "El precio es obligatorio");
                    flagCampoVacio = true;

                } else articulo.Precio = int.Parse(tbPrecio.Text);


                if (tbNombre.Text == "") {
                    //tbNombre.BackColor = Color.Red;
                    errorProvider.SetError(tbNombre, "El nombre es obligatorio");
                    flagCampoVacio = true;

                } else articulo.Nombre = tbNombre.Text;


                articulo.Descripcion = tbDescripcion.Text;


                if (cbMarca.Text == "Seleccionar...") {
                    //cbMarca.BackColor = Color.Red;
                    errorProvider.SetError(cbMarca, "Debe seleccionar una marca");
                    flagCampoVacio = true;

                } else articulo.Marca = (Marca)cbMarca.SelectedItem;


                if (cbCategoria.Text == "Seleccionar...") {
                    //cbCategoria.BackColor = Color.Red;
                    errorProvider.SetError(cbCategoria, "Debe seleccionar una categoria");
                    flagCampoVacio = true;

                } else articulo.Categoria = (Categoria)cbCategoria.SelectedItem;



                if (!flagCampoVacio) {

                    if (articuloNegocio.obtenerIdArticuloPorCodigo(articulo) == 0) {
                        articuloNegocio.guardar(articulo); // Guardo el Articulo en la DB.

                        if (dgvURLs.Rows.Count > 0) {
                            //List<Imagen> listaImagenes = new List<Imagen>();

                            foreach (DataGridViewRow fila in dgvURLs.Rows) {
                                Imagen imagen = new Imagen();
                                imagen.IdArticulo = articuloNegocio.obtenerIdArticuloPorCodigo(articulo); // Obtengo el ID del articulo recien subido a la DB y lo uso para el obj de Imagen.
                                imagen.ImagenUrl = fila.Cells[0].Value.ToString();
                                imagenNegocio.guardar(imagen); // Guardo cada imagen en la DB.
                            }

                        }

                        tbCodigo.Text = "";
                        tbPrecio.Text = "";
                        tbNombre.Text = "";
                        tbDescripcion.Text = "";
                        cbMarca.Text = "Seleccionar...";
                        cbCategoria.Text = "Seleccionar...";
                        dgvURLs.Rows.Clear();
                        lbMensajeEstado.ForeColor = Color.Green;
                        lbMensajeEstado.Text = "Articulo guardado con exito.";

                    } else {
                        MessageBox.Show("El código ingresado ya se encuentra registrado en el sistema.");
                    }

                } else {
                    lbMensajeEstado.ForeColor = Color.Red;
                    lbMensajeEstado.Text = "Los campos con (*) son obligatorios.";
                }


            } catch (FormatException ex) {
                MessageBox.Show("Alguno de los datos ingresados tiene un formato incorrecto");

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }


        // Al seleccionar una URL distinta en el listado, el PictureBox se actualiza y muestra esa imagen.
        private void dgvURLs_SelectionChanged(object sender, EventArgs e) {
            actualizarImagen();
        }


        private void actualizarImagen() {
            pbImagen.ImageLocation = dgvURLs.CurrentRow.Cells[0].Value.ToString(); // Obtengo la URL de la fila seleccionada y la uso para el PictureBox
        }



        // Eventos para reestablecer color despues de que se ponga rojo el campo por estar vacio y limpiar mensaje de error.
        private void tbCodigo_TextChanged(object sender, EventArgs e) {
            //tbCodigo.BackColor = Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            errorProvider.SetError(tbCodigo, "");
            limpiarMensajeEstado();
        }

        private void tbPrecio_TextChanged(object sender, EventArgs e) {
            //tbPrecio.BackColor = Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            errorProvider.SetError(tbPrecio, "");
            limpiarMensajeEstado();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e) {
            //tbNombre.BackColor = Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            errorProvider.SetError(tbNombre, "");
            limpiarMensajeEstado();
        }

        private void cbMarca_TextChanged(object sender, EventArgs e) {
            //cbMarca.BackColor = Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            errorProvider.SetError(cbMarca, "");
            limpiarMensajeEstado();
        }

        private void cbCategoria_TextChanged(object sender, EventArgs e) {
            //cbCategoria.BackColor = Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            errorProvider.SetError(cbCategoria, "");
            limpiarMensajeEstado();
        }


        private void limpiarMensajeEstado() {
            lbMensajeEstado.Text = "";
        }
    }
}
