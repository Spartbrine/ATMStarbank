namespace ATMStarbank;
class Inicializador
{

    public TarjetaDebito deb { get; private set; }
    public TarjetaCredito cred { get; private set; }
    public Servicios serv { get; private set; }
    public Menu menu1 { get; private set; }
    public MenuDebito menuDeb { get; private set; }
    public MenuCredito menuCred { get; private set; }
    public TarjetaCredito tarCre { get; private set; }
    public TarjetaDebito tarDeb { get; private set; }
    public DatosTarjeta datosTar { get; private set; }

    public Inicializador()
    {
        deb = new TarjetaDebito();
        cred = new TarjetaCredito();
        serv = new Servicios();
        menu1 = new Menu();
        menuDeb = new MenuDebito();
        menuCred = new MenuCredito();
        tarDeb = new TarjetaDebito();
        tarCre = new TarjetaCredito();
        datosTar = new DatosTarjeta();
    }


    public void UseClasses() //Lo usare de plantilla para acceder a los metodos de mis clases
    {
        // // Puedes llamar a los métodos de las clases aquí
        // class1Instance.Method1OfClass1();
        // class1Instance.Method2OfClass1();

        // class2Instance.Method1OfClass2();
        // class2Instance.Method2OfClass2();

        // class3Instance.Method1OfClass3();
        // class3Instance.Method2OfClass3();

        // class4Instance.Method1OfClass4();
        // class4Instance.Method2OfClass4();

        // class5Instance.Method1OfClass5();
        // class5Instance.Method2OfClass5();
    }
}