using System.ComponentModel;

namespace u44_banka_uyg;

public class MenuEkrani
{
    public static int Goster()
    {
        Console.Clear();
        Console.WriteLine("1-Müşteri Ekle");
        Console.WriteLine("2-Hesap Aç");
        Console.WriteLine("3-Para Çek");
        Console.WriteLine("4-Para Yatır");
        Console.WriteLine("5-Havale Yap");
        Console.WriteLine("0-Çıkış");
        Console.Write("Seçiminizi girin:");
        return Convert.ToInt32(Console.ReadLine());
    }
}
