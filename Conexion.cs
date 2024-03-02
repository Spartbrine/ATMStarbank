using Microsoft.Data.SqlClient;

namespace ATMStarbank;

public class Conexion
{
    private SqlConnection connection;
    private string connectionString;

    public Conexion() // Construye la cadena de conexión 
    {
        connectionString =;
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