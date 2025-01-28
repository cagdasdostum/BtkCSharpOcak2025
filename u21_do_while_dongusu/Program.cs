//klavyeden 0 girilene kadar girilmiş olan
//sayıları toplayan örnek
int sayi = 0;
int toplam = 0; //hiç bir sayı girilmesiği için 0

do {
    Console.WriteLine("Bir sayı girin:");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;

} while(sayi!=0);

Console.WriteLine("Toplam = " + toplam);

