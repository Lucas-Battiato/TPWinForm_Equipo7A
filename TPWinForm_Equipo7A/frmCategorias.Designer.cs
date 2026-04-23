namespace TPWinForm_Equipo7A {
    partial class frmCategorias {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();

            // dgvCategorias
            this.dgvCategorias.Location = new System.Drawing.Point(12, 12);
            this.dgvCategorias.Size = new System.Drawing.Size(360, 250);
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.AllowUserToAddRows = false;

            // label1
            this.label1.Text = "Nueva categoría:";
            this.label1.Location = new System.Drawing.Point(12, 275);
            this.label1.Size = new System.Drawing.Size(100, 20);

            // tbDescripcion
            this.tbDescripcion.Location = new System.Drawing.Point(115, 272);
            this.tbDescripcion.Size = new System.Drawing.Size(175, 23);

            // btnAgregar
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(297, 270);
            this.btnAgregar.Size = new System.Drawing.Size(75, 27);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnEliminar
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(12, 310);
            this.btnEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // btnCerrar
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Location = new System.Drawing.Point(297, 310);
            this.btnCerrar.Size = new System.Drawing.Size(75, 27);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // frmCategorias
            this.ClientSize = new System.Drawing.Size(390, 355);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Text = "Gestión de Categorías";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}
