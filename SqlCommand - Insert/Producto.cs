using System.Data.SqlClient;

namespace SqlCommand___Insert
{
    class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Producto(int cod, string desc, double precio)
        {
            Codigo = cod;
            Descripcion = desc;
            Precio = precio;
        }

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new(0);
            using (SqlConnection conexion = new("server=DESKTOP-TK88LE4; database=Base1; integrated security=true"))
            {
                conexion.Open();
                SqlCommand cmd = new("SELECT codigo, descripcion, precio FROM DatosProducto", conexion);
                SqlDataReader registros = cmd.ExecuteReader();
                while (registros.Read())
                {
                    int codigo = registros.GetInt32(0);
                    string descripcion = registros.GetString(1);
                    double precio = registros.GetDouble(2);
                    productos.Add(new Producto(codigo, descripcion, precio));
                }
                conexion.Close();
            }
            return productos;
        }
    }
}
