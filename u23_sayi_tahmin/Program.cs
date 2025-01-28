//+rasgele bir sayı tutabilme
//+döngü içerinde kullanıcıdan tahmini alabilmeli
//bilemdiğinde if ile kontrol edip yönlendirme yapmalı
//hakkı bittiğinde döngüden çıkılmalı
//bilemediğinde tuttuğu sayıyı söylesin
//bilirse döngü sona ermeli ve tebrik etmeli
int sayi = new Random().Next(100);
int hak = 5; //5 hakkın var
Console.WriteLine("Tutulan Sayi:" + sayi);
Console.WriteLine("0-100 aralığında bir rasgele sayı tuttum.");
do
{
    Console.WriteLine("Tahminin:");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    hak--;//hakkın bir azaldı

    if(hak == 0 && tahmin !=sayi)//hem hakkın bitti hem bilemedin
    {
        Console.WriteLine("Üzgünüm:) Bilemediniz.");
        Console.WriteLine($"Tuttuğum sayı {sayi}");
        break;
    }

    if(tahmin > sayi)
    {
        Console.WriteLine("Daha Küçük");
    }
    else if(tahmin < sayi)
    {
        Console.WriteLine("Daha Büyük");
    }
    else
    {
        Console.WriteLine("TEBRİKLER! BİLDİNİZ...");
        break;//döngüden çıkar
    }

} while(true);