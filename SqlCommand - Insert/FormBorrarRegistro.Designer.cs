namespace SqlCommand___Insert
{
    partial class FormBorrarRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un codigo para borrar el registro:";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(251, 29);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 23);
            this.Codigo.TabIndex = 1;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(265, 58);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // FormBorrarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 99);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label1);
            this.Name = "FormBorrarRegistro";
            this.ShowIcon = false;
            this.Text = "Borrar registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Codigo;
        private Button Eliminar;
    }
}