//sayilar.txt isimli dosyadaki aralarında 
//virgül bulunan sayıları toplayan ve sonucu ekranda gösteren uygulama
//

string yol = "D:\\BtkAkademiOcak2025\\sayilar.txt";

if (File.Exists(yol))
{
    string icerik = File.ReadAllText(yol); //1,3,5 gibi
    string[] sayilarStr = icerik.Split(',');

    int toplam = 0;
    foreach (string str in sayilarStr)
    {
        int sayi = Convert.ToInt32(str);
        toplam += sayi;
    }
    Console.WriteLine($"Sayılar: {icerik}");
    Console.WriteLine($"Toplam: {toplam}");
}
else
{
    Console.WriteLine("Dosya bulunamadı!");
}



