namespace ATMStarbank;
class Inicializador
{

    public TarjetaDebito deb { get; private set; }
    public TarjetaCredito cred { get; private set; }
    public Servicios serv { get; private set; }
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
        menuDeb = new MenuDebito();
        menuCred = new MenuCredito();
        tarDeb = new TarjetaDebito();
        tarCre = new TarjetaCredito();
        datosTar = new DatosTarjeta();
    }
}