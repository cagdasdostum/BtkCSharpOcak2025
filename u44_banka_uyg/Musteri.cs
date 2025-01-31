namespace u44_banka_uyg;

public class Musteri
{
    public long MusteriNo { get; set; }
    public string AdSoyad {get; set;}

    public void Yazdir()
    {
        Console.WriteLine($"Müşteri No: {MusteriNo} - {AdSoyad}");
    }  
}
