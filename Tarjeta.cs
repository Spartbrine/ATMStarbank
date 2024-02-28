namespace ATMStarbank;

abstract class Tarjetas
{
    protected string numtarjeta, tipoTarjeta, saldo, credtarje;
    public abstract string Tarjeta {get;set;}
    public abstract string TipoTar {get;set;}
    public abstract string Saldo{get;set;}
    public virtual string CreditoTarje{get;set;}

    
}