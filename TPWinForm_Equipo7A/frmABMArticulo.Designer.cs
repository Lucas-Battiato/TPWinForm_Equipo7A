using System.Windows.Forms;

namespace TPWinForm_Equipo7A {
    partial class frmABMArticulo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.gbDatosArticulo = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.gbImágenes = new System.Windows.Forms.GroupBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.dgvURLs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbDatosArticulo.SuspendLayout();
            this.gbImágenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvURLs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.lbCodigo.Location = new System.Drawing.Point(53, 34);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(73, 20);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "* Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.tbCodigo.Location = new System.Drawing.Point(132, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(134, 27);
            this.tbCodigo.TabIndex = 1;
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Controls.Add(this.cbCategoria);
            this.gbDatosArticulo.Controls.Add(this.lbCategoria);
            this.gbDatosArticulo.Controls.Add(this.cbMarca);
            this.gbDatosArticulo.Controls.Add(this.lbMarca);
            this.gbDatosArticulo.Controls.Add(this.tbDescripcion);
            this.gbDatosArticulo.Controls.Add(this.lbDescripcion);
            this.gbDatosArticulo.Controls.Add(this.tbNombre);
            this.gbDatosArticulo.Controls.Add(this.lbNombre);
            this.gbDatosArticulo.Controls.Add(this.tbPrecio);
            this.gbDatosArticulo.Controls.Add(this.lbPrecio);
            this.gbDatosArticulo.Controls.Add(this.lbCodigo);
            this.gbDatosArticulo.Controls.Add(this.tbCodigo);
            this.gbDatosArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDatosArticulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbDatosArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.gbDatosArticulo.Location = new System.Drawing.Point(25, 21);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(552, 230);
            this.gbDatosArticulo.TabIndex = 2;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "Datos del artículo";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(395, 175);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(134, 28);
            this.cbCategoria.TabIndex = 10;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.lbCategoria.Location = new System.Drawing.Point(298, 178);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(91, 20);
            this.lbCategoria.TabIndex = 9;
            this.lbCategoria.Text = "* Categoria:";
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(132, 175);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(134, 28);
            this.cbMarca.TabIndex = 8;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.lbMarca.Location = new System.Drawing.Point(59, 178);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(67, 20);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "* Marca:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.tbDescripcion.Location = new System.Drawing.Point(132, 110);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(397, 54);
            this.tbDescripcion.TabIndex = 5;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.lbDescripcion.Location = new System.Drawing.Point(32, 110);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(94, 20);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.tbNombre.Location = new System.Drawing.Point(132, 70);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(397, 27);
            this.tbNombre.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.lbNombre.Location = new System.Drawing.Point(44, 72);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(82, 20);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "* Nombre:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.tbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.tbPrecio.Location = new System.Drawing.Point(395, 32);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(134, 27);
            this.tbPrecio.TabIndex = 1;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.lbPrecio.Location = new System.Drawing.Point(309, 34);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(80, 20);
            this.lbPrecio.TabIndex = 0;
            this.lbPrecio.Text = "* Precio: $";
            // 
            // gbImágenes
            // 
            this.gbImágenes.Controls.Add(this.textBox1);
            this.gbImágenes.Controls.Add(this.btnAgregarImagen);
            this.gbImágenes.Controls.Add(this.dgvURLs);
            this.gbImágenes.Controls.Add(this.pbImagen);
            this.gbImágenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbImágenes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbImágenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.gbImágenes.Location = new System.Drawing.Point(25, 267);
            this.gbImágenes.Name = "gbImágenes";
            this.gbImágenes.Size = new System.Drawing.Size(552, 200);
            this.gbImágenes.TabIndex = 11;
            this.gbImágenes.TabStop = false;
            this.gbImágenes.Text = "Imágenes del artículo";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(39)))));
            this.btnAgregarImagen.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(198)))), ((int)(((byte)(170)))));
            this.btnAgregarImagen.Location = new System.Drawing.Point(469, 153);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(62, 27);
            this.btnAgregarImagen.TabIndex = 14;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            // 
            // dgvURLs
            // 
            this.dgvURLs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.dgvURLs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvURLs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.dgvURLs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvURLs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvURLs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvURLs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvURLs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvURLs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ImagenUrl});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvURLs.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvURLs.EnableHeadersVisualStyles = false;
            this.dgvURLs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(74)))));
            this.dgvURLs.Location = new System.Drawing.Point(190, 26);
            this.dgvURLs.Name = "dgvURLs";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvURLs.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvURLs.RowHeadersVisible = false;
            this.dgvURLs.Size = new System.Drawing.Size(341, 117);
            this.dgvURLs.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 41;
            // 
            // ImagenUrl
            // 
            this.ImagenUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImagenUrl.HeaderText = "URLs";
            this.ImagenUrl.Name = "ImagenUrl";
            this.ImagenUrl.ReadOnly = true;
            this.ImagenUrl.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(20, 26);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(154, 154);
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelar.Location = new System.Drawing.Point(366, 492);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 33);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(244)))), ((int)(((byte)(215)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Location = new System.Drawing.Point(479, 492);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 33);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(174)))));
            this.textBox1.Location = new System.Drawing.Point(190, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 27);
            this.textBox1.TabIndex = 11;
            // 
            // frmABMArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(604, 541);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbImágenes);
            this.Controls.Add(this.gbDatosArticulo);
            this.MaximumSize = new System.Drawing.Size(620, 580);
            this.MinimumSize = new System.Drawing.Size(620, 580);
            this.Name = "frmABMArticulo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta/Modificación de artículos";
            this.gbDatosArticulo.ResumeLayout(false);
            this.gbDatosArticulo.PerformLayout();
            this.gbImágenes.ResumeLayout(false);
            this.gbImágenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvURLs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.GroupBox gbDatosArticulo;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.GroupBox gbImágenes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private PictureBox pbImagen;
        private DataGridView dgvURLs;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ImagenUrl;
        private Button btnAgregarImagen;
        private TextBox textBox1;
    }
}