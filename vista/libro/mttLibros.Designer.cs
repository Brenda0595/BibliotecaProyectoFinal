namespace BibliotecaProyecto.vista.libro
{
    partial class mttLibros
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
            this.dtgvwCargarLibros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.datefecha = new System.Windows.Forms.DateTimePicker();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.dateFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDisponible = new System.Windows.Forms.NumericUpDown();
            this.txtExistencia = new System.Windows.Forms.NumericUpDown();
            this.cmbEstablecimiento = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwCargarLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvwCargarLibros
            // 
            this.dtgvwCargarLibros.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvwCargarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvwCargarLibros.Location = new System.Drawing.Point(450, 103);
            this.dtgvwCargarLibros.Name = "dtgvwCargarLibros";
            this.dtgvwCargarLibros.RowTemplate.Height = 28;
            this.dtgvwCargarLibros.Size = new System.Drawing.Size(719, 340);
            this.dtgvwCargarLibros.TabIndex = 0;
            this.dtgvwCargarLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvwCargarLibros_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimiento Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Disponible";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Existencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Establecimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Categoria";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(157, 98);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(242, 26);
            this.txtnombre.TabIndex = 12;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(157, 146);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(242, 26);
            this.txtAutor.TabIndex = 13;
            // 
            // datefecha
            // 
            this.datefecha.Location = new System.Drawing.Point(157, 192);
            this.datefecha.Name = "datefecha";
            this.datefecha.Size = new System.Drawing.Size(242, 26);
            this.datefecha.TabIndex = 14;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(157, 236);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(242, 26);
            this.txtPais.TabIndex = 15;
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Location = new System.Drawing.Point(157, 281);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Size = new System.Drawing.Size(242, 26);
            this.dateFechaIngreso.TabIndex = 16;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(157, 330);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(242, 26);
            this.txtCodigo.TabIndex = 17;
            // 
            // txtDisponible
            // 
            this.txtDisponible.Location = new System.Drawing.Point(157, 376);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.Size = new System.Drawing.Size(124, 26);
            this.txtDisponible.TabIndex = 18;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(157, 423);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(124, 26);
            this.txtExistencia.TabIndex = 19;
            // 
            // cmbEstablecimiento
            // 
            this.cmbEstablecimiento.DisplayMember = "codigo";
            this.cmbEstablecimiento.FormattingEnabled = true;
            this.cmbEstablecimiento.Location = new System.Drawing.Point(157, 514);
            this.cmbEstablecimiento.Name = "cmbEstablecimiento";
            this.cmbEstablecimiento.Size = new System.Drawing.Size(242, 28);
            this.cmbEstablecimiento.TabIndex = 20;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DisplayMember = "nombre";
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(157, 566);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(242, 28);
            this.cmbCategoria.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(157, 623);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 39);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(559, 486);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(158, 35);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(953, 486);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 35);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(157, 66);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(257, 26);
            this.txtIdLibro.TabIndex = 25;
            this.txtIdLibro.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(157, 468);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(242, 28);
            this.cmbEstado.TabIndex = 27;
            // 
            // mttLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1232, 684);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdLibro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbEstablecimiento);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtDisponible);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dateFechaIngreso);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.datefecha);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvwCargarLibros);
            this.Name = "mttLibros";
            this.Text = "mttLibros";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwCargarLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvwCargarLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.DateTimePicker datefecha;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.DateTimePicker dateFechaIngreso;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown txtDisponible;
        private System.Windows.Forms.NumericUpDown txtExistencia;
        private System.Windows.Forms.ComboBox cmbEstablecimiento;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdLibro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}