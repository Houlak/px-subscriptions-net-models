namespace Goova.Subscriptions.Models.Error
{
    public enum ErrorSubCode
    {
        Ok = 0,
        UnknownError = 100,
        ConnectionError = 101,
        ArgumentError = 600,

        UserError = 650,

        CredentialsError = 700,
    }
}
