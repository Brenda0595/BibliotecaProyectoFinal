namespace BibliotecaProyecto.vista.prestamo
{
    partial class mostrarPrestamos
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
            this.dtgwPrestamo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvwlineaPrestamo = new System.Windows.Forms.DataGridView();
            this.txtNombreL = new System.Windows.Forms.TextBox();
            this.txtfechaInicoL = new System.Windows.Forms.TextBox();
            this.txtfechaFinL = new System.Windows.Forms.TextBox();
            this.txtcorreoL = new System.Windows.Forms.TextBox();
            this.txtcodigoL = new System.Windows.Forms.TextBox();
            this.txtEstadoL = new System.Windows.Forms.TextBox();
            this.btnlimpiarLinea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwlineaPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORMACION DE LOS PRESTAMOS";
            // 
            // dtgwPrestamo
            // 
            this.dtgwPrestamo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgwPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwPrestamo.Location = new System.Drawing.Point(39, 111);
            this.dtgwPrestamo.Name = "dtgwPrestamo";
            this.dtgwPrestamo.RowTemplate.Height = 28;
            this.dtgwPrestamo.Size = new System.Drawing.Size(725, 286);
            this.dtgwPrestamo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1027, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(992, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Usuarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1036, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estados";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(794, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(1019, 163);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 26);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDui
            // 
            this.txtDui.Enabled = false;
            this.txtDui.Location = new System.Drawing.Point(801, 247);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(138, 26);
            this.txtDui.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(996, 247);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(209, 26);
            this.txtCorreo.TabIndex = 11;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DisplayMember = "nombre";
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(794, 335);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(209, 28);
            this.cmbUsuario.TabIndex = 12;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(1031, 335);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(188, 28);
            this.cmbEstado.TabIndex = 13;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(814, 392);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(163, 40);
            this.btnbuscar.TabIndex = 14;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(1019, 392);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(143, 40);
            this.btnlimpiar.TabIndex = 15;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(1105, 87);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(123, 26);
            this.txtcodigo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(961, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Codigo Prestamo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Registro obtenido por prestamo";
            // 
            // dtgvwlineaPrestamo
            // 
            this.dtgvwlineaPrestamo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvwlineaPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvwlineaPrestamo.Location = new System.Drawing.Point(39, 480);
            this.dtgvwlineaPrestamo.Name = "dtgvwlineaPrestamo";
            this.dtgvwlineaPrestamo.RowTemplate.Height = 28;
            this.dtgvwlineaPrestamo.Size = new System.Drawing.Size(725, 172);
            this.dtgvwlineaPrestamo.TabIndex = 19;
            // 
            // txtNombreL
            // 
            this.txtNombreL.Enabled = false;
            this.txtNombreL.Location = new System.Drawing.Point(801, 480);
            this.txtNombreL.Name = "txtNombreL";
            this.txtNombreL.Size = new System.Drawing.Size(264, 26);
            this.txtNombreL.TabIndex = 20;
            // 
            // txtfechaInicoL
            // 
            this.txtfechaInicoL.Enabled = false;
            this.txtfechaInicoL.Location = new System.Drawing.Point(801, 539);
            this.txtfechaInicoL.Name = "txtfechaInicoL";
            this.txtfechaInicoL.Size = new System.Drawing.Size(176, 26);
            this.txtfechaInicoL.TabIndex = 21;
            // 
            // txtfechaFinL
            // 
            this.txtfechaFinL.Enabled = false;
            this.txtfechaFinL.Location = new System.Drawing.Point(1019, 539);
            this.txtfechaFinL.Name = "txtfechaFinL";
            this.txtfechaFinL.Size = new System.Drawing.Size(171, 26);
            this.txtfechaFinL.TabIndex = 22;
            // 
            // txtcorreoL
            // 
            this.txtcorreoL.Enabled = false;
            this.txtcorreoL.Location = new System.Drawing.Point(801, 588);
            this.txtcorreoL.Name = "txtcorreoL";
            this.txtcorreoL.Size = new System.Drawing.Size(176, 26);
            this.txtcorreoL.TabIndex = 23;
            // 
            // txtcodigoL
            // 
            this.txtcodigoL.Enabled = false;
            this.txtcodigoL.Location = new System.Drawing.Point(1119, 480);
            this.txtcodigoL.Name = "txtcodigoL";
            this.txtcodigoL.Size = new System.Drawing.Size(100, 26);
            this.txtcodigoL.TabIndex = 24;
            // 
            // txtEstadoL
            // 
            this.txtEstadoL.Enabled = false;
            this.txtEstadoL.Location = new System.Drawing.Point(1052, 588);
            this.txtEstadoL.Name = "txtEstadoL";
            this.txtEstadoL.Size = new System.Drawing.Size(100, 26);
            this.txtEstadoL.TabIndex = 25;
            // 
            // btnlimpiarLinea
            // 
            this.btnlimpiarLinea.Location = new System.Drawing.Point(589, 440);
            this.btnlimpiarLinea.Name = "btnlimpiarLinea";
            this.btnlimpiarLinea.Size = new System.Drawing.Size(175, 34);
            this.btnlimpiarLinea.TabIndex = 26;
            this.btnlimpiarLinea.Text = "Quitar Valores";
            this.btnlimpiarLinea.UseVisualStyleBackColor = true;
            this.btnlimpiarLinea.Click += new System.EventHandler(this.btnlimpiarLinea_Click);
            // 
            // mostrarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1297, 682);
            this.Controls.Add(this.btnlimpiarLinea);
            this.Controls.Add(this.txtEstadoL);
            this.Controls.Add(this.txtcodigoL);
            this.Controls.Add(this.txtcorreoL);
            this.Controls.Add(this.txtfechaFinL);
            this.Controls.Add(this.txtfechaInicoL);
            this.Controls.Add(this.txtNombreL);
            this.Controls.Add(this.dtgvwlineaPrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgwPrestamo);
            this.Controls.Add(this.label1);
            this.Name = "mostrarPrestamos";
            this.Text = "mostrarPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwlineaPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgwPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgvwlineaPrestamo;
        private System.Windows.Forms.TextBox txtNombreL;
        private System.Windows.Forms.TextBox txtfechaInicoL;
        private System.Windows.Forms.TextBox txtfechaFinL;
        private System.Windows.Forms.TextBox txtcorreoL;
        private System.Windows.Forms.TextBox txtcodigoL;
        private System.Windows.Forms.TextBox txtEstadoL;
        private System.Windows.Forms.Button btnlimpiarLinea;
    }
}