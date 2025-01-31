Console.WriteLine("Json İşlmeleri");

Kisi kisi  = new() { Id = 1, Ad = "Kemal", Soyad = "Can", Tel = "5554441122" };

string jsonText = System.Text.Json.JsonSerializer.Serialize(kisi);
Console.WriteLine("Serileştirme: " + jsonText);

//dönüştürülmek istenen hedef tip generic olarak verilir
Kisi jsonKisi = System.Text.Json.JsonSerializer.Deserialize<Kisi>(jsonText);
Console.WriteLine($"Geri Serileştirme: {jsonKisi.Id} - "+
                        $"{jsonKisi.Ad} {jsonKisi.Soyad} {jsonKisi.Tel}");

class Kisi
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Tel { get; set; }
}
