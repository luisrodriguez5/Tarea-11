using System;

namespace Reguistros.UI.Registro
{
    partial class FormPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.EstrenoLabel = new System.Windows.Forms.Label();
            this.EstrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ElimiarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.DisplayMember = "Descripcion";
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(107, 148);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(200, 21);
            this.CategoriaComboBox.TabIndex = 42;
            this.CategoriaComboBox.ValueMember = "Descripcion";
            this.CategoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriaComboBox_SelectedIndexChanged);
            // 
            // EstrenoLabel
            // 
            this.EstrenoLabel.AutoSize = true;
            this.EstrenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstrenoLabel.Location = new System.Drawing.Point(21, 75);
            this.EstrenoLabel.Name = "EstrenoLabel";
            this.EstrenoLabel.Size = new System.Drawing.Size(54, 16);
            this.EstrenoLabel.TabIndex = 41;
            this.EstrenoLabel.Text = "Estreno";
            // 
            // EstrenoDateTimePicker
            // 
            this.EstrenoDateTimePicker.Location = new System.Drawing.Point(107, 71);
            this.EstrenoDateTimePicker.Name = "EstrenoDateTimePicker";
            this.EstrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EstrenoDateTimePicker.TabIndex = 40;
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(21, 149);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(67, 16);
            this.CategoriaLabel.TabIndex = 39;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(202, 31);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 38;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // ElimiarButton
            // 
            this.ElimiarButton.Location = new System.Drawing.Point(218, 198);
            this.ElimiarButton.Name = "ElimiarButton";
            this.ElimiarButton.Size = new System.Drawing.Size(75, 23);
            this.ElimiarButton.TabIndex = 37;
            this.ElimiarButton.Text = "Eliminar";
            this.ElimiarButton.UseVisualStyleBackColor = true;
            this.ElimiarButton.Click += new System.EventHandler(this.ElimiarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(130, 198);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 36;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(42, 198);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 35;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(107, 109);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.DescripcionTextBox.TabIndex = 34;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(107, 33);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(82, 20);
            this.IdTextBox.TabIndex = 33;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(21, 111);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(80, 16);
            this.DescripcionLabel.TabIndex = 32;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(21, 34);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(70, 16);
            this.IdLabel.TabIndex = 31;
            this.IdLabel.Text = "Pelicula Id";
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.EstrenoLabel);
            this.Controls.Add(this.EstrenoDateTimePicker);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ElimiarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "FormPelicula";
            this.Text = "FormPelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Label EstrenoLabel;
        private System.Windows.Forms.DateTimePicker EstrenoDateTimePicker;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ElimiarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label IdLabel;
    }
}