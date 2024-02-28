namespace ATMStarbank;
class TarjetaCredito : Tarjetas
{
    public override string CreditoTarje { get => credtarje; set => credtarje = value; }
    public override string Saldo { get => saldo; set => saldo = value; }
    public override string Tarjeta { get => Tarjeta; set => Tarjeta = value; }
    public override string TipoTar { get => tipoTarjeta; set => tipoTarjeta = value; }

    
}