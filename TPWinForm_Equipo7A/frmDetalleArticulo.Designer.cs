namespace TPWinForm_Equipo7A {
    partial class frmDetalleArticulo {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lbImagenes = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();

            // lblId
            this.lblId.Location = new System.Drawing.Point(12, 20);
            this.lblId.Size = new System.Drawing.Size(300, 20);

            // lblCodigo
            this.lblCodigo.Location = new System.Drawing.Point(12, 45);
            this.lblCodigo.Size = new System.Drawing.Size(300, 20);

            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(12, 70);
            this.lblNombre.Size = new System.Drawing.Size(300, 20);

            // lblDescripcion
            this.lblDescripcion.Location = new System.Drawing.Point(12, 95);
            this.lblDescripcion.Size = new System.Drawing.Size(300, 40);
            this.lblDescripcion.AutoSize = false;

            // lblMarca
            this.lblMarca.Location = new System.Drawing.Point(12, 140);
            this.lblMarca.Size = new System.Drawing.Size(300, 20);

            // lblCategoria
            this.lblCategoria.Location = new System.Drawing.Point(12, 165);
            this.lblCategoria.Size = new System.Drawing.Size(300, 20);

            // lblPrecio
            this.lblPrecio.Location = new System.Drawing.Point(12, 190);
            this.lblPrecio.Size = new System.Drawing.Size(300, 20);

            // label1 (Imágenes)
            this.label1.Text = "Imágenes:";
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Size = new System.Drawing.Size(80, 20);

            // lbImagenes
            this.lbImagenes.Location = new System.Drawing.Point(12, 248);
            this.lbImagenes.Size = new System.Drawing.Size(300, 80);
            this.lbImagenes.SelectedIndexChanged += new System.EventHandler(this.lbImagenes_SelectedIndexChanged);

            // pbImagen
            this.pbImagen.Location = new System.Drawing.Point(330, 20);
            this.pbImagen.Size = new System.Drawing.Size(300, 300);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnCerrar
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Location = new System.Drawing.Point(237, 345);
            this.btnCerrar.Size = new System.Drawing.Size(75, 30);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // frmDetalleArticulo
            this.ClientSize = new System.Drawing.Size(650, 390);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbImagenes);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnCerrar);
            this.Text = "Detalle del Artículo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ListBox lbImagenes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}
