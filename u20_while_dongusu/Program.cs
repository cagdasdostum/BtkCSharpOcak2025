string pinKodu = "1234";
string tahmin = "";
int deneme = 0; //Daha hiç denemedin

while(pinKodu != tahmin)//tahmin edilen doğru ise biter
{
    if(deneme > 0)//2.defa deniyorsan
    {
        Console.WriteLine("Bilemediniz. Tekrar deneyin.");
    }

    Console.WriteLine("Pin Kodunu Girin:");
    tahmin = Console.ReadLine();
    deneme++;//denediğin için 1 artır
}

Console.WriteLine("TEBRİKLER BİLDİNİZ :)");