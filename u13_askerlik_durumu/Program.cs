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
    
    if(yas<20 && cinsiyet!='E' && cinsiyet!='e')
    {
        Console.WriteLine("YAŞINIZ ve CİNSİYETİNİZ UYGUN DEĞİL...");
    }
    else if(yas<20)
    { 
        Console.WriteLine("YAŞINIZ UYGUN DEĞİL...");
    }
    else
    {
        Console.WriteLine("CİNSİYETİNİZ UYGUN DEĞİL...");
    }
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

