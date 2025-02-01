namespace u51_ef_telrehberi;

public class GuncelleEkrani
{
 public static void Goster(Db baglanti)
    {
        Console.WriteLine("Güncelleme Ekranı");//****
        
        Console.WriteLine("Güncellenecek kişinin Id:");//****
        int id = Convert.ToInt32(Console.ReadLine());//****
        //READ--------------
        Kisi kisi = baglanti.Kisiler.Find(id);//*****
        //----------------------
        //Kisi kisi = new();
        if(kisi == null)//****
        {
            Console.WriteLine("Kişi bulunamadı!");//****
            Console.ReadKey();
            return;//****
        }

        Console.Write("Adı girin:");
        kisi.Ad = Console.ReadLine();
        
        Console.Write("Soyadı girin:");
        kisi.Soyad = Console.ReadLine();

        Console.Write("Tel girin:");
        kisi.Tel = Console.ReadLine();
        
        Console.Write("Adres girin:");
        kisi.Adres = Console.ReadLine();
        //UPDATE-------------------------
        //baglanti.Kisiler.Add(kisi);//*******
        baglanti.SaveChanges();
        //-------------------------------
        Console.WriteLine("Kişi güncellenedi edildi.");//*****
        Console.WriteLine("Devam etmek için bir tuşa bas...");
        Console.ReadKey();
    }
}
