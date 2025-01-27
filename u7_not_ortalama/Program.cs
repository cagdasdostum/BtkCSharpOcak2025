Console.WriteLine("1.Sınav Notu:");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("2.Sınav Notu:");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("3.Sınav Notu:");
double n3 = Convert.ToDouble(Console.ReadLine());

double ort = (n1 + n2 + n3) / 3;
string n1Str = "Not1";//metin içine sabit olarak yazılabilirdi!!

Console.WriteLine($"{n1Str,-10} | {"Not2",-10} | {"Not3",-10} | {"Ortalama",15}");
Console.WriteLine($"{n1,-10:f2} | {n2,-10:f2} | {n3,-10:f2} | {ort, 15:f2}");
