// namespace ATMStarbank;
// using Microsoft.Data.SqlClient;

// class Usuario
// {
//     public int Id { get; set; }
//     public string TipoTarjeta { get; set; }
//     public Usuario(int id)
//     {
//         Id = id;
//     }
//     public void ObtenerTipoTarjeta()
//     {
//         // Crear una instancia de BaseDeDatos y utilizarla para obtener el tipo de tarjeta
//         BaseDeDatos baseDeDatos = new BaseDeDatos();
//         TipoTarjeta = baseDeDatos.ObtenerTipoTarjetaUsuario(Id);
//     }

//     public void MostrarTipoTarjeta()
//     {
//         if (!string.IsNullOrEmpty(TipoTarjeta))
//         {
//             Console.WriteLine($"El usuario tiene una tarjeta de tipo: {TipoTarjeta}");
//         }
//         else
//         {
//             Console.WriteLine("No se encontró información de tarjeta para este usuario.");
//         }
//     }
// }

// class BaseDeDatos
// {
//     private string connectionString = "Data Source=tu_servidor;Initial Catalog=nombre_basedatos;User ID=tu_usuario;Password=tu_contraseña";

//     public string ObtenerTipoTarjetaUsuario(int idUsuario) //Este es un metodo para 
//     {
//         string tipoTarjeta = null;

//         try
//         {
//             using (SqlConnection conexion = new SqlConnection(connectionString))
//             {
//                 conexion.Open();
//                 string consultaSql = "SELECT tipo_de_tarjeta FROM Usuarios WHERE id_usuario = @idUsuario"; //El string es el codigo de sql, para modificar las tablas o recuperar datos

//                 using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
//                 {
//                     comando.Parameters.AddWithValue("@idUsuario", idUsuario);
//                     object resultado = comando.ExecuteScalar();

//                     if (resultado != null)
//                     {
//                         tipoTarjeta = Convert.ToString(resultado);
//                     }
//                 }
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error al intentar acceder a la base de datos: " + ex.Message);
//         }

//         return tipoTarjeta;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int idUsuario = 123; // Reemplaza esto con el ID del usuario que necesites

//         Usuario usuario = new Usuario(idUsuario);
//         usuario.ObtenerTipoTarjeta();
//         usuario.MostrarTipoTarjeta();
//     }
// }
