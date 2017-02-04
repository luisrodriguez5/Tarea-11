using Reguistros.BLL;
using Reguistros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reguistros.UI.Registro
{
    public partial class Form1RegistroCategoria : Form
    {
        public Form1RegistroCategoria()
        {
            InitializeComponent();
        }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            IdtextBox.Clear();
            DescripcionTextBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(DescripcionTextBox.Text);
            if (!Validar())
            {
                MessageBox.Show("Hay campos vacios...");
            }
            else if (CategoriaBLL.Guardar(categoria))
            {
                MessageBox.Show("Guardado con éxito!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdtextBox.Text))
            {
                Categoria categoria = CategoriaBLL.Buscar(Convert.ToInt32(IdtextBox.Text));
                if (categoria != null)
                {
                    if (CategoriaBLL.Eliminar(categoria))
                        MessageBox.Show("Eliminado con éxito!");
                }
                Limpiar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            DescripcionTextBox.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdtextBox.Text))
            {
                Categoria categoria = CategoriaBLL.Buscar(Convert.ToInt32(IdtextBox.Text));
                if (categoria != null)
                {
                    DescripcionTextBox.Text = categoria.Descripcion;
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }
    }
}
