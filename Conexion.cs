using Microsoft.Data.SqlClient;

namespace ATMStarbank;

public class Conexion
{
    private SqlConnection connection;
    private string connectionString;

    public Conexion() // Construye la cadena de conexión 
    {

        connectionString = "Server=Insertar servidor;Database=Insertar base de datos;User Id= Usuario;Password=contraseña de acceso;Encrypt=True;Integrated Security=True";
        connection = new SqlConnection(connectionString);
    }

    public void AbrirConexion()
    {
        try
        {
            // Abre la conexión
            connection.Open();
            Console.WriteLine("Conexión abierta correctamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al abrir la conexión: \n" + ex.Message);
        }
    }
}