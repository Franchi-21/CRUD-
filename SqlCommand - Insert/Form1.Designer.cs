namespace SqlCommand___Insert
{
    partial class IngresoDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.GuardarBaseDatos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosIngresadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo:";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(253, 115);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(100, 23);
            this.Descripcion.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(230, 86);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 23);
            this.Codigo.TabIndex = 4;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(224, 144);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 23);
            this.Precio.TabIndex = 5;
            // 
            // GuardarBaseDatos
            // 
            this.GuardarBaseDatos.Location = new System.Drawing.Point(201, 185);
            this.GuardarBaseDatos.Name = "GuardarBaseDatos";
            this.GuardarBaseDatos.Size = new System.Drawing.Size(106, 23);
            this.GuardarBaseDatos.TabIndex = 6;
            this.GuardarBaseDatos.Text = "Guardar datos";
            this.GuardarBaseDatos.UseVisualStyleBackColor = true;
            this.GuardarBaseDatos.Click += new System.EventHandler(this.GuardarBaseDatos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDatosIngresadosToolStripMenuItem,
            this.BorrarRegistro,
            this.ModificarRegistro});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // mostrarDatosIngresadosToolStripMenuItem
            // 
            this.mostrarDatosIngresadosToolStripMenuItem.Name = "mostrarDatosIngresadosToolStripMenuItem";
            this.mostrarDatosIngresadosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.mostrarDatosIngresadosToolStripMenuItem.Text = "Mostrar datos ingresados";
            this.mostrarDatosIngresadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatosIngresadosToolStripMenuItem_Click);
            // 
            // BorrarRegistro
            // 
            this.BorrarRegistro.Name = "BorrarRegistro";
            this.BorrarRegistro.Size = new System.Drawing.Size(207, 22);
            this.BorrarRegistro.Text = "Borrar un registro";
            this.BorrarRegistro.Click += new System.EventHandler(this.BorrarRegistro_Click);
            // 
            // ModificarRegistro
            // 
            this.ModificarRegistro.Name = "ModificarRegistro";
            this.ModificarRegistro.Size = new System.Drawing.Size(207, 22);
            this.ModificarRegistro.Text = "Modificar un registro";
            this.ModificarRegistro.Click += new System.EventHandler(this.ModificarRegistro_Click);
            // 
            // IngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 249);
            this.Controls.Add(this.GuardarBaseDatos);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IngresoDatos";
            this.ShowIcon = false;
            this.Text = "Sistema de almacenamiento de productos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Descripcion;
        private TextBox Codigo;
        private TextBox Precio;
        private Button GuardarBaseDatos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem mostrarDatosIngresadosToolStripMenuItem;
        private ToolStripMenuItem BorrarRegistro;
        private ToolStripMenuItem ModificarRegistro;
    }
}