Kitap[] kitaplar = [
    new (){ Ad = "C# Öğreniyorum", Fiyat = 199, SayfaAdedi = -5 }, 
    new (){ Ad = "Python", Fiyat = 179 , SayfaAdedi = 149}, 
    new (){ Ad = "Yapay Zeka Temelleri", Fiyat = 256, SayfaAdedi= 400 }
];

Console.OutputEncoding = System.Text.Encoding.UTF8;
//kitaplar[0].SayfaAdedi = 450; //SayfaAdedi sadece get yapılabilir
foreach(Kitap k in kitaplar)
{
    Console.Write($"Kitap Adı: {k.Ad} Fiyat: {k.Fiyat:c2} Sayfa:{k.SayfaAdedi}\n");
}

class Kitap
{
    private int sayfa;
    //propertyler büyükharf ile başlar 
    public string Ad {get; set;}//get okuma, set yazma
    public double Fiyat {get; set;}//varsayılan get; set;(otomatik property)
    public int SayfaAdedi {
        get => sayfa; 
        set => sayfa = value < 0 ? 0 : value;
    }
}
