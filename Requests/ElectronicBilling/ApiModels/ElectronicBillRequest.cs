using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.ApiModels
{
    public class ElectronicBillRequest
    {
        public BillingType BillingType { get; set; }

        //Invoice (Emisor), example: Plexo
        public DocType DocTypeInvoice { get; set; } = DocType.Unknown; //Hardcoded 4
        public string DocNumberInvoice { get; set; }
        public string SocialReasonInvoice { get; set; } //If CI reciever, name of person

        //Receiver (Receptor), example: Saeta
        public DocType DocTypeReceiver { get; set; } = DocType.Unknown; //Hardcoded 4
        public string DocNumberReceiver { get; set; }
        public string SocialReasonReceiver { get; set; } //If CI reciever, name of person
        public string AdditionalInfoReceiver { get; set; } //In case no info from reciever, something to identify transaction or client

        //Payment Info
        public int Amount { get; set; } = 1; //Cantidad de items
        public int Currency { get; set; } = 153; //153 UYU, 150 DLR
        public BillingInd BillingInd { get; set; }
        public double UnitPrice { get; set; } //IVA inc.
        public string ProductName { get; set; }
        public string UniqueKey { get; set; }

        //References
        public System.DateTime FechaCFErefField { get; set; }
        public int IndicadorReferenciaGlobalField { get; set; } // por defecto es 0. Cuando son mas de 40 referencias en la lista se tiene que poner en 1 y poner solamente la razon de regencia ajena (razonReferenciaField)
        public string NombreEnumComprobanteTipoField { get; set; }
        public int NroCFERefField { get; set; }
        public int NroLinRefField { get; set; }
        public string RazonReferenciaField { get; set; } // esto va en null si las referencias son menos de 40 y si tenes el dato del documento para referenciar.
        public string SerieField { get; set; }
        public int Numero { get; set; }
        public string Autorizacion { get; set; }
    }
}
