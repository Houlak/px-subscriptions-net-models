namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.ApiModels
{
    public class ElectronicBillingResponse
    {
        public string datosCaeSerie { get; set; }
        public string datosCaeVencimiento { get; set; }
        public string hash { get; set; }
        public bool hayError { get; set; }
        public bool hayErrorSpecified { get; set; }
        public string mensaje { get; set; }
        public string mensajeDebug { get; set; }
        public object qr { get; set; }
        public string resolucion { get; set; }
        public string urlQR { get; set; }
        public string urlWebConsulta { get; set; }
    }
}
