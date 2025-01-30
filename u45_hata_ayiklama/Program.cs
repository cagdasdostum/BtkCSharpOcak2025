int SayiOku(string mesaj)
{
    int s = 0;
    bool hataVardi = false;
    do
    {
        hataVardi = false;//hatayı sıfırla
        try
        {
            //bu aralıkta hata oluşursa
            Console.WriteLine(mesaj);
            s = Convert.ToInt32(Console.ReadLine());
            //Convert.ToInt32("beş")--hata

        }
        catch (Exception hata)
        {
            //burada hatayı yakala ve işle
            Console.WriteLine("Hata oluştu.");
            Console.WriteLine(hata.Message);
            hataVardi = true;
        }
        
    } while (hataVardi);

    return s;
}


Console.WriteLine("Hesaplama Uygulaması");


int s1 = 0, s2 = 0;//uygulama için global

s1 = SayiOku("1.Sayıoyo gir");
s2 = SayiOku("2.Sayıyı gir");

int top = s1 + s2;

Console.WriteLine($"Toplam = {top}");