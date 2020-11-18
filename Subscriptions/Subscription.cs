using Goova.Subscriptions.Models.Instruments;
using Goova.Subscriptions.Models.Transactions;
using System;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class Subscription
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public string LegalId { get; set; } //Legal id of subscriptor in case of reduce iva
        public SubscriptionType.SubscriptionType SubscriptionType { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public TransactionState SubscriptionStatus { get; set; }
        public DateTime SubscriptionLastPaymentDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public Subscription(string Id,string Token,DateTime SubscriptionDate, DateTime LastPaymentDate,TransactionState SubscriptionStatus, int IdSubscriptionType,string NameSubscriptionType, string DescriptionSubscriptionType,Frequence Frequence, Currency Currency,decimal Cost, string TaxPercentage,DateTime ValidUntil, string LegalId)
        {
            this.Id = Id;
            this.Token = Token;
            this.SubscriptionDate = SubscriptionDate;
            this.SubscriptionLastPaymentDate = LastPaymentDate;
            this.SubscriptionStatus = SubscriptionStatus;
            this.SubscriptionType = new Models.SubscriptionType.SubscriptionType
            {
                Id = IdSubscriptionType,
                Name = NameSubscriptionType,
                Description = DescriptionSubscriptionType,
                Frequence = Frequence,
                Currency = Currency,
                SubscriptionBaseCost = Cost,
                TaxPercentage = TaxPercentage
            };
           this.ValidUntil = ValidUntil;
           this.LegalId = LegalId;
        }
        // create without tax percentage 
        public Subscription(string Id, string Token, DateTime SubscriptionDate, DateTime LastPaymentDate, TransactionState SubscriptionStatus, int IdSubscriptionType, string NameSubscriptionType, string DescriptionSubscriptionType, Frequence Frequence, Currency Currency, decimal Cost, DateTime ValidUntil, string LegalId)
        {
            this.Id = Id;
            this.Token = Token;
            this.SubscriptionDate = SubscriptionDate;
            this.SubscriptionLastPaymentDate = LastPaymentDate;
            this.SubscriptionStatus = SubscriptionStatus;
            this.SubscriptionType = new Models.SubscriptionType.SubscriptionType
            {
                Id = IdSubscriptionType,
                Name = NameSubscriptionType,
                Description = DescriptionSubscriptionType,
                Frequence = Frequence,
                Currency = Currency,
                SubscriptionBaseCost = Cost,
            };
            this.ValidUntil = ValidUntil;
            this.LegalId = LegalId;
        }

        //generic constructor
        public Subscription() { }
    }
}
