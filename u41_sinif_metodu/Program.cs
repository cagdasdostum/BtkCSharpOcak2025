//ANA PROGRAM
using u41_sinif_metodu;//Konsol kullanılacak

Konsol.Temizle(ConsoleColor.Red);

int s1 = Konsol.SayiOku("Bir sayı girin:");
int s2 = Konsol.SayiOku("Başka bir sayı girin:");

Konsol.YazSatir($"Toplam = {s1 + s2}");

