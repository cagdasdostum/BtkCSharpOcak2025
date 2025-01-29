//klavyeden girilen bir metni
//stack kullanarak tersinden yazdırın
//Örnek;
//Bir metin girin: Programlama
//amalmargorP
Console.WriteLine("Bir metin girin:");
string metin = Console.ReadLine();

Stack<char> yigin = new ();
//metindeki tüm karakterleri döngü ile dolaş
//ve yigin içerisine ekle
foreach (char c in metin) 
{
    yigin.Push(c);
}
//yığındaki her karakteri yanyana ekrana yazdır
while (yigin.Count > 0)
{
    char c = yigin.Pop();
    Console.Write(c);
}