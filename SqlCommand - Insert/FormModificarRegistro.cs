using Connections;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace SqlCommand___Insert
{
    public partial class FormModificarRegistro : Form
    {
        public FormModificarRegistro()
        {
            InitializeComponent();
        }

        private void ConsultaCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(CodIngresado.Text);
                List<Producto> productos = Producto.ObtenerProductos();
                if (productos.Exists(p => p.Codigo == cod))
                {
                    MessageBox.Show("Codigo existente");
                    CodIngresado.Enabled = false;
                    ConsultaCodigo.Enabled = false;
                    ModificarReg.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Codigo inexistente");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Codigo no valido ingresado");
            }
            
        }

        private void ModificarReg_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new("server=DESKTOP-TK88LE4; database=Base1; integrated security=true"))
            {
                conexion.Open();
                try
                {
                    string desc = DescIngresada.Text, query;
                    int cod = int.Parse(CodIngresado.Text);  
                    double precio = double.Parse(PrecioIngresado.Text);
                    query = $"UPDATE DatosProducto SET descripcion='{desc}', precio={precio} WHERE codigo={cod}";
                    SqlCommand cmd = new(query, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro modificado con exito!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("El precio o la descripcion se ingresaron mal");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
