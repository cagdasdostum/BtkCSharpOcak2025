Console.WriteLine("Bir metin girin:");
string metin = Console.ReadLine();

Console.WriteLine("Uzunluk = " + metin.Length);
Console.WriteLine(metin.ToUpper());
Console.WriteLine("Nokta ile mi Biter ?" + metin.EndsWith("."));

var kelimeler = metin.Split(' ');

Console.WriteLine($"İlk Kelime = {kelimeler[0]}");
Console.WriteLine($"Son Kelime = {kelimeler[^1]}");
Console.WriteLine($"Toplam Kelime = {kelimeler.Length}");

metin = metin.Replace(kelimeler[0], "*******");

Console.WriteLine("Yeni Metin = " + metin);
