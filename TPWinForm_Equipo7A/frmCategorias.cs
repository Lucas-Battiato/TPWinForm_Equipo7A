using System;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_Equipo7A {
    public partial class frmCategorias : Form {
        public frmCategorias() {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e) {
            cargar();
        }

        private void cargar() {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text)) {
                MessageBox.Show("Ingrese una descripción.");
                return;
            }
            try {
                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.guardar(tbDescripcion.Text.Trim());
                tbDescripcion.Text = "";
                cargar();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvCategorias.CurrentRow == null) {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            CategoriaNegocio negocio = new CategoriaNegocio();
            
            int cantidadProductos = negocio.contarProductosRelacionados(categoria.Id);
            if (cantidadProductos > 0) {
                MessageBox.Show($"No se puede eliminar la categoría '{categoria.Descripcion}'.\nHay {cantidadProductos} producto(s) usando esta categoría.\nReasigne o elimine esos productos primero.", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Eliminar la categoría '{categoria.Descripcion}'?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                try {
                    negocio.eliminar(categoria.Id);
                    cargar();
                } catch (Exception ex) {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
