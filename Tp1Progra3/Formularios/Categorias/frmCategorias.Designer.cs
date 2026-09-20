namespace TPWinForm_equipoD.Formularios
{
    partial class frmCategorias
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
            this.btnLimpiarFiltroCategoria = new System.Windows.Forms.Button();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.lblBuscarPorNombre = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.mstMenuCategorias = new System.Windows.Forms.MenuStrip();
            this.tlsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMarcasC = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.mstMenuCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarFiltroCategoria
            // 
            this.btnLimpiarFiltroCategoria.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltroCategoria.Location = new System.Drawing.Point(182, 90);
            this.btnLimpiarFiltroCategoria.Name = "btnLimpiarFiltroCategoria";
            this.btnLimpiarFiltroCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltroCategoria.TabIndex = 2;
            this.btnLimpiarFiltroCategoria.Text = "Limpiar filtro";
            this.btnLimpiarFiltroCategoria.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltroCategoria.Click += new System.EventHandler(this.btnLimpiarFiltroCategoria_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.Location = new System.Drawing.Point(12, 90);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCategoria.TabIndex = 1;
            this.btnBuscarCategoria.Text = "Buscar 🔍";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Location = new System.Drawing.Point(12, 66);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(244, 20);
            this.txtBuscarCategoria.TabIndex = 0;
            // 
            // lblBuscarPorNombre
            // 
            this.lblBuscarPorNombre.AutoSize = true;
            this.lblBuscarPorNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBuscarPorNombre.Location = new System.Drawing.Point(12, 43);
            this.lblBuscarPorNombre.Name = "lblBuscarPorNombre";
            this.lblBuscarPorNombre.Size = new System.Drawing.Size(71, 20);
            this.lblBuscarPorNombre.TabIndex = 24;
            this.lblBuscarPorNombre.Text = "Busqueda:";
            this.lblBuscarPorNombre.UseCompatibleTextRendering = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(182, 400);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 5;
            this.btnEliminarCategoria.Text = "Eliminar ✖️";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.Location = new System.Drawing.Point(92, 400);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(84, 23);
            this.btnModificarCategoria.TabIndex = 4;
            this.btnModificarCategoria.Text = "Modificar ✏️";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(12, 400);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(74, 23);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "Agregar ➕";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // mstMenuCategorias
            // 
            this.mstMenuCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsArchivo,
            this.tlsAdministrar});
            this.mstMenuCategorias.Location = new System.Drawing.Point(0, 0);
            this.mstMenuCategorias.Name = "mstMenuCategorias";
            this.mstMenuCategorias.Size = new System.Drawing.Size(271, 24);
            this.mstMenuCategorias.TabIndex = 20;
            this.mstMenuCategorias.Text = "menuStrip2";
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
            this.tlsArticulos,
            this.tlsMarcasC});
            this.tlsAdministrar.Name = "tlsAdministrar";
            this.tlsAdministrar.Size = new System.Drawing.Size(81, 20);
            this.tlsAdministrar.Text = "Administrar";
            // 
            // tlsArticulos
            // 
            this.tlsArticulos.Name = "tlsArticulos";
            this.tlsArticulos.Size = new System.Drawing.Size(121, 22);
            this.tlsArticulos.Text = "Articulos";
            this.tlsArticulos.Click += new System.EventHandler(this.tlsArticulos_Click);
            // 
            // tlsMarcasC
            // 
            this.tlsMarcasC.Name = "tlsMarcasC";
            this.tlsMarcasC.Size = new System.Drawing.Size(121, 22);
            this.tlsMarcasC.Text = "Marcas";
            this.tlsMarcasC.Click += new System.EventHandler(this.tlsMarcasC_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(12, 119);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(245, 275);
            this.dgvCategoria.TabIndex = 19;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.btnLimpiarFiltroCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.lblBuscarPorNombre);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.mstMenuCategorias);
            this.Controls.Add(this.dgvCategoria);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Categorias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCategorias_FormClosed);
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.mstMenuCategorias.ResumeLayout(false);
            this.mstMenuCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarFiltroCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Label lblBuscarPorNombre;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.MenuStrip mstMenuCategorias;
        private System.Windows.Forms.ToolStripMenuItem tlsArchivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsAdministrar;
        private System.Windows.Forms.ToolStripMenuItem tlsArticulos;
        private System.Windows.Forms.ToolStripMenuItem tlsMarcasC;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}