namespace ATMStarbank;

class Program
{
    static void Main(string[] args)
    {
        Inicializador inic = new Inicializador(); //Inicializa el resto de clases
        Operaciones opc = new Operaciones(inic); //Recibe el inicializador para que no se reinicie la inicialización y pueda existir la pérdida de datos
        Menu menu = new Menu();
        Conexion conex = new Conexion();
        conex.AbrirConexion();
        menu.Bienvenida(inic.serv, inic.menuDeb, inic.menuCred, inic.datosTar);
    }
}
