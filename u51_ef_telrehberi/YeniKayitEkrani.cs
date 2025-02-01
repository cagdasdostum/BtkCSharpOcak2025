namespace u51_ef_telrehberi;

public class YeniKayitEkrani
{
    public static void Goster(Db baglanti)
    {
        Console.WriteLine("Yeni Kayıt Ekranı");
        Kisi kisi = new();

        Console.Write("Adı girin:");
        kisi.Ad = Console.ReadLine();
        
        Console.Write("Soyadı girin:");
        kisi.Soyad = Console.ReadLine();

        Console.Write("Tel girin:");
        kisi.Tel = Console.ReadLine();
        
        Console.Write("Adres girin:");
        kisi.Adres = Console.ReadLine();
        //CREATE-------------------------
        baglanti.Kisiler.Add(kisi);
        baglanti.SaveChanges();
        Console.WriteLine("Kişi kayıt edildi.");
        Console.WriteLine("Devam etmek için bir tuşa bas...");
        Console.ReadKey();
    }
}
