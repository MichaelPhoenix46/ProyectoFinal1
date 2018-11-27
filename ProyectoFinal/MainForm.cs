using ProyectoFinal.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMiembro r = new RegistroMiembro();
            r.MdiParent = this;
            r.Show();
        }
    }
}
