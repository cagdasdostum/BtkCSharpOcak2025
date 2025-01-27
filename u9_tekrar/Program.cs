//Değişken tanımlama ve veri türleri
int sayi = 155;
var a = 3.14;
string metin = "35";

//tip dönüşüm işlemleri
int b = Convert.ToInt32(metin);//Convert
byte c = (byte)sayi;//Casting

//ekrana yazdırma
Console.WriteLine(sayi);
Console.WriteLine(c);
//klavyeden okuma
Console.WriteLine("Merhaba, Nasılsın?");
string cevap = Console.ReadLine();
Console.WriteLine("Klavyeden bir sayı girer misin?");
int girilenSayi = Convert.ToInt32(Console.ReadLine());
//değerleri birleştirme
Console.WriteLine($"Cevabınız: {cevap} \nGirdiğiniz sayı: {girilenSayi}");
//operatörler
byte d = 4;//00000100 = 4  ====> 11111011 = 251

Console.WriteLine((byte)~d);
