namespace capaPresentacion
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.menu_nav = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeHistoriasCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactarAlDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarUnProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostrarFormHistoria = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.bg_container = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucCardReport1 = new capaPresentacion.ucCardReport();
            this.ucCardReport2 = new capaPresentacion.ucCardReport();
            this.ucCardHistorias = new capaPresentacion.ucCardReport();
            this.ucCardPacientes = new capaPresentacion.ucCardReport();
            this.menu_nav.SuspendLayout();
            this.bg_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_nav
            // 
            this.menu_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.menu_nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.soporteToolStripMenuItem});
            this.menu_nav.Location = new System.Drawing.Point(0, 0);
            this.menu_nav.Name = "menu_nav";
            this.menu_nav.Size = new System.Drawing.Size(976, 24);
            this.menu_nav.TabIndex = 1;
            this.menu_nav.Text = "menu_navigator";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDePacientesToolStripMenuItem,
            this.registroDeHistoriasCToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registroDePacientesToolStripMenuItem
            // 
            this.registroDePacientesToolStripMenuItem.Name = "registroDePacientesToolStripMenuItem";
            this.registroDePacientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDePacientesToolStripMenuItem.Text = "Registro de pacientes.";
            // 
            // registroDeHistoriasCToolStripMenuItem
            // 
            this.registroDeHistoriasCToolStripMenuItem.Name = "registroDeHistoriasCToolStripMenuItem";
            this.registroDeHistoriasCToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeHistoriasCToolStripMenuItem.Text = "Registro de historias c.";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactarAlDesarrolladorToolStripMenuItem,
            this.reportarUnProblemaToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // contactarAlDesarrolladorToolStripMenuItem
            // 
            this.contactarAlDesarrolladorToolStripMenuItem.Name = "contactarAlDesarrolladorToolStripMenuItem";
            this.contactarAlDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contactarAlDesarrolladorToolStripMenuItem.Text = "Contactar al desarrollador.";
            // 
            // reportarUnProblemaToolStripMenuItem
            // 
            this.reportarUnProblemaToolStripMenuItem.Name = "reportarUnProblemaToolStripMenuItem";
            this.reportarUnProblemaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.reportarUnProblemaToolStripMenuItem.Text = "Reportar un problema.";
            // 
            // btnMostrarFormHistoria
            // 
            this.btnMostrarFormHistoria.Location = new System.Drawing.Point(680, 242);
            this.btnMostrarFormHistoria.Name = "btnMostrarFormHistoria";
            this.btnMostrarFormHistoria.Size = new System.Drawing.Size(148, 35);
            this.btnMostrarFormHistoria.TabIndex = 4;
            this.btnMostrarFormHistoria.Text = "Generar Historia Clinica";
            this.btnMostrarFormHistoria.UseVisualStyleBackColor = true;
            this.btnMostrarFormHistoria.Click += new System.EventHandler(this.btnMostrarFormHistoria_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(185, 242);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(150, 35);
            this.btnPaciente.TabIndex = 6;
            this.btnPaciente.Text = "Agregar paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnShowPacienteForm_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(826, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(122, 15);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "0000-00-00 00:00:00";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bg_container
            // 
            this.bg_container.BackColor = System.Drawing.Color.White;
            this.bg_container.Controls.Add(this.ucCardReport1);
            this.bg_container.Controls.Add(this.pictureBox5);
            this.bg_container.Controls.Add(this.pictureBox4);
            this.bg_container.Controls.Add(this.btnMostrarPacientes);
            this.bg_container.Controls.Add(this.pictureBox3);
            this.bg_container.Controls.Add(this.btnHistorial);
            this.bg_container.Controls.Add(this.pictureBox2);
            this.bg_container.Controls.Add(this.pictureBox1);
            this.bg_container.Controls.Add(this.btnBuscarPaciente);
            this.bg_container.Controls.Add(this.ucCardReport2);
            this.bg_container.Controls.Add(this.ucCardHistorias);
            this.bg_container.Controls.Add(this.ucCardPacientes);
            this.bg_container.Controls.Add(this.lblFecha);
            this.bg_container.Controls.Add(this.btnPaciente);
            this.bg_container.Controls.Add(this.btnMostrarFormHistoria);
            this.bg_container.Controls.Add(this.menu_nav);
            this.bg_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_container.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bg_container.Location = new System.Drawing.Point(0, 0);
            this.bg_container.Name = "bg_container";
            this.bg_container.Size = new System.Drawing.Size(976, 542);
            this.bg_container.TabIndex = 3;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(515, 242);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(150, 35);
            this.btnHistorial.TabIndex = 18;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(19, 242);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(150, 35);
            this.btnBuscarPaciente.TabIndex = 14;
            this.btnBuscarPaciente.Text = "Buscar paciente";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Location = new System.Drawing.Point(350, 242);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(150, 35);
            this.btnMostrarPacientes.TabIndex = 20;
            this.btnMostrarPacientes.Text = "Mostrar Pacientes";
            this.btnMostrarPacientes.UseVisualStyleBackColor = true;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::capaPresentacion.Properties.Resources.Creciendo_Sanos_y_Felices_LOGO;
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(34, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::capaPresentacion.Properties.Resources.inspection;
            this.pictureBox4.Location = new System.Drawing.Point(395, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::capaPresentacion.Properties.Resources.historial;
            this.pictureBox3.Location = new System.Drawing.Point(560, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::capaPresentacion.Properties.Resources.buscar_paciente;
            this.pictureBox2.Location = new System.Drawing.Point(61, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacion.Properties.Resources.pacientes;
            this.pictureBox1.Location = new System.Drawing.Point(218, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ucCardReport1
            // 
            this.ucCardReport1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ucCardReport1.Count = 0;
            this.ucCardReport1.Location = new System.Drawing.Point(680, 66);
            this.ucCardReport1.Name = "ucCardReport1";
            this.ucCardReport1.Size = new System.Drawing.Size(150, 74);
            this.ucCardReport1.TabIndex = 23;
            this.ucCardReport1.Title = "Usuarios";
            // 
            // ucCardReport2
            // 
            this.ucCardReport2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ucCardReport2.Count = 0;
            this.ucCardReport2.Location = new System.Drawing.Point(515, 66);
            this.ucCardReport2.Name = "ucCardReport2";
            this.ucCardReport2.Size = new System.Drawing.Size(150, 74);
            this.ucCardReport2.TabIndex = 13;
            this.ucCardReport2.Title = "Pendientes";
            // 
            // ucCardHistorias
            // 
            this.ucCardHistorias.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ucCardHistorias.Count = 0;
            this.ucCardHistorias.Location = new System.Drawing.Point(350, 66);
            this.ucCardHistorias.Name = "ucCardHistorias";
            this.ucCardHistorias.Size = new System.Drawing.Size(150, 74);
            this.ucCardHistorias.TabIndex = 12;
            this.ucCardHistorias.Title = "Historias clinicas";
            // 
            // ucCardPacientes
            // 
            this.ucCardPacientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ucCardPacientes.Count = 0;
            this.ucCardPacientes.Location = new System.Drawing.Point(185, 66);
            this.ucCardPacientes.Name = "ucCardPacientes";
            this.ucCardPacientes.Size = new System.Drawing.Size(150, 74);
            this.ucCardPacientes.TabIndex = 11;
            this.ucCardPacientes.Title = "Pacientes registrados";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 542);
            this.Controls.Add(this.bg_container);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creciendo Sanos y Felices - Clinica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.menu_nav.ResumeLayout(false);
            this.menu_nav.PerformLayout();
            this.bg_container.ResumeLayout(false);
            this.bg_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_nav;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeHistoriasCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactarAlDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarUnProblemaToolStripMenuItem;
        private System.Windows.Forms.Button btnMostrarFormHistoria;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel bg_container;
        private ucCardReport ucCardPacientes;
        private ucCardReport ucCardHistorias;
        private ucCardReport ucCardReport2;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ucCardReport ucCardReport1;
    }
}