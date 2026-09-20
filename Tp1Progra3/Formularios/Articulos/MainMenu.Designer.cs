namespace TPWinForm_equipoD
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBuscarPorNombre = new System.Windows.Forms.Label();
            this.mstMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tlsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cmbBuscarArticulo = new System.Windows.Forms.ComboBox();
            this.txtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnLimpiarFiltroArticulo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.pbxImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnModificarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.mstMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPorNombre
            // 
            this.lblBuscarPorNombre.AutoSize = true;
            this.lblBuscarPorNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBuscarPorNombre.Location = new System.Drawing.Point(12, 40);
            this.lblBuscarPorNombre.Name = "lblBuscarPorNombre";
            this.lblBuscarPorNombre.Size = new System.Drawing.Size(118, 20);
            this.lblBuscarPorNombre.TabIndex = 0;
            this.lblBuscarPorNombre.Text = "Busqueda y filtros:";
            this.lblBuscarPorNombre.UseCompatibleTextRendering = true;
            // 
            // mstMenuPrincipal
            // 
            this.mstMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsArchivo,
            this.tlsAdministrar});
            this.mstMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstMenuPrincipal.Name = "mstMenuPrincipal";
            this.mstMenuPrincipal.Size = new System.Drawing.Size(1067, 24);
            this.mstMenuPrincipal.TabIndex = 0;
            this.mstMenuPrincipal.Text = "menuStrip2";
            // 
            // tlsArchivo
            // 
            this.tlsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.tlsArchivo.Name = "tlsArchivo";
            this.tlsArchivo.Size = new System.Drawing.Size(60, 20);
            this.tlsArchivo.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tlsAdministrar
            // 
            this.tlsAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMarcas,
            this.tlsCategorias});
            this.tlsAdministrar.Name = "tlsAdministrar";
            this.tlsAdministrar.Size = new System.Drawing.Size(81, 20);
            this.tlsAdministrar.Text = "Administrar";
            // 
            // tlsMarcas
            // 
            this.tlsMarcas.Name = "tlsMarcas";
            this.tlsMarcas.Size = new System.Drawing.Size(130, 22);
            this.tlsMarcas.Text = "Marcas";
            this.tlsMarcas.Click += new System.EventHandler(this.tlsMarcas_Click);
            // 
            // tlsCategorias
            // 
            this.tlsCategorias.Name = "tlsCategorias";
            this.tlsCategorias.Size = new System.Drawing.Size(130, 22);
            this.tlsCategorias.Text = "Categorias";
            this.tlsCategorias.Click += new System.EventHandler(this.tlsCategorias_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(29, 69);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(74, 16);
            this.lblBuscarPor.TabIndex = 1;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // cmbBuscarArticulo
            // 
            this.cmbBuscarArticulo.FormattingEnabled = true;
            this.cmbBuscarArticulo.Location = new System.Drawing.Point(109, 68);
            this.cmbBuscarArticulo.Name = "cmbBuscarArticulo";
            this.cmbBuscarArticulo.Size = new System.Drawing.Size(104, 21);
            this.cmbBuscarArticulo.TabIndex = 1;
            // 
            // txtBuscarArticulo
            // 
            this.txtBuscarArticulo.Location = new System.Drawing.Point(233, 68);
            this.txtBuscarArticulo.Name = "txtBuscarArticulo";
            this.txtBuscarArticulo.Size = new System.Drawing.Size(244, 20);
            this.txtBuscarArticulo.TabIndex = 2;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticulo.Location = new System.Drawing.Point(496, 66);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarArticulo.TabIndex = 3;
            this.btnBuscarArticulo.Text = "Buscar 🔍";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnLimpiarFiltroArticulo
            // 
            this.btnLimpiarFiltroArticulo.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltroArticulo.Location = new System.Drawing.Point(577, 66);
            this.btnLimpiarFiltroArticulo.Name = "btnLimpiarFiltroArticulo";
            this.btnLimpiarFiltroArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltroArticulo.TabIndex = 4;
            this.btnLimpiarFiltroArticulo.Text = "Limpiar filtro";
            this.btnLimpiarFiltroArticulo.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltroArticulo.Click += new System.EventHandler(this.btnLimpiarFiltroArticulo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(242, 354);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar ➕";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(463, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar ✏️";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(555, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar ✖️";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDetalle.Location = new System.Drawing.Point(636, 354);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(94, 23);
            this.BtnVerDetalle.TabIndex = 9;
            this.BtnVerDetalle.Text = "Ver Detalle 👁️";
            this.BtnVerDetalle.UseVisualStyleBackColor = true;
            this.BtnVerDetalle.Click += new System.EventHandler(this.BtnVerDetalle_Click);
            // 
            // pbxImagenProducto
            // 
            this.pbxImagenProducto.Location = new System.Drawing.Point(748, 110);
            this.pbxImagenProducto.Name = "pbxImagenProducto";
            this.pbxImagenProducto.Size = new System.Drawing.Size(307, 238);
            this.pbxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenProducto.TabIndex = 13;
            this.pbxImagenProducto.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(815, 354);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click_1);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(905, 354);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 110);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(718, 238);
            this.dgvArticulos.TabIndex = 16;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(323, 354);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarImagen.TabIndex = 6;
            this.btnAgregarImagen.Text = "Agregar Imagen ➕";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnModificarImagen
            // 
            this.btnModificarImagen.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarImagen.Location = new System.Drawing.Point(748, 383);
            this.btnModificarImagen.Name = "btnModificarImagen";
            this.btnModificarImagen.Size = new System.Drawing.Size(133, 23);
            this.btnModificarImagen.TabIndex = 10;
            this.btnModificarImagen.Text = "Modificar Imagen ✏️";
            this.btnModificarImagen.UseVisualStyleBackColor = true;
            this.btnModificarImagen.Click += new System.EventHandler(this.btnModificarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarImagen.Location = new System.Drawing.Point(922, 383);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(133, 23);
            this.btnEliminarImagen.TabIndex = 11;
            this.btnEliminarImagen.Text = "Eliminar Imagen ✖️";
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 449);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnModificarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pbxImagenProducto);
            this.Controls.Add(this.BtnVerDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiarFiltroArticulo);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.txtBuscarArticulo);
            this.Controls.Add(this.cmbBuscarArticulo);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.lblBuscarPorNombre);
            this.Controls.Add(this.mstMenuPrincipal);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mstMenuPrincipal.ResumeLayout(false);
            this.mstMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPorNombre;
        private System.Windows.Forms.MenuStrip mstMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tlsArchivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsAdministrar;
        private System.Windows.Forms.ToolStripMenuItem tlsMarcas;
        private System.Windows.Forms.ToolStripMenuItem tlsCategorias;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cmbBuscarArticulo;
        private System.Windows.Forms.TextBox txtBuscarArticulo;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnLimpiarFiltroArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnVerDetalle;
        private System.Windows.Forms.PictureBox pbxImagenProducto;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnModificarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
    }
}

