namespace ATMStarbank;
class Operaciones (Inicializador inic, Conexion conex,Servicios serv, MenuDebito menuDeb, MenuCredito menuCred, DatosTarjeta datosTar, Menu menu)
{
    public void Opciones()
    {
        //Inicio de la operacion
        menu.Bienvenida(serv, menuDeb, menuCred, datosTar);

    }
}