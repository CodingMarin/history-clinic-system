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
    public partial class ucCardReport : UserControl
    {
        public ucCardReport()
        {
            InitializeComponent();
        }

        public string Title { get { return lblTitle.Text; } set => lblTitle.Text = value; }
        public int Count { get { return int.Parse(lblData.Text); } set => lblData.Text = value.ToString(); }
    }
}
