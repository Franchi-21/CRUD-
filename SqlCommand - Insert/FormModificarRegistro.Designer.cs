namespace SqlCommand___Insert
{
    partial class FormModificarRegistro
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
            this.CodIngresado = new System.Windows.Forms.TextBox();
            this.ConsultaCodigo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioIngresado = new System.Windows.Forms.TextBox();
            this.DescIngresada = new System.Windows.Forms.TextBox();
            this.ModificarReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el codigo para verificar su existencia:";
            // 
            // CodIngresado
            // 
            this.CodIngresado.Location = new System.Drawing.Point(311, 51);
            this.CodIngresado.Name = "CodIngresado";
            this.CodIngresado.Size = new System.Drawing.Size(100, 23);
            this.CodIngresado.TabIndex = 1;
            // 
            // ConsultaCodigo
            // 
            this.ConsultaCodigo.Location = new System.Drawing.Point(324, 80);
            this.ConsultaCodigo.Name = "ConsultaCodigo";
            this.ConsultaCodigo.Size = new System.Drawing.Size(75, 23);
            this.ConsultaCodigo.TabIndex = 2;
            this.ConsultaCodigo.Text = "Consultar";
            this.ConsultaCodigo.UseVisualStyleBackColor = true;
            this.ConsultaCodigo.Click += new System.EventHandler(this.ConsultaCodigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa la descripcion nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresa el precio nuevo:";
            // 
            // PrecioIngresado
            // 
            this.PrecioIngresado.Location = new System.Drawing.Point(242, 169);
            this.PrecioIngresado.Name = "PrecioIngresado";
            this.PrecioIngresado.Size = new System.Drawing.Size(100, 23);
            this.PrecioIngresado.TabIndex = 5;
            // 
            // DescIngresada
            // 
            this.DescIngresada.Location = new System.Drawing.Point(269, 133);
            this.DescIngresada.Name = "DescIngresada";
            this.DescIngresada.Size = new System.Drawing.Size(100, 23);
            this.DescIngresada.TabIndex = 6;
            // 
            // ModificarReg
            // 
            this.ModificarReg.Enabled = false;
            this.ModificarReg.Location = new System.Drawing.Point(251, 198);
            this.ModificarReg.Name = "ModificarReg";
            this.ModificarReg.Size = new System.Drawing.Size(75, 23);
            this.ModificarReg.TabIndex = 7;
            this.ModificarReg.Text = "Modificar";
            this.ModificarReg.UseVisualStyleBackColor = true;
            this.ModificarReg.Click += new System.EventHandler(this.ModificarReg_Click);
            // 
            // FormModificarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 256);
            this.Controls.Add(this.ModificarReg);
            this.Controls.Add(this.DescIngresada);
            this.Controls.Add(this.PrecioIngresado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsultaCodigo);
            this.Controls.Add(this.CodIngresado);
            this.Controls.Add(this.label1);
            this.Name = "FormModificarRegistro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Modificar registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox CodIngresado;
        private Button ConsultaCodigo;
        private Label label2;
        private Label label3;
        private TextBox PrecioIngresado;
        private TextBox DescIngresada;
        private Button ModificarReg;
    }
}