Console.WriteLine("Birinci sayıyı gir:");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı gir:");
int s2 = Convert.ToInt32(Console.ReadLine());
//bu aşamada kullanıcının girdiği iki sayı elimde
if(s1 > s2)
{
    Console.WriteLine($"{s1} büyük olan sayı, {s2} küçük olan sayı.");
}
else if(s1 < s2)
{
    Console.WriteLine($"{s2} büyük olan sayı, {s1} küçük olan sayı.");
}
else
{
    Console.WriteLine("Sayılar eşit.");
}