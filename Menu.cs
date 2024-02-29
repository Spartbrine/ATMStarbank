namespace ATMStarbank;
class Menu 
{
    protected int opcion;
    protected string solicitud;
    protected string Tarjeta;
    public bool Bienvenida(Servicios serv, MenuDebito menuDeb, MenuCredito menuCred, DatosTarjeta datosTar)
    {
        bool salida = true;
 
        Console.WriteLine("Bienvenido a ATMStarbank");
        Console.WriteLine("¿Qué operación desea realizar hoy?");
        Console.WriteLine("1.- Acceder con tarjeta \n2.- Pago de servicios"); //En este caso como no debe de verse la opcion de apagar el sistema porque podria crear brechas de seguridad el administrador debe conocer el codigo de salida (en este caso será 2440) 
            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Opcion1(datosTar);
                break;

                case 2: 
                    Opcion2();
                break;
                case 2240: //Codigo que conoce el admnistrador para apagar el sistema
                    Console.WriteLine("Apagando sistema");
                    salida = false;
                break;
                default:
                    Console.WriteLine("Opción no válida");
                break;
            }

        return salida;

    }


    public void Opcion1(DatosTarjeta datosTar)
    {
       datosTar.PedirTarjeta();

    }
    public void Opcion2()
    {

    }
    


    
}