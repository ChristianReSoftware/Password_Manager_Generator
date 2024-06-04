public class PasswordEntry
{
    private string website = "";
    private string password = "";

    public string Website
    {
        get { return website; }
        set { website = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    // Konstruktor
    public PasswordEntry(string website, string password)
    {
        Website = website;
        Password = password;
    }
}
