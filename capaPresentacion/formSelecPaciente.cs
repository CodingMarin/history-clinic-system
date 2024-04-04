using capaEntidad;
using capaNegocio;
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
    public partial class formSelecPaciente : Form
    {
        private static formSelecPaciente instancia;

        public formSelecPaciente()
        {
            InitializeComponent();
            dgvMostrarPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ControlBox = false;
            this.KeyPreview = true;
        }

        public static formSelecPaciente ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new formSelecPaciente();
                return instancia;
            }

            return instancia;
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text == string.Empty)
            {
                MessageBox.Show("Inserte un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscarNombre.Focus();
                return;
            }

            string valorBuscado = txtBuscarNombre.Text;
            pacienteCN pacienteCN = new pacienteCN();
            List<pacienteCE> pacientes = pacienteCN.buscarByNombre(valorBuscado);

            // Limpiar las columnas existentes
            dgvMostrarPaciente.Columns.Clear();

            // Agregar columnas personalizadas (ID y Nombre)
            dgvMostrarPaciente.Columns.Add("paciente_id", "ID");
            dgvMostrarPaciente.Columns.Add("nombre", "Nombre");

            // Vincular los datos a las columnas
            foreach (var paciente in pacientes)
            {
                dgvMostrarPaciente.Rows.Add(paciente.paciente_id, paciente.nombre);
            }
        }


        private void dgvMostrarPaciente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMostrarPaciente.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvMostrarPaciente.SelectedRows[0];

                txtCodigo.Text = fila.Cells["paciente_id"].Value.ToString();
                txtNombre.Text = (string)fila.Cells["nombre"].Value;
            }
        }

        private void formSelecPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
