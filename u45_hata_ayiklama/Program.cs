Console.WriteLine("Hesaplama Uygulaması");


int s1 = 0, s2 = 0;//uygulama için global

try
{
    //bu aralıkta hata oluşursa
    Console.WriteLine("1.Sayıyı gir");
    s1 = Convert.ToInt32(Console.ReadLine());
    //Convert.ToInt32("beş")--hata
    Console.WriteLine("2.Sayıyı gir");
    s2 = Convert.ToInt32(Console.ReadLine());
}
catch (Exception hata)
{
    //burada hatayı yakala ve işle
    Console.WriteLine("Hata oluştu.");
    Console.WriteLine(hata.Message);
    return;//main metodunu sonlandırır
}



int top = s1 + s2;

Console.WriteLine($"Toplam = {top}");