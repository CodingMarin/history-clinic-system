using capaEntidad;
using capaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class formAgregarPaciente : Form
    {
        private static formAgregarPaciente instancia;
        private static NotifyIcon notifyIcon;

        public formAgregarPaciente()
        {
            InitializeComponent();
            this.KeyPreview = true;
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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtNombrePaciente.Text = string.Empty;
            txtTelefonoPaciente.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtPapaPaciente.Text = string.Empty;
            txtMamaPaciente.Text = string.Empty;
            txtDireccionPaciente.Text = string.Empty;
        }
        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePaciente.Text;
            string direccion = txtDireccionPaciente.Text;
            string dniText = txtDNI.Text;

            if (dniText.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return;
            }

            int dni;
            if (!int.TryParse(dniText, out dni))
            {
                MessageBox.Show("El DNI debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return;
            }

            string telefono = txtTelefonoPaciente.Text;
            DateTime fechaNacimiento = dtFechaNacimientoPaciente.Value.Date;
            string mami = txtMamaPaciente.Text;
            string papa = txtPapaPaciente.Text;

            pacienteCE pacienteCE = new pacienteCE();
            pacienteCE.nombre = nombre;
            pacienteCE.direccion = direccion;
            pacienteCE.DNI = dni;
            pacienteCE.telefono = telefono;
            pacienteCE.direccion = direccion;
            pacienteCE.fecha_nacimiento= fechaNacimiento;
            pacienteCE.mami_nombre = mami;
            pacienteCE.papi_nombre = papa;
            pacienteCN pacienteCN = new pacienteCN();

            bool r = pacienteCN.validarCampos(pacienteCE);

            if (r == true)
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrePaciente.Focus();
                return;
            }

            pacienteCN.insertar(pacienteCE);
            ShowNotification("Agregado satisfactoriamente", "Nueva notificación");
            MessageBox.Show("Paciente " + pacienteCE.nombre + " Registrado");
            limpiarCampos();
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
        private void formPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (txtNombrePaciente.Text.Length > 0 || txtDireccionPaciente.Text.Length > 0 || txtDNI.Text.Length > 0 || txtDireccionPaciente.Text.Length > 0 || txtMamaPaciente.Text.Length > 0 || txtPapaPaciente.Text.Length > 0)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                } else
                {
                    this.Close();
                }
            }
        }
    }
}
