Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

Console.Write("Lütfen adınızı girin:");
string ad = Console.ReadLine();//klavyeden oku


Console.Write("Merhaba, ");
Console.WriteLine(ad);

Console.ResetColor();
