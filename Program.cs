namespace ATMStarbank;

class Program
{
    static void Main(string[] args)
    {
        //Clases que se inicializan primero
        Conexion conex = new Conexion();
        Menu menu = new Menu();
        Inicializador inic = new Inicializador(); //Inicializa el resto de clases
       //La clase operaciones se inicializa hasta después para que pueda recibir las clases de inic
        Operaciones opc = new Operaciones(inic, conex, inic.serv, inic.menuDeb, inic.menuCred, inic.datosTar, menu); //Recibe el inicializador para que no se reinicie la inicialización y pueda existir la pérdida de datos
        conex.AbrirConexion();


        //Metodo para opciones
            opc.Opciones();
    }
}
