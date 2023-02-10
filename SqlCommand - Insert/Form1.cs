using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using Connections;
using System;

namespace SqlCommand___Insert
{
    public partial class IngresoDatos : Form
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }

        private void GuardarBaseDatos_Click(object sender, EventArgs e)
        {
            SqlConnection baseDatos = new("server=DESKTOP-TK88LE4; database=Base1; integrated security=true");
            baseDatos.Open();
            try
            {
                int codigo = int.Parse(Codigo.Text);
                string desc = Descripcion.Text;
                double precio = double.Parse(Precio.Text);
                string query = $"INSERT INTO DatosProducto(codigo, descripcion, precio) VALUES ({codigo}, '{desc}', {precio})";
                SqlCommand qry = new(query, baseDatos);
                qry.ExecuteNonQuery();
                MessageBox.Show("Datos guardados correctamente!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Algunos de los datos fueron mal ingresados");
            }
            finally
            {
                baseDatos.Close();
            }
        }

        private void mostrarDatosIngresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarDatos formMostrarDatos = new();
            formMostrarDatos.ShowDialog();
        }

        private void BorrarRegistro_Click(object sender, EventArgs e)
        {
            FormBorrarRegistro formBorrarRegistro = new();
            formBorrarRegistro.ShowDialog();
        }

        private void ModificarRegistro_Click(object sender, EventArgs e)
        {
            FormModificarRegistro formModificarRegistro = new();
            formModificarRegistro.ShowDialog();
        }
    }
}