namespace capaPresentacion
{
    partial class formHistoriaClinica
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
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnRegistrarHistoria = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFrecResp = new System.Windows.Forms.TextBox();
            this.txtFrecCard = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPresionArterial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtExamenFisico = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRelato = new System.Windows.Forms.TextBox();
            this.richAntecedentes = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.richSignosSintomas = new System.Windows.Forms.RichTextBox();
            this.richPresMedica = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSeleccionarPaciente = new System.Windows.Forms.Button();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numTiempo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(369, 537);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(152, 31);
            this.btnLimpiarCampos.TabIndex = 34;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarHistoria
            // 
            this.btnRegistrarHistoria.Location = new System.Drawing.Point(211, 537);
            this.btnRegistrarHistoria.Name = "btnRegistrarHistoria";
            this.btnRegistrarHistoria.Size = new System.Drawing.Size(152, 31);
            this.btnRegistrarHistoria.TabIndex = 33;
            this.btnRegistrarHistoria.Text = "Guardar Registro";
            this.btnRegistrarHistoria.UseVisualStyleBackColor = true;
            this.btnRegistrarHistoria.Click += new System.EventHandler(this.btnRegistrarHistoria_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(248, 42);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(104, 20);
            this.dtFecha.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(141, 155);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(52, 20);
            this.txtTalla.TabIndex = 26;
            this.txtTalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(138, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Talla:";
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Location = new System.Drawing.Point(77, 156);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(56, 20);
            this.txtPeso.TabIndex = 24;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Location = new System.Drawing.Point(15, 157);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(56, 20);
            this.txtEdad.TabIndex = 22;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(74, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Peso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "FORMATO DE ATENCIÓN EN CONSULTORIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(196, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Frec. Resp:";
            // 
            // txtFrecResp
            // 
            this.txtFrecResp.Location = new System.Drawing.Point(199, 155);
            this.txtFrecResp.Name = "txtFrecResp";
            this.txtFrecResp.Size = new System.Drawing.Size(66, 20);
            this.txtFrecResp.TabIndex = 39;
            this.txtFrecResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFrecCard
            // 
            this.txtFrecCard.Location = new System.Drawing.Point(271, 155);
            this.txtFrecCard.Name = "txtFrecCard";
            this.txtFrecCard.Size = new System.Drawing.Size(66, 20);
            this.txtFrecCard.TabIndex = 41;
            this.txtFrecCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(268, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Frec. Card:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(343, 155);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(52, 20);
            this.txtTemperatura.TabIndex = 43;
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(340, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Temp:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(398, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Pres. Art:";
            // 
            // txtPresionArterial
            // 
            this.txtPresionArterial.Location = new System.Drawing.Point(401, 155);
            this.txtPresionArterial.Name = "txtPresionArterial";
            this.txtPresionArterial.Size = new System.Drawing.Size(52, 20);
            this.txtPresionArterial.TabIndex = 45;
            this.txtPresionArterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(456, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Tiempo:";
            // 
            // txtExamenFisico
            // 
            this.txtExamenFisico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExamenFisico.Location = new System.Drawing.Point(15, 324);
            this.txtExamenFisico.Name = "txtExamenFisico";
            this.txtExamenFisico.Size = new System.Drawing.Size(250, 67);
            this.txtExamenFisico.TabIndex = 52;
            this.txtExamenFisico.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Examen Físico:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(12, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Relato:";
            // 
            // txtRelato
            // 
            this.txtRelato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRelato.Location = new System.Drawing.Point(15, 277);
            this.txtRelato.Name = "txtRelato";
            this.txtRelato.Size = new System.Drawing.Size(250, 20);
            this.txtRelato.TabIndex = 55;
            // 
            // richAntecedentes
            // 
            this.richAntecedentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richAntecedentes.Location = new System.Drawing.Point(271, 324);
            this.richAntecedentes.Name = "richAntecedentes";
            this.richAntecedentes.Size = new System.Drawing.Size(250, 67);
            this.richAntecedentes.TabIndex = 57;
            this.richAntecedentes.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(268, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 56;
            this.label17.Text = "Antecedentes:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnostico.Location = new System.Drawing.Point(15, 418);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(506, 20);
            this.txtDiagnostico.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Diagnostico:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(10, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Signos y sintomas:";
            // 
            // richSignosSintomas
            // 
            this.richSignosSintomas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richSignosSintomas.Location = new System.Drawing.Point(15, 205);
            this.richSignosSintomas.MaxLength = 2147;
            this.richSignosSintomas.Name = "richSignosSintomas";
            this.richSignosSintomas.Size = new System.Drawing.Size(506, 45);
            this.richSignosSintomas.TabIndex = 50;
            this.richSignosSintomas.Text = "";
            // 
            // richPresMedica
            // 
            this.richPresMedica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richPresMedica.Location = new System.Drawing.Point(15, 465);
            this.richPresMedica.Name = "richPresMedica";
            this.richPresMedica.Size = new System.Drawing.Size(506, 64);
            this.richPresMedica.TabIndex = 61;
            this.richPresMedica.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Prescripción Médica:";
            // 
            // btnSeleccionarPaciente
            // 
            this.btnSeleccionarPaciente.Location = new System.Drawing.Point(15, 95);
            this.btnSeleccionarPaciente.Name = "btnSeleccionarPaciente";
            this.btnSeleccionarPaciente.Size = new System.Drawing.Size(118, 23);
            this.btnSeleccionarPaciente.TabIndex = 62;
            this.btnSeleccionarPaciente.Text = "Seleccionar paciente";
            this.btnSeleccionarPaciente.UseVisualStyleBackColor = true;
            this.btnSeleccionarPaciente.Click += new System.EventHandler(this.btnSeleccionarPaciente_Click);
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Enabled = false;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(139, 97);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.ReadOnly = true;
            this.txtCodigoPaciente.Size = new System.Drawing.Size(52, 20);
            this.txtCodigoPaciente.TabIndex = 63;
            this.txtCodigoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(139, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Codigo:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(12, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(514, 13);
            this.label18.TabIndex = 65;
            this.label18.Text = "................................................................................." +
    "................................................................................" +
    "........";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(271, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 66;
            this.button2.Text = "Seleccionar Encargado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacion.Properties.Resources.Creciendo_Sanos_y_Felices_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // numTiempo
            // 
            this.numTiempo.Location = new System.Drawing.Point(459, 156);
            this.numTiempo.Name = "numTiempo";
            this.numTiempo.Size = new System.Drawing.Size(62, 20);
            this.numTiempo.TabIndex = 67;
            // 
            // formHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 580);
            this.Controls.Add(this.numTiempo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.btnSeleccionarPaciente);
            this.Controls.Add(this.richPresMedica);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richAntecedentes);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRelato);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtExamenFisico);
            this.Controls.Add(this.richSignosSintomas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPresionArterial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFrecCard);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFrecResp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnRegistrarHistoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clinica - Registrar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formHistoriaClinica_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnRegistrarHistoria;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFrecResp;
        private System.Windows.Forms.TextBox txtFrecCard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPresionArterial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox txtExamenFisico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRelato;
        private System.Windows.Forms.RichTextBox richAntecedentes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richSignosSintomas;
        private System.Windows.Forms.RichTextBox richPresMedica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSeleccionarPaciente;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numTiempo;
    }
}