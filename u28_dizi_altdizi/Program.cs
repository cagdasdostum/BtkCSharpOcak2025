int[] sayilar = [5, 1, 0, 9, 12, 4, 8];

Console.WriteLine(sayilar[2]);//0
Console.WriteLine(sayilar[^3]);//12
var yeniDizi = sayilar[2..5];//0,9,12
foreach(var s in yeniDizi)
{
    Console.Write($"{s}, ");
}

Console.WriteLine();//boş yani alta geç

var yeniDizi2 = sayilar[^6..];
foreach(var s in yeniDizi2)
{
    Console.Write($"{s}, ");
}

Console.WriteLine();//boş yani alta geç

for(int i = 0;i < yeniDizi2.Length;i++) //foreach ile aynı mantık
{
    var s = yeniDizi2[i];
     Console.Write($"{s}, ");
}