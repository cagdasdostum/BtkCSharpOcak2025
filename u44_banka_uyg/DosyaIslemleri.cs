namespace u44_banka_uyg;

using System.Text.Json;

public class DosyaIslemleri
{
    public static void Kaydet(List<Musteri> liste, string dosya)
    {
        string jsonText = JsonSerializer.Serialize(liste);

        File.WriteAllText(dosya, jsonText);
    }

    public static List<Musteri> DosyaAc(string dosya)
    {
        if(!File.Exists(dosya))
            return new List<Musteri>();

        string dosyadanOkunan =  File.ReadAllText(dosya);

        List<Musteri> liste = JsonSerializer.Deserialize<List<Musteri>>(dosyadanOkunan);

        return liste;
    }
}
