namespace BibliotecaProyecto.vista.prestamo
{
    partial class generarPrestamos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombreLibro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigoLibro = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdisponibleLibro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoriaLibro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstaLibro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApellidoS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCorreoS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefonoS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDuiS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoP = new System.Windows.Forms.TextBox();
            this.txtCuotaP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtIDlibro = new System.Windows.Forms.TextBox();
            this.txtIDusuario = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dtgvlistalibro = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistalibro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAR PRESTAMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos del Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datos del Solicitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1033, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos Quien Genera Prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Libro";
            // 
            // txtnombreLibro
            // 
            this.txtnombreLibro.Location = new System.Drawing.Point(99, 158);
            this.txtnombreLibro.Name = "txtnombreLibro";
            this.txtnombreLibro.Size = new System.Drawing.Size(163, 26);
            this.txtnombreLibro.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Codigo";
            // 
            // txtcodigoLibro
            // 
            this.txtcodigoLibro.Location = new System.Drawing.Point(99, 203);
            this.txtcodigoLibro.Name = "txtcodigoLibro";
            this.txtcodigoLibro.Size = new System.Drawing.Size(163, 26);
            this.txtcodigoLibro.TabIndex = 7;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(295, 158);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(117, 34);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Disponible";
            // 
            // txtdisponibleLibro
            // 
            this.txtdisponibleLibro.Location = new System.Drawing.Point(31, 301);
            this.txtdisponibleLibro.Name = "txtdisponibleLibro";
            this.txtdisponibleLibro.Size = new System.Drawing.Size(100, 26);
            this.txtdisponibleLibro.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Categoria";
            // 
            // txtCategoriaLibro
            // 
            this.txtCategoriaLibro.Location = new System.Drawing.Point(31, 379);
            this.txtCategoriaLibro.Name = "txtCategoriaLibro";
            this.txtCategoriaLibro.Size = new System.Drawing.Size(225, 26);
            this.txtCategoriaLibro.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Establecimiento";
            // 
            // txtEstaLibro
            // 
            this.txtEstaLibro.Location = new System.Drawing.Point(31, 460);
            this.txtEstaLibro.Name = "txtEstaLibro";
            this.txtEstaLibro.Size = new System.Drawing.Size(216, 26);
            this.txtEstaLibro.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nombre Solicitante";
            // 
            // txtNombreS
            // 
            this.txtNombreS.Location = new System.Drawing.Point(680, 200);
            this.txtNombreS.Name = "txtNombreS";
            this.txtNombreS.Size = new System.Drawing.Size(294, 26);
            this.txtNombreS.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Apellido Solicitante";
            // 
            // txtApellidoS
            // 
            this.txtApellidoS.Location = new System.Drawing.Point(680, 278);
            this.txtApellidoS.Name = "txtApellidoS";
            this.txtApellidoS.Size = new System.Drawing.Size(294, 26);
            this.txtApellidoS.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(685, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Correo";
            // 
            // txtCorreoS
            // 
            this.txtCorreoS.Location = new System.Drawing.Point(680, 343);
            this.txtCorreoS.Name = "txtCorreoS";
            this.txtCorreoS.Size = new System.Drawing.Size(294, 26);
            this.txtCorreoS.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(685, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Telefono";
            // 
            // txtTelefonoS
            // 
            this.txtTelefonoS.Location = new System.Drawing.Point(680, 425);
            this.txtTelefonoS.Name = "txtTelefonoS";
            this.txtTelefonoS.Size = new System.Drawing.Size(139, 26);
            this.txtTelefonoS.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(867, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "DUI";
            // 
            // txtDuiS
            // 
            this.txtDuiS.Location = new System.Drawing.Point(871, 420);
            this.txtDuiS.Name = "txtDuiS";
            this.txtDuiS.Size = new System.Drawing.Size(120, 26);
            this.txtDuiS.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1044, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Nombre";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Enabled = false;
            this.txtNombreP.Location = new System.Drawing.Point(1041, 200);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(238, 26);
            this.txtNombreP.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1044, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Apellido";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Enabled = false;
            this.txtApellidoP.Location = new System.Drawing.Point(1041, 267);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(234, 26);
            this.txtApellidoP.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1055, 317);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Monto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1209, 317);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "Cuota";
            // 
            // txtMontoP
            // 
            this.txtMontoP.Location = new System.Drawing.Point(1048, 343);
            this.txtMontoP.Name = "txtMontoP";
            this.txtMontoP.Size = new System.Drawing.Size(100, 26);
            this.txtMontoP.TabIndex = 31;
            // 
            // txtCuotaP
            // 
            this.txtCuotaP.Location = new System.Drawing.Point(1201, 343);
            this.txtCuotaP.Name = "txtCuotaP";
            this.txtCuotaP.Size = new System.Drawing.Size(100, 26);
            this.txtCuotaP.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1044, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "Fecha Inicio";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(1048, 423);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(293, 26);
            this.txtFechaInicio.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1044, 466);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(164, 20);
            this.label20.TabIndex = 35;
            this.label20.Text = "Fecha Final Prestamo";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(1048, 501);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(293, 26);
            this.txtFechaFin.TabIndex = 36;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(669, 512);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(305, 35);
            this.btnGenerar.TabIndex = 37;
            this.btnGenerar.Text = "GENERAR PRESTAMO";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtIDlibro
            // 
            this.txtIDlibro.Location = new System.Drawing.Point(46, 93);
            this.txtIDlibro.Name = "txtIDlibro";
            this.txtIDlibro.Size = new System.Drawing.Size(100, 26);
            this.txtIDlibro.TabIndex = 38;
            this.txtIDlibro.Visible = false;
            // 
            // txtIDusuario
            // 
            this.txtIDusuario.Location = new System.Drawing.Point(1211, 146);
            this.txtIDusuario.Name = "txtIDusuario";
            this.txtIDusuario.Size = new System.Drawing.Size(100, 26);
            this.txtIDusuario.TabIndex = 39;
            this.txtIDusuario.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(295, 215);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(117, 36);
            this.btnagregar.TabIndex = 40;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dtgvlistalibro
            // 
            this.dtgvlistalibro.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvlistalibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlistalibro.Location = new System.Drawing.Point(277, 295);
            this.dtgvlistalibro.Name = "dtgvlistalibro";
            this.dtgvlistalibro.RowTemplate.Height = 28;
            this.dtgvlistalibro.Size = new System.Drawing.Size(357, 191);
            this.dtgvlistalibro.TabIndex = 41;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(43, 510);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(121, 38);
            this.btnlimpiar.TabIndex = 42;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // generarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1031, 570);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dtgvlistalibro);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtIDusuario);
            this.Controls.Add(this.txtIDlibro);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCuotaP);
            this.Controls.Add(this.txtMontoP);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDuiS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTelefonoS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCorreoS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtApellidoS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEstaLibro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCategoriaLibro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdisponibleLibro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtcodigoLibro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombreLibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "generarPrestamos";
            this.Text = "generarPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistalibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombreLibro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigoLibro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdisponibleLibro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoriaLibro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstaLibro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApellidoS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreoS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefonoS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDuiS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMontoP;
        private System.Windows.Forms.TextBox txtCuotaP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtIDlibro;
        private System.Windows.Forms.TextBox txtIDusuario;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dtgvlistalibro;
        private System.Windows.Forms.Button btnlimpiar;
    }
}