﻿
using u49_btk_console;

string path;

do
{
    Console.ForegroundColor = ConsoleColor.White;
    path = Directory.GetCurrentDirectory();

    Console.Write($"BTK {Path.GetFileName(path)}>");

    string komut = Console.ReadLine();//cp yol1 yol2
    string[] komutArg = komut.Split(' ');

    switch (komutArg[0])
    {
        case "help": KomutHelp.Calistir();break;
        case "exit": return;//ana metodu sonlandır
            
        default: 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Komut bulunanmadı."); 
        break;
    }

} while(true);