namespace Goova.Subscriptions.Models.Error
{
    public enum ErrorSubCode
    {
        Ok = 0,
        UnknownError = 100,
        ConnectionError = 101,

        ArgumentError = 600,
        CommerceError = 601,
        PlexoAuthorizationError = 602,
        IssuerNotSupported = 603,
        TransactionError = 604,

        UserError = 650,

        CredentialsError = 700,
    }
}
