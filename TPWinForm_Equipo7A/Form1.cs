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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.Listar();

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
    }
}
