int[] sayilar = [4, 8, 2, 1, -3];

//int s1 = 4
//int s2 = 8 ......

Console.WriteLine("Sayı Adedi:" + sayilar.Length);
Console.WriteLine("Dizideki Sayılar:");

for(int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"{sayilar[i]}, ");
}