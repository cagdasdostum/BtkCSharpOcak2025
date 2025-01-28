//klavyeden girilen sayının faktöryelini hesapla
// 5! = 5 * 4 * 3 * 2 * 1
// 0! = 1
// negatif sayıların faktoryeli hesaplanamaz
Console.Write("Bir sayı girin:");
int sayi = Convert.ToInt32(Console.ReadLine());

if(sayi>=0)
{
    ulong sonuc = 1; //ulong işaretsiz 64bit tamsayı
    for(int i = sayi; i>=1; i--)
    {
        //i döngü değişkeni --> sayi -- sayi-1 ---- 5 -- 4 -- 3 -- 2 -- 1
        sonuc = sonuc * (ulong)i; //sonucun üzerine çarparak ekleyelim
    }

    Console.WriteLine($"{sayi}! = {sonuc}"); 
}
else
{
    Console.WriteLine("Negatif sayıların faktöryeli hesaplanamaz!");
}
