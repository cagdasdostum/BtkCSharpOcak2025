//rasgele 1-49 arasında 6 adet sayı üreten ve
//ürettiği sayıları bir dizi şeklinde dönen
//bir metot yazınız

//int[] sayilar = RasgeleUret();

int[] RasgeleUret()
{
    List<int> sonuc = new();
    Random rnd = new ();

    while(sonuc.Count < 6)
    {
        int sayi = rnd.Next(1, 49 + 1);
        sonuc.Add(sayi);
    }

    return sonuc.ToArray();//listeyi diziye dönüştür
}

void Yazdir(int[] liste)
{
    foreach (int s in liste)
    {
        Console.Write($"{s}, ");
    }
    Console.WriteLine();
}
///ANA PROGRAM----------------------
int[] sayilar = RasgeleUret();
Yazdir(sayilar);