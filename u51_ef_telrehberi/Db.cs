using Microsoft.EntityFrameworkCore;

namespace u51_ef_telrehberi;

public class Db : DbContext //EF Core içinde bulunan DbContext
{                           //DbContext'in bütün özelliklerini devraldım
    public DbSet<Kisi> Kisiler { get; set; }//Kişiler Tablosu

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlite("Data Source=D:\\rehber.db");
    }
}
