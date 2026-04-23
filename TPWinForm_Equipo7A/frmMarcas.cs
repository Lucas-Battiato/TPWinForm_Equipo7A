using System;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_Equipo7A {
    public partial class frmMarcas : Form {
        public frmMarcas() {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e) {
            cargar();
        }

        private void cargar() {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text)) {
                MessageBox.Show("Ingrese una descripción.");
                return;
            }
            try {
                MarcaNegocio negocio = new MarcaNegocio();
                negocio.guardar(tbDescripcion.Text.Trim());
                tbDescripcion.Text = "";
                cargar();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvMarcas.CurrentRow == null) {
                MessageBox.Show("Seleccione una marca.");
                return;
            }
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            if (MessageBox.Show($"¿Eliminar la marca '{marca.Descripcion}'?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                try {
                    MarcaNegocio negocio = new MarcaNegocio();
                    negocio.eliminar(marca.Id);
                    cargar();
                } catch (Exception ex) {
                    MessageBox.Show("No se pudo eliminar. Puede que esté en uso.\n" + ex.Message);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
