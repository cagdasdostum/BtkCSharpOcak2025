using System.ComponentModel;

namespace u44_banka_uyg;

public class MenuEkrani
{
    public static int Goster()
    {
        Console.Clear();
        Console.WriteLine("DOTNET BANK\n\n");

        Console.WriteLine("1-Müşteri Ekle");
        Console.WriteLine("2-Müşterileri Listele");
        Console.WriteLine("3-Hesap Aç");
        Console.WriteLine("4-Para Çek");
        Console.WriteLine("5-Para Yatır");
        Console.WriteLine("6-Havale Yap");
        Console.WriteLine("0-Çıkış");
        Console.Write("Seçiminizi girin:");
        return Convert.ToInt32(Console.ReadLine());
    }
}
