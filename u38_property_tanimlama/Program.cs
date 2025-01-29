Kitap[] kitaplar = [
    new (){ Ad = "C# Öğreniyorum", Fiyat = 199 }, 
    new (){ Ad = "Python", Fiyat = 179 }, 
    new (){ Ad = "Yapay Zeka Temelleri", Fiyat = 256 }
];

Console.OutputEncoding = System.Text.Encoding.UTF8;
//kitaplar[0].SayfaAdedi = 450; //SayfaAdedi sadece get yapılabilir
foreach(Kitap k in kitaplar)
{
    Console.Write($"Kitap Adı: {k.Ad} Fiyat: {k.Fiyat:c2}\n");
}

class Kitap
{
    //propertyler büyükharf ile başlar 
    public string Ad {get; set;}//get okuma, set yazma
    public double Fiyat {get; set;}
    public int SayfaAdedi{get;}//set olmadığından değiştirilemez
}
