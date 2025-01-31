using System.IO;

string path = @"D:\BtkAkademiOcak2025";
Directory.CreateDirectory(path);
Console.WriteLine($"{path} isimli Klasör oluşturuldu");

path = "D:\\";



if(Directory.Exists(path))
{
    Console.WriteLine($"{path} klasörü var.");
    //klasörleri listele
    string[] altKlasorler = Directory.GetDirectories(path);
    Console.WriteLine($"Klasörler ({altKlasorler.Length})");
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    
    foreach(string klasor in altKlasorler)
    {
        Console.WriteLine(klasor);
    }

    Console.ResetColor();

    //dosyaları listele
    string[] dosyalar = Directory.GetFiles(path);
    Console.WriteLine($"Dosyalar ({dosyalar.Length})");
   
    Console.ForegroundColor= ConsoleColor.Blue;
   
    foreach(string dosya in dosyalar)
    {
        Console.WriteLine(dosya);
    }

    Console.ResetColor();

    string masaustu = Environment.
    GetFolderPath(Environment.SpecialFolder.Desktop);
    
    Console.WriteLine($"Masaüstü: {masaustu}");
    
    string systemFolderx86 = Environment.
    GetFolderPath(Environment.SpecialFolder.SystemX86);
 
    Console.WriteLine($"SystemFolderx86: {systemFolderx86}");

}

