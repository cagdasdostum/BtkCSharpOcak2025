namespace u44_banka_uyg;

public class Musteri
{
    public int MusteriNo { get; set; }
    public string AdSoyad {get; set;}

    public void Yazdir()
    {
        Console.WriteLine($"Müşteri No: {MusteriNo} - {AdSoyad}");
    }  
}
