//kullanıcı klavyeden 5 adet sayı girecek
//kullanıcı hiç sayı girmediği noktada 
//en küçük ve en büyük sayıyı saklayacak değişkenler tanımlayın
//ek = Maks Int değerini ver, eb = Min Int değerini ver
//her döngüde karşılaştır ve yeni girilen ile yer değiştir
int ek = int.MaxValue;//2milyar
int eb = int.MinValue;//-2milyar

for(int i=0; i < 5; i++)//5 defa çalışacak
{
    Console.WriteLine($"{i + 1}. Sayıyı girin:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if(sayi > eb) 
        eb = sayi;

    if(sayi < ek)
        ek = sayi;
}

Console.WriteLine($"En Büyük: {eb}, En Küçük:{ek}");