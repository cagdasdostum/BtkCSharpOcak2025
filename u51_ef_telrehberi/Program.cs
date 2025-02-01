using Microsoft.EntityFrameworkCore;
using u51_ef_telrehberi;

Console.WriteLine("REHBER UYGULAMASI\n-------------------------");

Db baglanti = new ();

if(baglanti.Database.GetPendingMigrations().Count() > 0) //yeni bir değişiklik var mı?
{
    baglanti.Database.Migrate();//veritabanını günceller

    Console.WriteLine("Veritabanı Oluşturuldu/Güncellendi...");
}


//CRUD - Create, Read, Update, Delete
do
{
    Console.Clear();
    Console.WriteLine("1-Yeni Kayıt");
    Console.WriteLine("2-Listele");
    Console.WriteLine("3-Güncelle");
    Console.WriteLine("4-Sil");
    Console.WriteLine("0-Çıkış");
    Console.WriteLine("Lütfen seçiminizi girin:");
    int secim = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();

    if(secim == 1)
    {
        YeniKayitEkrani.Goster(baglanti);
    }
    else if(secim == 2)
    {
        ListeleEkrani.Goster(baglanti);
    }
    else if(secim == 3)
    {
        GuncelleEkrani.Goster(baglanti);
    }
    else if(secim == 4)
    {
        SilEkrani.Goster(baglanti);  
    }
    else if(secim == 0)
    {
        Console.WriteLine("Uygulamadan çıkıldı...");
        break;
    }
    else 
    {
        Console.WriteLine("Hatalı seçim.");
        Console.ReadKey();
    }

} while(true);


///Tüm kayıtları silmek için
/*
List<Kisi> liste = baglanti.Kisiler.ToList();
baglanti.Kisiler.RemoveRange(liste);
baglanti.SaveChanges();
*/

