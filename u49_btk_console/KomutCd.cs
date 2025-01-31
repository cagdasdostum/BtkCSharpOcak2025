namespace u49_btk_console;

public class KomutCd
{
    public static void Calistir(string path, string[] args)
    {
        if(args.Length<2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Komut parametreleri eksik yada geçersiz.");
            return;
        }

        string hedef = args[1]; //hedef klasör yada ..

        if(hedef == "..")
        {
            string hedefPath = Path.GetDirectoryName(path);
        }
    }
}
