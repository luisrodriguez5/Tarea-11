using Reguistros.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reguistros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1RegistroCategoria().Show();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPelicula().Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUsuarios().Show();
        }
    }
}
