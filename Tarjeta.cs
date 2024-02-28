using Microsoft.Data.SqlClient;
namespace ATMStarbank;

abstract class Tarjetas
{
    protected string numtarjeta, tipoTarjeta, saldo, credtarje;
    public abstract string Tarjeta {get;set;}
    public abstract string TipoTar {get;set;}
    public abstract string Saldo{get;set;}
    public virtual string CreditoTarje{get;set;}

    
}

class DatosTarjeta
{
    string solicitud, Tarjeta;
    private string connectionString;

    public void PedirTarjeta() //MEtodo que pide tarjeta
    {
        
         do
        {
            Console.WriteLine("Mencione los numeros de su tarjeta");
            Tarjeta = Console.ReadLine();
            if(Tarjeta.Length!=16|| !IsNumeric(Tarjeta))
            {
                Console.WriteLine("Verifique su tarjeta");
            }
        }while(!IsNumeric(Tarjeta) || Tarjeta.Length!=16);
        TipoTarjeta(Tarjeta);
    }
    public bool IsNumeric(string tarjeta) //Metodo para confirmar que sean numeros lo que ingresa el usuario
    {
        foreach (char c in tarjeta) // "c" se refiere a cada digito que va verificar por ser una variable tipo char
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    public bool TipoTarjeta(string tarjeta)
    {
        solicitud = "SELECT * FROM Tarjetas where Tarjeta = @TARJETA";
        int verificador;
        using(SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand comando = new SqlCommand(solicitud, connection);
            comando.Parameters.AddWithValue("@TARJETA", tarjeta);

            try
            {
                verificador = (int)comando.ExecuteScalar();
            }
            catch(Exception ex)
            {
                Console.WriteLine("No contamos con su numero de tarjeta registrado");
                return false;
            }

            return verificador > 0;
        }
    }
}