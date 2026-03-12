using System.Security.Cryptography.X509Certificates;

public class User
{
    public string nama;
    public string email;
    public string password;
    public string role;
    public User(string nama, string email, string password, string role)
    {
        this.nama = nama;
        this.email = email;
        this.password = password;
        this.role = role;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama:  {nama} | Role ");
    }
}
