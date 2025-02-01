namespace u51_ef_telrehberi;

public class SilEkrani
{
    public static void Goster(Db baglanti)
    {
        Console.WriteLine("Silme Ekranı");
        Console.WriteLine("Silinecek kişi Id:");
        int id = Convert.ToInt32(Console.ReadLine());
        //READ----------------------------------
        Kisi kisi = baglanti.Kisiler.Find(id);
        //--------------------------------------

        if(kisi == null)
        {
            Console.WriteLine("Kişi bulunamadı!");
            Console.ReadKey();
            return;
        }

        //DELETE----------------------------
        baglanti.Kisiler.Remove(kisi);
        baglanti.SaveChanges();
        //---------------------------------
        Console.WriteLine("Kişi silindi.");
        Console.WriteLine("Devam etmek için bir tuşa bas...");
        Console.ReadKey();
    }
}
