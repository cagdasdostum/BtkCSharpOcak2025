using Microsoft.EntityFrameworkCore;

namespace u51_ef_telrehberi;

public class Db : DbContext //EF Core içinde bulunan DbContext
{                           //DbContext'in bütün özelliklerini devraldım
    public DbSet<Kisi> Kisiler { get; set; }//Kişiler Tablosu

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string dbFolder = desktop + "\\rehber veritabani";
        if(!Directory.Exists(dbFolder))
        {
            Directory.CreateDirectory(dbFolder);
        }
        optionsBuilder.UseSqlite($"Data Source={dbFolder}\\rehber.db");
    }
}
