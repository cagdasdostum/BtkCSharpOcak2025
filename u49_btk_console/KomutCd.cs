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
        string hedefPath="";

        if(hedef == "..")//bir üst klasör
        {
            hedefPath = Path.GetDirectoryName(path);
        }
        else
        {
            string[] altKlasorler =  Directory.GetDirectories(path);
            foreach(string klasor in altKlasorler) 
            {
                if(Path.GetFileName(klasor) == hedef)
                {
                    hedefPath = klasor;
                    break;
                }
            } 
        }

        if(string.IsNullOrEmpty(hedefPath))
            Directory.SetCurrentDirectory(hedefPath);
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dosya yada klasör bulunamadı.");
            return;
        }
    }
}
