
using u49_btk_console;

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(">");
    string komut = Console.ReadLine();//cp yol1 yol2
    string[] komutArg = komut.Split(' ');

    switch (komutArg[0])
    {
        case "help": KomutHelp.Calistir();break;
        default: 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Komut bulunanmadı."); 
        break;
    }

} while(true);