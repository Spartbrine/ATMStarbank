namespace ATMStarbank;
class Menu (Servicios serv, MenuDebito menuDeb, MenuCredito menuCred)
{
    protected string opcion;
    protected string Tarjeta;
    public void Menu1()
    {
        Console.WriteLine("Bienvenido a ATMStarbank");
        Console.WriteLine("¿Qué operación desea realizar hoy?");
        Console.WriteLine("1.- Acceder con tarjeta \n 2.- Pago de servicios"); //En este caso como no debe de verse la opcion de apagar el sistema porque podria crear brechas de seguridad el administrador debe conocer el codigo de salida (en este caso será 2440) 
            opcion = Console.ReadLine();
        switch(opcion)
        {
            case "1":
                Opcion1();
            break;
            case "2": 
                Opcion2();
            break;
            case "2240": //Codigo que conoce el admnistrador para apagar el sistema
                Console.WriteLine("Apagando sistema");
                Environment.Exit(0);
            break;
            default:
                Console.WriteLine("Opción no válida");
            break;
        }
    }


    public void Opcion1()
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
  

    }
    public void Opcion2()
    {
        
    }
    
    
    
    
    
    
    static bool IsNumeric(string tarjeta) //Metodo para confirmar que sean numeros lo que ingresa el usuario
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

    
}