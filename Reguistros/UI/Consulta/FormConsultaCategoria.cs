using Reguistros.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reguistros.UI.Consulta
{
    public partial class FormConsultaCategoria : Form
    {
        public object CategoriasDataGridView { get; private set; }

        public FormConsultaCategoria()
        {
            InitializeComponent();
        }
        private void FrmConsultaCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                var db = new RegistroDb();
                CategoriasDataGridView.DataSource = db.categorias.ToList<>;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
