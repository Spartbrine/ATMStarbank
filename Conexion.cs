using Microsoft.Data.SqlClient;

namespace ATMStarbank;

public class Conexion
{
    private string connectionString;
    private SqlConnection connection;
    private string server = "atmstarbanke2.redirectme.net", database = "ATMStarbank", username = "Remoto", password = "P1lat4no901LF25";
    public Conexion()
    {
        // Construye la cadena de conexión
        connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
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