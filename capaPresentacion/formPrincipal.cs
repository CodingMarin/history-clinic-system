using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class formPrincipal : Form
    {
        pacienteCN paciente = new pacienteCN();

        public formPrincipal()
        {
            InitializeComponent();
            this.ControlBox = true;
            this.MaximizeBox = false;
            DateTime now = DateTime.Now;
            lblFecha.Text = ObtenerFechaFormateada(now);
            Thread thread = new Thread(ActualizarHora);
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnShowPacienteForm_Click(object sender, EventArgs e)
        {
            formAgregarPaciente frm = new formAgregarPaciente();
            frm.FormClosed += (s, args) => loadPacientes();
            frm.ShowDialog();
        }

        private string ObtenerFechaFormateada(DateTime fecha)
        {
            CultureInfo culture = new CultureInfo("es-ES");
            string fechaFormateada = fecha.ToString("yyyy-MMMM-dd", culture);
            return fechaFormateada;
        }

        private void ActualizarHora()
        {
            while (true)
            {
                Thread.Sleep(1000);
                DateTime now = DateTime.Now;
                this.Invoke((MethodInvoker)delegate
                {
                    lblFecha.Text = now.ToString("yyyy-MMMM-dd HH:mm:ss");
                });
            }
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnMostrarFormHistoria_Click(object sender, EventArgs e)
        {
            formHistoriaClinica frm = new formHistoriaClinica();
            frm.FormClosed += (s, args) => loadConsultas();
            frm.ShowDialog();
        }

        private void loadPacientes()
        {

            int total = paciente.mostrarCantidadPacientes();
            ucCardPacientes.lblData.Text = total.ToString();
        }

        private void loadConsultas()
        {
            int total = paciente.mostrarCantidadHistorias();
            ucCardHistorias.lblData.Text = total.ToString();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            loadPacientes();
            loadConsultas();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            using (var formularioEmergente = new formBuscarPaciente())
            {
                formularioEmergente.Titulo = "asd";
                formularioEmergente.ShowDialog();
            }
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            using (var formPaciente = new formPaciente())
            {
                formPaciente.ShowDialog();
            }
        }
    }
}
