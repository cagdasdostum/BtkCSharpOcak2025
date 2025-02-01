namespace u51_ef_telrehberi;

public class ListeleEkrani
{
    public static void Goster(Db baglanti)
    {
        Console.WriteLine("Listeleme Ekranı");
        //READ---------------------
        List<Kisi> liste = baglanti.Kisiler.ToList();
        //-------------------------------------------
        foreach(Kisi kisi in liste)
        {
            Console.WriteLine($"{kisi.Id} - {kisi.Ad} {kisi.Soyad}"+
            $" - {kisi.Tel} - {kisi.Adres}");
        }
        Console.WriteLine("Kişiler listelendi.");
        Console.WriteLine("Devam etmek için bir tuşa bas...");
        Console.ReadKey();
    }
}
