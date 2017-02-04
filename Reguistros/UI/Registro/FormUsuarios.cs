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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text) || string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios(NombreTextBox.Text, ClaveTextBox.Text);
            if (!Validar())
            {
                MessageBox.Show("Hay campos vacios...");
            }
            else if (UsuariosBLL.Guardar(usuario))
            {
                MessageBox.Show("Guardado con éxito!");
            }
            Limpiar();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            NombreTextBox.Focus();
        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                Usuarios usuario = UsuariosBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (usuario != null)
                {
                    if (UsuariosBLL.Eliminar(usuario))
                        MessageBox.Show("Eliminado con éxito!");
                }
                Limpiar();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                Usuarios usuario = UsuariosBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (usuario != null)
                {
                    NombreTextBox.Text = usuario.Nombre;
                    ClaveTextBox.Text = usuario.Clave;
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }
    }
}
