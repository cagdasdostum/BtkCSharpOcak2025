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
    foreach(string klasor in altKlasorler)
    {
        Console.WriteLine(klasor);
    }
    //dosyaları listele
    string[] dosyalar = Directory.GetFiles(path);
    Console.WriteLine($"Dosyalar ({dosyalar.Length})");
    foreach(string dosya in dosyalar)
    {
        Console.WriteLine(dosya);
    }
}

