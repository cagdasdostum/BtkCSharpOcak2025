namespace u41_sinif_metodu;

public class Konsol
{
    public static void Temizle() //*************************parametre yok
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
    }

    public static void Temizle(ConsoleColor renk) //****parametre var (aşırı yüklenmiş)
    {
        Console.BackgroundColor = renk;
        Console.Clear();
    }



    public static string MetinOku()
    {
        return Console.ReadLine();
    }

    public static int SayiOku()//*********************
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void YazSatir(string metin)
    {
        Console.WriteLine(metin);
    }

    public static int SayiOku(string mesaj)//*****aşırı yüklenmiş
    {
        YazSatir(mesaj);
        return Convert.ToInt32(Console.ReadLine());
    }
}
