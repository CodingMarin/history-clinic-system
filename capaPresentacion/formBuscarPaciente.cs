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
    public partial class formBuscarPaciente : Form
    {
        public string Titulo { get; set; }
        public string Mensaje { get; set; }

        public formBuscarPaciente()
        {
            InitializeComponent();
        }

        private void formBuscarPaciente_Load(object sender, EventArgs e)
        {
            Text = Titulo;
            lblMensaje.Text = Mensaje;
        }
    }
}
