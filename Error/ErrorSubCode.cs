namespace Goova.Subscriptions.Models.Error
{
    public enum ErrorSubCode
    {
        Ok = 0,
        UnknownError = 100,
        ModelValidationError = 101,
        ArgumentError = 102,
        
        CredentialsError = 200,

        AlreadyAdded = 300,
        ClientDoesNotExist = 301,
        IncorrectClient = 302,
        SubscriptionTypeDoesNotExist = 303,


        AlreadyActive = 500,
        NotLongerAvailable = 501,

        //Plexo
        PlexoGeneralError = 760,
        CommerceError = 800,
        PlexoAuthorizationError = 801,
        TransactionError = 802,
        InstrumentError = 803,
    }
}
