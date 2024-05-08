namespace Goova.Subscriptions.Models.Enumerables
{
    public enum BillingType
    {
        ETicketCuentaAjena = 131, //Consumidor final con CI
        EFacturaCuentaAjena = 141, //Consumidor final con RUT

        NotaCreditoETicket = 132, //Anular ETicket
        NotaCreditoEFactura = 142, //Anular EFactura
    }
}
