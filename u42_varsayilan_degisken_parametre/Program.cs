//varsayılan parametreli metot
double UcretHesapla(double fiyat, double miktar = 1, double indirim = 0)
{
    double tutar = fiyat * miktar;

    if(indirim > 0)
    {
        tutar = tutar - tutar * (indirim / 100);
    }

    return tutar;
}

//değişken parametreli metot
void AltAltaYaz(params string[] liste)
{
    foreach(string str in liste)
        Console.WriteLine(str);
}

Console.WriteLine($"Ücret: {UcretHesapla(16)}");//UcretHesapla(16, 1, 0)
Console.WriteLine($"Ücret: {UcretHesapla(16, 10)}");
Console.WriteLine($"Ücret: {UcretHesapla(16, 10, 20)}");

AltAltaYaz("İzmir", "Ankara", "İstanbul", "Aydın", "Manisa");