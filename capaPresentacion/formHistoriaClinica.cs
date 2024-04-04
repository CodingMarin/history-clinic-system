using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class formHistoriaClinica : Form
    {
        private static formAgregarPaciente instancia;
        private static NotifyIcon notifyIcon;

        public formHistoriaClinica()
        {
            this.ControlBox = false;
            this.KeyPreview = true;
            InitializeComponent();
        }

        public static formAgregarPaciente ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new formAgregarPaciente();
                return instancia;
            }

            return instancia;
        }

        public static void ShowNotification(string message, string title)
        {
            if (notifyIcon == null)
            {
                notifyIcon = new NotifyIcon();
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.Visible = true;
            }
            notifyIcon.ShowBalloonTip(3000, title, message, ToolTipIcon.Info);
        }

        public static new void Dispose()
        {
            if (notifyIcon != null)
            {
                notifyIcon.Dispose();
            }
        }


        private void formHistoriaClinica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSeleccionarPaciente_Click(object sender, EventArgs e)
        {
            formSelecPaciente frm = new formSelecPaciente();
            frm.ShowDialog();
            txtCodigoPaciente.Text =frm.txtCodigo.Text;
        }

        private void btnRegistrarHistoria_Click(object sender, EventArgs e)
        {
            string codigo_paciente = txtCodigoPaciente.Text;
            string edad = txtEdad.Text;
            string peso = txtPeso.Text;
            string talla = txtTalla.Text;
            string frec_resp = txtFrecResp.Text;
            string frec_card = txtFrecCard.Text;
            string temperatura = txtTemperatura.Text;
            string pres_art = txtPresionArterial.Text;
            int tiempo = (int)numTiempo.Value;
            string signos_sintomas = richSignosSintomas.Text;
            string relato = txtRelato.Text;
            string examen_fisico = txtExamenFisico.Text;
            string antecedentes = richAntecedentes.Text;
            string diagnostico = txtDiagnostico.Text;
            string prescripcion_medica = richPresMedica.Text;

        }
    }
}
