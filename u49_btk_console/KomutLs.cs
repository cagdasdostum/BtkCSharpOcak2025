namespace u49_btk_console;

public class KomutLs
{
    public static void Calistir(string path,  string[] args)
    {
        string[] klasorler = Directory.GetDirectories(path);
        string[] dosyalar = Directory.GetFiles(path);

        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach(string klasor in klasorler)
        {
            Console.WriteLine(Path.GetFileName(klasor));
        }  
        
        Console.ForegroundColor = ConsoleColor.Blue;
        foreach(string dosya in dosyalar)
        {
            Console.WriteLine(Path.GetFileName(dosya));
        }
    }
}
