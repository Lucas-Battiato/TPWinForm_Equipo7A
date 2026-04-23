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
using TPWinForm_Equipo7A;


namespace winform_app
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.Listar();
            dgvArticulos.DataSource = negocio.Listar();
            cargar();
            ocultarColumnas();


                cbCampo.Items.Add("Id");
                cbCampo.Items.Add("Codigo");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Descripcion");
                cbCampo.Items.Add("Precio");
                cbCampo.Items.Add("Marca");
                cbCampo.Items.Add("Categoria");
    
                cbCriterio.Items.Add("Contiene");
                cbCriterio.Items.Add("Empieza con");
                cbCriterio.Items.Add("Termina con");
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imgNegocio = new ImagenNegocio();
            try
            {
                listaArticulo = negocio.Listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo();
            frmAltaArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e) {

            if (dgvArticulos.SelectedCells != null) {
                Articulo articuloSeleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
                frmModArticulo frmModArticulo = new frmModArticulo(articuloSeleccionado);
                frmModArticulo.ShowDialog();

            } else MessageBox.Show("Debe seleccionar un articulo del listado.");
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarFiltro())
            {
                return;
            }
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (cbCampo.SelectedItem == null || cbCriterio.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un campo y un criterio antes de buscar.");
                    return;
                }
                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();

            cbCriterio.Items.Clear();

            if (opcion == "Precio" || opcion == "Id")
            {
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
            }
            else
            {
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (listaArticulo == null)
            {
                return;
            }

            if (filtro != "")
            {
                string filtroAvanzado = filtro.ToUpper();

                listaFiltrada = listaArticulo.FindAll(x =>
                    x != null && (

                        (x.Nombre != null && x.Nombre.ToUpper().Contains(filtroAvanzado)) ||
                        (x.Codigo != null && x.Codigo.ToUpper().Contains(filtroAvanzado)) ||
                        (x.Descripcion != null && x.Descripcion.ToUpper().Contains(filtroAvanzado)) ||
                        (x.Id.ToString().Contains(filtroAvanzado)) ||
                        (x.Precio.ToString().Contains(filtroAvanzado)) ||
                        (x.Marca != null && x.Marca.Descripcion != null && x.Marca.Descripcion.ToUpper().Contains(filtroAvanzado)) ||
                        (x.Categoria != null && x.Categoria.Descripcion != null && x.Categoria.Descripcion.ToUpper().Contains(filtroAvanzado))
                    )
                );
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ImagenNegocio imgNegocio = new ImagenNegocio();
                List<Imagen> fotosDelArticulo = imgNegocio.obtenerImagenPorArticulo(seleccionado);
                string urlParaMostrar = "https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png";

                if (fotosDelArticulo.Count > 0)
                {
                    urlParaMostrar = fotosDelArticulo[0].ImagenUrl;
                }

                cargarImagen(urlParaMostrar);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.LoadAsync(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.LoadAsync("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private bool validarFiltro()
        {
            if (cbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }

            if (cbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }

            string campoSeleccionado = cbCampo.SelectedItem.ToString();

            if (campoSeleccionado == "Id" || campoSeleccionado == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número para filtrar.");
                    return true;
                }

                if (!int.TryParse(txtFiltro.Text, out int numero))
                {
                    MessageBox.Show("Este campo solo acepta números.");
                    return true;
                }
            }
            return false;
        }


    }
}
