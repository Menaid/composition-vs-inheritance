namespace composition_vs_inheritance;

public class User
{
    public string FirstName;
    public string LastName;
    public readonly string UserName;
    public string DOB;
    public string Email;
    private string _password;

    public User(string username, string email)
    {
        UserName = username;
        Email = email;
    }

    public int Age()
    {
        throw new NotImplementedException();
    }



}
