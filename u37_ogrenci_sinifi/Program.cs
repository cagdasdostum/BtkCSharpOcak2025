/*
List<int> numaralar = new();
List<string> isimler = new();
List<double> ortalamalar = new();
*/
List<Ogrenci> liste = new();

do
{
    Console.WriteLine("Eklenecek Numara:");
    int nu = Convert.ToInt32(Console.ReadLine());
    
    if(nu == 0)
        break;

    Console.WriteLine("İsmini girin:");
    string isim = Console.ReadLine();
    Console.WriteLine("Ortalamasını girin:");
    double ort = Convert.ToDouble(Console.ReadLine());
    //elimde klavyeden girilmiş 3 veri var (nu, isim, ort)
    Ogrenci ogr = new();//yeni bir öğrenci örneği oluştur
    ogr.numara = nu;
    ogr.isim = isim;
    ogr.ortalama = ort;

    liste.Add(ogr);//yeni öğrenciyi listeye ekle
} while(true);

foreach(Ogrenci o in liste) //öğrencileri ekrana yazdır
{
    Console.WriteLine($"Nu: {o.numara} isim:{o.isim} ort:{o.ortalama}");
}

class Ogrenci
{
    public int numara;
    public string isim;
    public double ortalama;
}
