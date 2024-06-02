namespace BibliotecaProyecto.vista.prestamo
{
    partial class cancelarPrestamo
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
            this.dtgvPrestamo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvcancelar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuscarP = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombreP = new System.Windows.Forms.TextBox();
            this.txtapellidoP = new System.Windows.Forms.TextBox();
            this.txtcorreoP = new System.Windows.Forms.TextBox();
            this.txttelP = new System.Windows.Forms.TextBox();
            this.txtfechaInicioP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfechaFinP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtduiP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmontoP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcuotaP = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANCELAR PRESTAMO";
            // 
            // dtgvPrestamo
            // 
            this.dtgvPrestamo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrestamo.Location = new System.Drawing.Point(67, 203);
            this.dtgvPrestamo.Name = "dtgvPrestamo";
            this.dtgvPrestamo.RowTemplate.Height = 28;
            this.dtgvPrestamo.Size = new System.Drawing.Size(700, 173);
            this.dtgvPrestamo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de Prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registro a Cancelar";
            // 
            // dtgvcancelar
            // 
            this.dtgvcancelar.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvcancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvcancelar.Location = new System.Drawing.Point(67, 453);
            this.dtgvcancelar.Name = "dtgvcancelar";
            this.dtgvcancelar.RowTemplate.Height = 28;
            this.dtgvcancelar.Size = new System.Drawing.Size(700, 172);
            this.dtgvcancelar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese Codigo Prestamo:";
            // 
            // txtbuscarP
            // 
            this.txtbuscarP.Location = new System.Drawing.Point(280, 106);
            this.txtbuscarP.Name = "txtbuscarP";
            this.txtbuscarP.Size = new System.Drawing.Size(215, 26);
            this.txtbuscarP.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(524, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 35);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(948, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "DATOS DE PRESTAMO";
            // 
            // txtnombreP
            // 
            this.txtnombreP.Enabled = false;
            this.txtnombreP.Location = new System.Drawing.Point(808, 203);
            this.txtnombreP.Name = "txtnombreP";
            this.txtnombreP.Size = new System.Drawing.Size(237, 26);
            this.txtnombreP.TabIndex = 9;
            // 
            // txtapellidoP
            // 
            this.txtapellidoP.Enabled = false;
            this.txtapellidoP.Location = new System.Drawing.Point(1082, 203);
            this.txtapellidoP.Name = "txtapellidoP";
            this.txtapellidoP.Size = new System.Drawing.Size(183, 26);
            this.txtapellidoP.TabIndex = 10;
            // 
            // txtcorreoP
            // 
            this.txtcorreoP.Enabled = false;
            this.txtcorreoP.Location = new System.Drawing.Point(813, 283);
            this.txtcorreoP.Name = "txtcorreoP";
            this.txtcorreoP.Size = new System.Drawing.Size(255, 26);
            this.txtcorreoP.TabIndex = 11;
            // 
            // txttelP
            // 
            this.txttelP.Enabled = false;
            this.txttelP.Location = new System.Drawing.Point(1111, 283);
            this.txttelP.Name = "txttelP";
            this.txttelP.Size = new System.Drawing.Size(154, 26);
            this.txttelP.TabIndex = 12;
            // 
            // txtfechaInicioP
            // 
            this.txtfechaInicioP.Location = new System.Drawing.Point(813, 371);
            this.txtfechaInicioP.Name = "txtfechaInicioP";
            this.txtfechaInicioP.Size = new System.Drawing.Size(156, 26);
            this.txtfechaInicioP.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(804, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1066, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(809, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Correo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1121, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(809, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha Inicio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1022, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fecha Fin";
            // 
            // txtfechaFinP
            // 
            this.txtfechaFinP.Location = new System.Drawing.Point(1002, 371);
            this.txtfechaFinP.Name = "txtfechaFinP";
            this.txtfechaFinP.Size = new System.Drawing.Size(133, 26);
            this.txtfechaFinP.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1161, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "DUI:";
            // 
            // txtduiP
            // 
            this.txtduiP.Enabled = false;
            this.txtduiP.Location = new System.Drawing.Point(1165, 371);
            this.txtduiP.Name = "txtduiP";
            this.txtduiP.Size = new System.Drawing.Size(100, 26);
            this.txtduiP.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(804, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Monto";
            // 
            // txtmontoP
            // 
            this.txtmontoP.Location = new System.Drawing.Point(808, 453);
            this.txtmontoP.Name = "txtmontoP";
            this.txtmontoP.Size = new System.Drawing.Size(100, 26);
            this.txtmontoP.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(964, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Cuota:";
            // 
            // txtcuotaP
            // 
            this.txtcuotaP.Location = new System.Drawing.Point(968, 453);
            this.txtcuotaP.Name = "txtcuotaP";
            this.txtcuotaP.Size = new System.Drawing.Size(100, 26);
            this.txtcuotaP.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(808, 544);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(212, 41);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar Prestamo";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(1070, 552);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(143, 33);
            this.btnlimpiar.TabIndex = 28;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(649, 403);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(118, 34);
            this.btnquitar.TabIndex = 29;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1086, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Estado:";
            // 
            // txtestado
            // 
            this.txtestado.Enabled = false;
            this.txtestado.Location = new System.Drawing.Point(1090, 453);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(175, 26);
            this.txtestado.TabIndex = 31;
            // 
            // cancelarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1330, 667);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtcuotaP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtmontoP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtduiP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtfechaFinP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfechaInicioP);
            this.Controls.Add(this.txttelP);
            this.Controls.Add(this.txtcorreoP);
            this.Controls.Add(this.txtapellidoP);
            this.Controls.Add(this.txtnombreP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbuscarP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvcancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvPrestamo);
            this.Controls.Add(this.label1);
            this.Name = "cancelarPrestamo";
            this.Text = "cancelarPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvcancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbuscarP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombreP;
        private System.Windows.Forms.TextBox txtapellidoP;
        private System.Windows.Forms.TextBox txtcorreoP;
        private System.Windows.Forms.TextBox txttelP;
        private System.Windows.Forms.TextBox txtfechaInicioP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfechaFinP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtduiP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmontoP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcuotaP;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtestado;
    }
}