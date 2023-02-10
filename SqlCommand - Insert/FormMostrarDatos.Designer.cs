namespace SqlCommand___Insert
{
    partial class FormMostrarDatos
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
            this.ArtRecuperados = new System.Windows.Forms.TextBox();
            this.RecuperarArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArtRecuperados
            // 
            this.ArtRecuperados.Location = new System.Drawing.Point(12, 12);
            this.ArtRecuperados.Multiline = true;
            this.ArtRecuperados.Name = "ArtRecuperados";
            this.ArtRecuperados.ReadOnly = true;
            this.ArtRecuperados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArtRecuperados.Size = new System.Drawing.Size(505, 161);
            this.ArtRecuperados.TabIndex = 0;
            // 
            // RecuperarArticulos
            // 
            this.RecuperarArticulos.Location = new System.Drawing.Point(126, 179);
            this.RecuperarArticulos.Name = "RecuperarArticulos";
            this.RecuperarArticulos.Size = new System.Drawing.Size(272, 23);
            this.RecuperarArticulos.TabIndex = 1;
            this.RecuperarArticulos.Text = "Recuperar todos los articulos ingresados";
            this.RecuperarArticulos.UseVisualStyleBackColor = true;
            this.RecuperarArticulos.Click += new System.EventHandler(this.RecuperarArticulos_Click);
            // 
            // FormMostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 217);
            this.Controls.Add(this.RecuperarArticulos);
            this.Controls.Add(this.ArtRecuperados);
            this.Name = "FormMostrarDatos";
            this.ShowIcon = false;
            this.Text = "Mostrar datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ArtRecuperados;
        private Button RecuperarArticulos;
    }
}