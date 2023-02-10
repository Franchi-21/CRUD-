using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SqlCommand___Insert
{
    public partial class FormMostrarDatos : Form
    {
        public FormMostrarDatos()
        {
            InitializeComponent();
        }


        private void RecuperarArticulos_Click(object sender, EventArgs e)
        {
            RecuperarArticulos.Enabled = false;
            List<Producto> productos = Producto.ObtenerProductos();
            foreach (Producto p in productos)
            {
                ArtRecuperados.AppendText($"Codigo: {p.Codigo}. Descripcion: {p.Descripcion}. Precio: {p.Precio}");
                ArtRecuperados.AppendText(Environment.NewLine);
            }
                
        }
    }
}
