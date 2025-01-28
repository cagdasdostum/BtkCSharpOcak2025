//Klavyeden kilo ve boy bilgisi alınacak
//vücut kitle indeksi hesapalnacak
//vki = kg / m2  ---> kilo / boy karesi
//<18.5 ---> Zayıf
//>18.5-25.0 ----> Normal
//>25.0-30 -----> Kilolu
//>30 -----> Aşırı Kilolu

Console.WriteLine("Kilonuzu girin(kg):");
double kilo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Boyunuzu girin(cm):");
double boy = Convert.ToDouble(Console.ReadLine());

//boy/=100; //bileşik atama operatörü boy = boy / 100

double boyMetre = boy / 100; //cm ---> metre dönüştür
double vki = kilo / (boyMetre * boyMetre);

Console.WriteLine($"Vücut Kitle İndeksi = {vki:f2}");

if(vki < 18.5)
{
     Console.WriteLine("Zayıf");
}
else if(vki < 25)
{
    Console.WriteLine("Normal");
}
else if(vki < 30)
{
    Console.WriteLine("Kilolu");
}
else//30 ve üzeri ise
{
    Console.WriteLine("Aşırı Kilolu");
}