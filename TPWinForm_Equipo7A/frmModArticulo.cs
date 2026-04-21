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
    public partial class frmModArticulo : Form {
        Articulo articulo;

        public frmModArticulo() {
            InitializeComponent();
        }

        public frmModArticulo(Articulo articulo) {
            InitializeComponent();
            this.articulo = articulo;
        }


        private void frmModArticulo_Load(object sender, EventArgs e) {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            cbMarca.DataSource = marcaNegocio.listar();
            cbCategoria.DataSource = categoriaNegocio.listar();

            tbCodigo.Text = articulo.Codigo;
            tbPrecio.Text = articulo.Precio.ToString();
            tbNombre.Text = articulo.Nombre;
            tbDescripcion.Text = articulo.Descripcion;

            cbMarca.ValueMember = "Descripcion";
            cbMarca.SelectedValue = articulo.Marca.Descripcion;

            cbCategoria.ValueMember = "Descripcion";
            cbCategoria.SelectedValue = articulo.Categoria.Descripcion;

            foreach (Imagen imagen in imagenNegocio.obtenerImagenPorArticulo(articulo)) {
                dgvURLs.Rows.Add(imagen.ImagenUrl);
            }

            actualizarImagen();
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


        private void btnActualizar_Click(object sender, EventArgs e) {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articuloAux = new Articulo();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try {
                bool flagCampoVacio = false;
                
                articuloAux.Id = articulo.Id;

                if (tbCodigo.Text == "") {
                    //tbCodigo.BackColor = Color.Red;
                    errorProvider.SetError(tbCodigo, "El nombre es obligatorio");
                    flagCampoVacio = true;

                } else articuloAux.Codigo = tbCodigo.Text;


                if (tbPrecio.Text == "") {
                    //tbPrecio.BackColor = Color.Red;
                    errorProvider.SetError(tbPrecio, "El precio es obligatorio");
                    flagCampoVacio = true;

                } else articuloAux.Precio = decimal.Parse(tbPrecio.Text.Replace('.', ','));

                if (tbNombre.Text == "") {
                    //tbNombre.BackColor = Color.Red;
                    errorProvider.SetError(tbNombre, "El nombre es obligatorio");
                    flagCampoVacio = true;

                } else articuloAux.Nombre = tbNombre.Text;


                articuloAux.Descripcion = tbDescripcion.Text;


                if (cbMarca.Text == "Seleccionar...") {
                    //cbMarca.BackColor = Color.Red;
                    errorProvider.SetError(cbMarca, "Debe seleccionar una marca");
                    flagCampoVacio = true;

                } else articuloAux.Marca = (Marca)cbMarca.SelectedItem;


                if (cbCategoria.Text == "Seleccionar...") {
                    //cbCategoria.BackColor = Color.Red;
                    errorProvider.SetError(cbCategoria, "Debe seleccionar una categoria");
                    flagCampoVacio = true;

                } else articuloAux.Categoria = (Categoria)cbCategoria.SelectedItem;



                if (!flagCampoVacio) {

                    // Si el codigo ingresao es distinto al del producto a modificar Y el codigo YA SE ENCUENTRA en la DB, entonces el codigo ya existe.
                    if (articulo.Codigo == articuloAux.Codigo || articuloNegocio.obtenerIdArticuloPorCodigo(articuloAux) == 0) {
                        articuloNegocio.actualizarArticulo(articuloAux); // Actualizo el Articulo en la DB.

                        List<Imagen> listaImagenesEnDB = imagenNegocio.obtenerImagenPorArticulo(articulo);
                        List<string> listaUrlsImagenesEnDgv = new List<string>();
                        //List<Imagen> listaImagenesFinales = new List<Imagen>();

                        // Leo y guardo las URLs del dgvURLs
                        foreach ( DataGridViewRow fila in dgvURLs.Rows) {
                            listaUrlsImagenesEnDgv.Add(fila.Cells[0].Value.ToString());
                        }


                        // Si la imagen de la DB NO esta en el listado del dgv, la elimino de la DB.
                        foreach (Imagen imagen in listaImagenesEnDB) {
                            bool imagenExiste = false;

                            foreach (string URL in listaUrlsImagenesEnDgv) {
                                if (imagen.ImagenUrl == URL) {
                                    imagenExiste = true;
                                }
                            }

                            if (!imagenExiste) {
                                imagenNegocio.eliminarImagen(imagen);
                            }
                        }


                        // Si la imagen del dgv NO esta en la DB, la agrego.
                        foreach (string URL in listaUrlsImagenesEnDgv) {
                            bool imagenExiste = false;

                            foreach (Imagen imagen in listaImagenesEnDB) {
                                if (URL == imagen.ImagenUrl) {
                                    imagenExiste = true;
                                }
                            }

                            if (!imagenExiste) {
                                Imagen imagen = new Imagen();
                                imagen.IdArticulo = articulo.Id;
                                imagen.ImagenUrl = URL;
                                imagenNegocio.guardar(imagen);
                            }
                        }



                        //if (dgvURLs.Rows.Count > 0) {
                        //    //List<Imagen> listaImagenes = new List<Imagen>();

                        //    foreach (DataGridViewRow fila in dgvURLs.Rows) {
                        //        Imagen imagen = new Imagen();
                        //        imagen.IdArticulo = articuloNegocio.obtenerIdArticuloPorCodigo(articulo); // Obtengo el ID del articulo recien subido a la DB y lo uso para el obj de Imagen.
                        //        imagen.ImagenUrl = fila.Cells[0].Value.ToString();
                        //        imagenNegocio.guardar(imagen); // Guardo cada imagen en la DB.
                        //    }

                        //}

                        tbCodigo.Text = "";
                        tbPrecio.Text = "";
                        tbNombre.Text = "";
                        tbDescripcion.Text = "";
                        cbMarca.Text = "Seleccionar...";
                        cbCategoria.Text = "Seleccionar...";
                        dgvURLs.Rows.Clear();
                        lbMensajeEstado.ForeColor = Color.Green;
                        lbMensajeEstado.Text = "Articulo actualizado con exito.";
                        actualizarImagen();

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
            if (!(dgvURLs.CurrentRow is null)) {
                try {
                    pbImagen.ImageLocation = dgvURLs.CurrentRow.Cells[0].Value.ToString(); // Obtengo la URL de la fila seleccionada y la uso para el PictureBox

                } catch (NullReferenceException ex) {
                    return;
                }

            } else pbImagen.ImageLocation = "..\\..\\..\\assets\\images\\NoImageLoaded.png";

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
