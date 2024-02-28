namespace ATMStarbank;

class Program
{

    public Program()
    {
        Inicializador inic = new Inicializador(); //Inicializa el resto de clases
        Operaciones opc = new Operaciones(inic); //Recibe el inicializador para que no se reinicie la inicialización y pueda existir la pérdida de datos
    }


    static void Main(string[] args)
    {

        Console.WriteLine("");
    }
}
