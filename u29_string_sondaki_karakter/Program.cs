string metin = "Btk akademi ile C# Programlama Eğitimi";
char[] metin2 = { 'B', 't', 'k', ' ', 'a', 'k', 'a', 'd', 'e', 'm', 'i'};
//string - Karakter Dizesi (dizisi)
//string özelleştirilmiş bir dizidir

Console.WriteLine(metin[0]);
Console.WriteLine(metin[^1]);  
Console.WriteLine(metin[4..11]); 
Console.WriteLine(metin2);

foreach(var c in metin)
{
    Console.Write($"{c}-");
}