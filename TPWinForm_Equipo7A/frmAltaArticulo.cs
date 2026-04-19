using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnGuardar_Click(object sender, EventArgs e) {
            
        }

    }
}
