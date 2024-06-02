namespace BibliotecaProyecto.vista
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEstablecimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLibrosToolStripMenuItem,
            this.generarPrestamoToolStripMenuItem,
            this.mantenimientoEstablecimientoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.mantenimientoUsuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1504, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarLibrosToolStripMenuItem
            // 
            this.agregarLibrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.agregarLibrosToolStripMenuItem.Name = "agregarLibrosToolStripMenuItem";
            this.agregarLibrosToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.agregarLibrosToolStripMenuItem.Text = "Libros";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.agregarToolStripMenuItem.Text = "Buscar libro";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.modificarToolStripMenuItem.Text = "Mantenimiento libro";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // generarPrestamoToolStripMenuItem
            // 
            this.generarPrestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarPrestamosToolStripMenuItem,
            this.generarToolStripMenuItem,
            this.cancelarPrestamoToolStripMenuItem});
            this.generarPrestamoToolStripMenuItem.Name = "generarPrestamoToolStripMenuItem";
            this.generarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.generarPrestamoToolStripMenuItem.Text = "Generar Prestamo";
            // 
            // mostrarPrestamosToolStripMenuItem
            // 
            this.mostrarPrestamosToolStripMenuItem.Name = "mostrarPrestamosToolStripMenuItem";
            this.mostrarPrestamosToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.mostrarPrestamosToolStripMenuItem.Text = "Mostrar Prestamos";
            this.mostrarPrestamosToolStripMenuItem.Click += new System.EventHandler(this.mostrarPrestamosToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // cancelarPrestamoToolStripMenuItem
            // 
            this.cancelarPrestamoToolStripMenuItem.Name = "cancelarPrestamoToolStripMenuItem";
            this.cancelarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.cancelarPrestamoToolStripMenuItem.Text = "Cancelar Prestamo";
            this.cancelarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.cancelarPrestamoToolStripMenuItem_Click);
            // 
            // mantenimientoEstablecimientoToolStripMenuItem
            // 
            this.mantenimientoEstablecimientoToolStripMenuItem.Name = "mantenimientoEstablecimientoToolStripMenuItem";
            this.mantenimientoEstablecimientoToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.mantenimientoEstablecimientoToolStripMenuItem.Text = "Establecimiento";
            this.mantenimientoEstablecimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoEstablecimientoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // mantenimientoUsuarioToolStripMenuItem
            // 
            this.mantenimientoUsuarioToolStripMenuItem.Name = "mantenimientoUsuarioToolStripMenuItem";
            this.mantenimientoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.mantenimientoUsuarioToolStripMenuItem.Text = "Usuario";
            this.mantenimientoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoUsuarioToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 682);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "ProcesoLibros";
            this.Load += new System.EventHandler(this.ProcesoLibros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEstablecimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
    }
}