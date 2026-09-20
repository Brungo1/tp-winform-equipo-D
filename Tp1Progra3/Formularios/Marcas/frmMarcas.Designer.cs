namespace TPWinForm_equipoD.Formularios
{
    partial class frmMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.mstMenuMarcas = new System.Windows.Forms.MenuStrip();
            this.tlsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnLimpiarFiltroMarca = new System.Windows.Forms.Button();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.lblBuscarPorNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.mstMenuMarcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AllowUserToResizeColumns = false;
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 123);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(248, 275);
            this.dgvMarcas.TabIndex = 0;
            // 
            // mstMenuMarcas
            // 
            this.mstMenuMarcas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsArchivo,
            this.tlsAdministrar});
            this.mstMenuMarcas.Location = new System.Drawing.Point(0, 0);
            this.mstMenuMarcas.Name = "mstMenuMarcas";
            this.mstMenuMarcas.Size = new System.Drawing.Size(276, 24);
            this.mstMenuMarcas.TabIndex = 3;
            this.mstMenuMarcas.Text = "menuStrip2";
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
            // 
            // tlsAdministrar
            // 
            this.tlsAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsArticulos,
            this.tlsCategorias});
            this.tlsAdministrar.Name = "tlsAdministrar";
            this.tlsAdministrar.Size = new System.Drawing.Size(81, 20);
            this.tlsAdministrar.Text = "Administrar";
            // 
            // tlsArticulos
            // 
            this.tlsArticulos.Name = "tlsArticulos";
            this.tlsArticulos.Size = new System.Drawing.Size(130, 22);
            this.tlsArticulos.Text = "Articulos";
            this.tlsArticulos.Click += new System.EventHandler(this.tlsArticulos_Click);
            // 
            // tlsCategorias
            // 
            this.tlsCategorias.Name = "tlsCategorias";
            this.tlsCategorias.Size = new System.Drawing.Size(130, 22);
            this.tlsCategorias.Text = "Categorias";
            this.tlsCategorias.Click += new System.EventHandler(this.tlsCategorias_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(12, 404);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 10;
            this.btnAgregarMarca.Text = "Agregar ➕";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarca.Location = new System.Drawing.Point(93, 404);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(86, 23);
            this.btnModificarMarca.TabIndex = 11;
            this.btnModificarMarca.Text = "Modificar ✏️";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(185, 404);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 12;
            this.btnEliminarMarca.Text = "Eliminar ✖️";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnLimpiarFiltroMarca
            // 
            this.btnLimpiarFiltroMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltroMarca.Location = new System.Drawing.Point(185, 90);
            this.btnLimpiarFiltroMarca.Name = "btnLimpiarFiltroMarca";
            this.btnLimpiarFiltroMarca.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltroMarca.TabIndex = 18;
            this.btnLimpiarFiltroMarca.Text = "Limpiar filtro";
            this.btnLimpiarFiltroMarca.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltroMarca.Click += new System.EventHandler(this.btnLimpiarFiltroMarca_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMarca.Location = new System.Drawing.Point(12, 90);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMarca.TabIndex = 17;
            this.btnBuscarMarca.Text = "Buscar 🔍";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Location = new System.Drawing.Point(12, 64);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(248, 20);
            this.txtBuscarMarca.TabIndex = 16;
            // 
            // lblBuscarPorNombre
            // 
            this.lblBuscarPorNombre.AutoSize = true;
            this.lblBuscarPorNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBuscarPorNombre.Location = new System.Drawing.Point(12, 41);
            this.lblBuscarPorNombre.Name = "lblBuscarPorNombre";
            this.lblBuscarPorNombre.Size = new System.Drawing.Size(71, 20);
            this.lblBuscarPorNombre.TabIndex = 13;
            this.lblBuscarPorNombre.Text = "Busqueda:";
            this.lblBuscarPorNombre.UseCompatibleTextRendering = true;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 450);
            this.Controls.Add(this.btnLimpiarFiltroMarca);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.lblBuscarPorNombre);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.mstMenuMarcas);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Marcas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMarcas_FormClosed);
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.mstMenuMarcas.ResumeLayout(false);
            this.mstMenuMarcas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.MenuStrip mstMenuMarcas;
        private System.Windows.Forms.ToolStripMenuItem tlsArchivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsAdministrar;
        private System.Windows.Forms.ToolStripMenuItem tlsArticulos;
        private System.Windows.Forms.ToolStripMenuItem tlsCategorias;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnLimpiarFiltroMarca;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Label lblBuscarPorNombre;
    }
}