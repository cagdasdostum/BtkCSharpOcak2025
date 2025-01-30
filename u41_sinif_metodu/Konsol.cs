namespace u41_sinif_metodu;

public class Konsol
{
    public void Temizle() //*************************parametre yok
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
    }

    public void Temizle(ConsoleColor renk) //****parametre var (aşırı yüklenmiş)
    {
        Console.BackgroundColor = renk;
        Console.Clear();
    }



    public string MetinOku()
    {
        return Console.ReadLine();
    }

    public int SayiOku()//*********************
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    public void YazSatir(string metin)
    {
        Console.WriteLine(metin);
    }

    public int SayiOku(string mesaj)//*****aşırı yüklenmiş
    {
        YazSatir(mesaj);
        return Convert.ToInt32(Console.ReadLine());
    }
}
