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

        AlreadyActive = 500,
        NotLongerAvailable = 501,

        //Plexo
        CommerceError = 800,
        PlexoAuthorizationError = 801,
        TransactionError = 802,
    }
}
