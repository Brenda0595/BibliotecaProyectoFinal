namespace BibliotecaProyecto.vista.prestamo
{
    partial class Dialogobusquedalibro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscarlibro = new System.Windows.Forms.Button();
            this.txtNlibro = new System.Windows.Forms.TextBox();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.dtgriviwDialogo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriviwDialogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // btnbuscarlibro
            // 
            this.btnbuscarlibro.Location = new System.Drawing.Point(572, 37);
            this.btnbuscarlibro.Name = "btnbuscarlibro";
            this.btnbuscarlibro.Size = new System.Drawing.Size(148, 34);
            this.btnbuscarlibro.TabIndex = 2;
            this.btnbuscarlibro.Text = "Buscar";
            this.btnbuscarlibro.UseVisualStyleBackColor = true;
            this.btnbuscarlibro.Click += new System.EventHandler(this.btnbuscarlibro_Click);
            // 
            // txtNlibro
            // 
            this.txtNlibro.Location = new System.Drawing.Point(90, 63);
            this.txtNlibro.Name = "txtNlibro";
            this.txtNlibro.Size = new System.Drawing.Size(181, 26);
            this.txtNlibro.TabIndex = 3;
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.Location = new System.Drawing.Point(372, 60);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(165, 26);
            this.txtCodigoLibro.TabIndex = 4;
            // 
            // dtgriviwDialogo
            // 
            this.dtgriviwDialogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgriviwDialogo.Location = new System.Drawing.Point(90, 127);
            this.dtgriviwDialogo.Name = "dtgriviwDialogo";
            this.dtgriviwDialogo.RowTemplate.Height = 28;
            this.dtgriviwDialogo.Size = new System.Drawing.Size(613, 150);
            this.dtgriviwDialogo.TabIndex = 5;
            // 
            // Dialogobusquedalibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 355);
            this.Controls.Add(this.dtgriviwDialogo);
            this.Controls.Add(this.txtCodigoLibro);
            this.Controls.Add(this.txtNlibro);
            this.Controls.Add(this.btnbuscarlibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dialogobusquedalibro";
            this.Text = "Dialogobusquedalibro";
            ((System.ComponentModel.ISupportInitialize)(this.dtgriviwDialogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscarlibro;
        private System.Windows.Forms.TextBox txtNlibro;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.DataGridView dtgriviwDialogo;
    }
}