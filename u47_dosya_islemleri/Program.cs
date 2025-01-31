using System.IO;

string folderPath = "D:\\BtkAkademiOcak2025";
if(!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Klasör oluşturuldu.");
}

string filePath = folderPath + "\\merhaba.txt";
string icerik = "Merhaba, c# programlama dili.";

File.WriteAllText(filePath, icerik);
Console.WriteLine("Dosya oluşturuldu.");

