using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Şifre Uygulaması");
        Console.Write("Şifre Uzunluğu: ");
        int uzunluk = int.Parse(Console.ReadLine());

        string sifre = SifreOlustur(uzunluk);
        Console.WriteLine("Oluşturulan Şifre: " + sifre);

        Console.ReadLine();
    }

    static string SifreOlustur(int uzunluk)
    {
        const string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random rastgele = new Random();
        StringBuilder sifreBuilder = new StringBuilder();

        for (int i = 0; i < uzunluk; i++)
        {
            int rastgeleIndex = rastgele.Next(karakterler.Length);
            sifreBuilder.Append(karakterler[rastgeleIndex]);
        }

        return sifreBuilder.ToString();
    }
}