using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlCommand___Insert
{
    public partial class FormBorrarRegistro : Form
    {
        public FormBorrarRegistro()
        {
            InitializeComponent();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new("server=DESKTOP-TK88LE4; database=Base1; integrated security=true"))
            {
                conexion.Open();
                string codigo = Codigo.Text;
                SqlCommand cmd = new($"DELETE FROM DatosProducto WHERE codigo={codigo}", conexion);
                if (cmd.ExecuteNonQuery() is 1)
                    MessageBox.Show("Operacion exitosa!");
                else
                    MessageBox.Show("No existe el producto con el codigo ingresado");
                conexion.Close();
            }           
        }
    }       
}
