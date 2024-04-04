using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class formPaciente : Form
    {
        public formPaciente()
        {
            InitializeComponent();

            mostrarPacientes();
            this.ControlBox = true;
            this.MaximizeBox = false;

            dgvMostrarPacientes.Columns["paciente_id"].HeaderText = "Codigo";
            dgvMostrarPacientes.Columns["nombre"].HeaderText = "Nombre";
            dgvMostrarPacientes.Columns["direccion"].HeaderText = "Dirección";
            dgvMostrarPacientes.Columns["telefono"].HeaderText = "Télefono";
            dgvMostrarPacientes.Columns["fecha_nacimiento"].HeaderText = "Fecha N.";
            dgvMostrarPacientes.Columns["mami_nombre"].HeaderText = "Apoderado M.";
            dgvMostrarPacientes.Columns["papi_nombre"].HeaderText = "Apoderado P.";
            dgvMostrarPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void mostrarPacientes()
        {
            pacienteCN pacienteCN = new pacienteCN();
            List<pacienteCE> pacienteCE = pacienteCN.mostrarPacientes();
            dgvMostrarPacientes.DataSource = pacienteCE;
        }
    }
}
