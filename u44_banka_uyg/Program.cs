
//Müşteriler var
//Müşterilere ait hesaplar
//Müşteri ekleneblir
//Müşteriler Listelenebilir
//Müşteriye Hesap açılabilir
//Hesaba para yatırılabilir/çekilebilir
//Bir hesaptan başka hesaba havale edilebilir

using u44_banka_uyg;

int secim = 0;
List<Musteri> musteriListesi = new();
do
{
    secim = MenuEkrani.Goster();

    if(secim == 1)
    {
        MusteriEklemeEkrani.Goster(musteriListesi);
    }
    else if(secim == 2)
    {
        MusteriListemeEkrani.Goster(musteriListesi);
    }
    else if(secim == 0)
    {
        Console.WriteLine("Uygulama sona erdi...");
    }
    else
    {
        Console.WriteLine("Hatalı seçim...");
        Console.ReadKey();
    }

} while(secim!=0);