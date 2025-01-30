namespace u44_banka_uyg;

public class Hesap
{
    public int HesapNumarasi { get; set; }
    public string HesapTuru { get; set; }   
    public double Bakiye { get; set; }

    public void Yazdir()
    {
        Console.WriteLine($"Hesap Numarası: {HesapNumarasi} "
        + $"- Hesap Türü: {HesapTuru} - Bakiye: {Bakiye}");
    }
}
