namespace Freshprints.JWT
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}