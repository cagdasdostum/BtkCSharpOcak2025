Console.WriteLine("Yaşınızı girin:");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Cinsiyetinizi girin [E/K]:");
char cinsiyet = Convert.ToChar(Console.ReadLine());

if((cinsiyet == 'E' || cinsiyet == 'e') && yas >= 20)
{
    Console.WriteLine("ASKERE GİDEBİLİR.........");
}
else
{
    Console.WriteLine("ASKERE GİDEMEZ.........");
}

/*
if(cinsiyet=='K' || yas < 20)
{
    Console.WriteLine("ASKERE GİDEMEZ......");
}
else
{
    Console.WriteLine("ASKERE GİDEBİLİR......");
}
*/

