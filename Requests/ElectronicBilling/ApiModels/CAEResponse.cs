namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.ApiModels
{
    public class CAEResponse
    {
        public string errorDes { get; set; }
        public bool hayError { get; set; }
        public bool hayErrorSpecified { get; set; }
        public int idInterno { get; set; }
        public bool idInternoSpecified { get; set; }
        public int numero { get; set; }
        public bool numeroSpecified { get; set; }
        public string numeroAutorizacion { get; set; }
        public string serie { get; set; }
    }
}
