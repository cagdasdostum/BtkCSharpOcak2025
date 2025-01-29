Dictionary<int, string> ogrenciler = new ();

int num = 0;
string ad = "";
do
{
    Console.WriteLine("Eklenecek Öğrencinin Numarası:");
    num = Convert.ToInt32(Console.ReadLine());
    if(num!=0)
    {
        //*****aynı numaraya ait öğrenci var ise ekleme tekrar başa dön
        if(ogrenciler.ContainsKey(num))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{num} numaralı öğrenci zaten var!");
            Console.ForegroundColor = ConsoleColor.White;
            continue;
        }

        Console.WriteLine("Eklenecek Öğrencinin Adı:");
        ad = Console.ReadLine();

        ogrenciler.Add(num, ad);//yeni öğrenciyi listeye ekle
    }

} while(num != 0);

Console.WriteLine("Tüm Öğrenciler");
foreach(var ogr in ogrenciler)
{
    Console.WriteLine ($"{ogr.Key} - {ogr.Value}");
}