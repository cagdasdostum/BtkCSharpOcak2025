namespace u43_static_metot_degiskenadi_uygunmu;

public class KodlamaYardim
{
    public static bool UygunMu(string ad)
    {
        //1-Sayi ile başlayamaz
        //İçinde boşluk ve özel karakter olamaz
        Console.WriteLine($"{ad} Kontrol ediliyor....");
        
        if(char.IsDigit(ad[0]))
            return false;

        foreach(char c in ad)
        {
            if(char.IsWhiteSpace(c))
               return false;
            if(char.IsSymbol(c))
               return false;
            if(char.IsPunctuation(c))
               return false;
        }

        return true;
    }
}
