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
        Console.WriteLine($"Nama: {nama} | Role: {role}");
    }
}
class Siswa : User
{
    public string className;

    public Siswa(string nama, string email, string password, string role, string className) : base(nama, email, password, role)
    {
        className = className;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"{nama} dari kelas {className} sudah mengumpulkan tugas");
    }

}

class Guru : User
{
    public string mapel;

    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        mapel = mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {nama} telah manilai semua tugas {mapel}");
    }
}

