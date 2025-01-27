//klavyeden 3 sınav notu girilecek
//ortalama hesaplanacak
//koşul < 50 ekrana BAŞARISIZ yazacak değilse BAŞARILI yazacak
Console.WriteLine("1.Notu gir:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.Notu gir:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3.Notu gir:");
int n3 = Convert.ToInt32(Console.ReadLine());

double ort = (n1 + n2 + n3) / 3.0; // (int + int + int)/double ==> int

Console.WriteLine("Ortalamanız: " + ort);

if(ort >= 50)
{
    Console.WriteLine("BAŞARILI...");
}
else 
{
    Console.WriteLine("BAŞARISIZ!!!");
}