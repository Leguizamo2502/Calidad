namespace Utilities.helpers
{
    public  class HashPassword
    {
       public static string EncriptPassword(string password)
       {
            return BCrypt.Net.BCrypt.HashPassword(password);
       }
    }
}
