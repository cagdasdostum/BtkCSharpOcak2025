//1 den 20'ye kadar olan tek sayıları ekrana yazdırsın
Console.WriteLine("For döngüsü ile yapıldı");
for (int i = 1; i<=20; i+=2)
{
    Console.Write($"{i}, ");
}

Console.WriteLine("\nWhile döngüsü ile yapıldı");
int j = 1;
while (j<=20)
{
    Console.Write($"{j}, ");
    j+=2;
}

Console.WriteLine("\nDo-While döngüsü ile yapıldı");
int k = 1;
do
{
    Console.Write($"{k}, ");
    k+=2;

} while(k<=20);