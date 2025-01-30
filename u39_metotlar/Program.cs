//metot tanımlandı
int Topla(int a, int b) //imza (başlık)
{
    int sonuc = a + b;  //gövde
    return sonuc;
}

void EkraniTemizle()
{
    Console.Clear();
} 

void Bekle()
{
    Console.WriteLine("Çıkmak için bir tuşa basın...");
    //Console.ReadLine();//Enter tuşuna basılınca alta geçer
    Console.ReadKey();
}

int toplamDeger = Topla(21 , 8);//metodu çağır
//metotdan gelen değeri bir değişkene aktar

int toplam2 = Topla(-5 , 9);

EkraniTemizle();//geriye değer döndürmez

Console.WriteLine($"toplamDeger: {toplamDeger}");
Console.WriteLine($"toplam2: {toplam2}");

Bekle();