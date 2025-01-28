//Klavyeden kişinin adı ve yaşı girilecek
//Kişinin adını yaşı defa ekrana yazacak
//for döngüsünü kullanın
Console.WriteLine("Adınızı girin:");
string ad = Console.ReadLine();
Console.WriteLine("Yaşınızı girin:");
int yas = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= yas; i++)
{
    Console.WriteLine($"{i} - {ad}");
}
