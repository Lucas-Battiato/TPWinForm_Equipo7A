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
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo();
            frmAltaArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e) {

            if (dgvArticulos.SelectedCells != null) {
                frmModArticulo frmModArticulo = new frmModArticulo();
                frmModArticulo.ShowDialog();

            } else MessageBox.Show("Debe seleccionar un articulo del listado.");
            

        }
    }
}
