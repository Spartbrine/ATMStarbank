namespace ATMStarbank;
class Inicializador
{
     private Conexion conex;
     private TarjetaDebito deb;
     private TarjetaCredito cred;
     private Servicios serv;
     private Menu menu1;
     private MenuDebito menuDeb;
     private MenuCredito menuCred;
     private TarjetaCredito tarCre;
     private TarjetaDebito tarDeb;
     public Inicializador() //Inicialización de todas las clases que falto por inicializar en Program ¿Para que? Tener más seguridad, organización
     {
          conex = new Conexion();
          deb = new TarjetaDebito();
          cred = new TarjetaCredito();
          serv = new Servicios();
          menu1 = new Menu();
          menuDeb = new MenuDebito();
          menuCred = new MenuCredito();
          tarDeb = new TarjetaDebito();
          tarCre = new TarjetaCredito();
     }
    public void UseClasses() //Lo usare de plantilla para acceder a los metodos de mis clases
    {
        // Puedes llamar a los métodos de las clases aquí
        class1Instance.Method1OfClass1();
        class1Instance.Method2OfClass1();

        class2Instance.Method1OfClass2();
        class2Instance.Method2OfClass2();

        class3Instance.Method1OfClass3();
        class3Instance.Method2OfClass3();

        class4Instance.Method1OfClass4();
        class4Instance.Method2OfClass4();

        class5Instance.Method1OfClass5();
        class5Instance.Method2OfClass5();
    }
}