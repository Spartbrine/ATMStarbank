using Microsoft.Data.SqlClient;

namespace ATMStarbank;

public class Conexion
{
    private SqlConnection connection;
    private string connectionString;

    public Conexion() // Construye la cadena de conexión 
    {

        connectionString = "Server=tcp:mikeserver-utm.database.windows.net,1433;Initial Catalog=ATMStarbank;Persist Security Info=False;User ID=Mike;Password=30A16dmn;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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