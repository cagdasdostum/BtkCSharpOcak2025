Console.Write("Dörtgenin a kenarını gir:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Dörtgenin b kenarını gir:");
int b = Convert.ToInt32(Console.ReadLine());

var alan = a * b;//sağdaki işlemin tipine göre değişken tipi belirler
var cevre = (a + b) * 2;//parantezler işlem önceliği belirler

// Örnek;
//Kenarları 5 ve 3 olan bir dörtgenin alanı 15 'tir.
//Kenarları 5 ve 3 olan bir dörtgenin çevresi 16 'tir.
Console.WriteLine($"Kenarları \"{a}\" ve \"{b}\" \nolan bir dörtgenin alanı {alan} eder.");
Console.WriteLine($"""Kenarları "{a}" ve "{b}" olan bir dörtgenin çevresi {cevre} eder.""");
