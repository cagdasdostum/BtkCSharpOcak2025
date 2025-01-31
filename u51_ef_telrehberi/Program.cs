using Microsoft.EntityFrameworkCore;
using u51_ef_telrehberi;

Console.WriteLine("REHBER UYGULAMASI\n-------------------------");

Db baglanti = new ();

if(baglanti.Database.GetPendingMigrations().Count() > 0) //yeni bir değişiklik var mı?
{
    baglanti.Database.Migrate();//veritabanını günceller

    Console.WriteLine("Veritabanı Oluşturuldu/Güncellendi...");
}


