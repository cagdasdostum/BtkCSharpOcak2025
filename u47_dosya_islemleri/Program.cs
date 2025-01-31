using System.IO;

string folderPath = "D:\\BtkAkademiOcak2025";
if(!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Klasör oluşturuldu.");
}

string filePath = folderPath + "\\merhaba.txt";
string icerik = "Merhaba, c# programlama dili.";

File.WriteAllText(filePath, icerik);//dosyayı açar, veriyi yazar, dosyayı kapatır.
Console.WriteLine("Dosya oluşturuldu.");

string okunan = File.ReadAllText(filePath);//dosyayı açar, veriyi oku, dosyayı kapatır
Console.WriteLine($"Okunan veri: {okunan}");

icerik = "\nBugün günlerden Cuma.";
File.AppendAllText(filePath, okunan);

okunan = File.ReadAllText(filePath);//dosyayı açar, veriyi oku, dosyayı kapatır
Console.WriteLine($"Tekrar Okunan veri: {okunan}");