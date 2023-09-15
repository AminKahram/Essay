namespace Framework.Security.Services
{
    public interface IPasswordHasher
    {
        string Hash(string Password);
        //(bool Verified, bool NeedUpgrade) Check(string Hash, string Password);
        (bool Verified, bool NeedsUpgrade) Check(string hash, string password);

    }
}
