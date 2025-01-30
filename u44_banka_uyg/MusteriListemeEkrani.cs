namespace u44_banka_uyg;

public class MusteriListemeEkrani
{
    public static void Goster(List<Musteri> liste)
    {
        Console.Clear();
        Console.WriteLine("Müşteri Listesi");

        foreach (Musteri m in liste)
        {
            m.Yazdir();
        }

        Console.WriteLine("Müşteriler listelendi. Devam etmek için bir tuşa bas...");
        Console.ReadKey();//bir tuşa basılana kadar bekle
    }
}
