Console.WriteLine("Yeni Parola Girin:");
string parola = Console.ReadLine();
//+parola en az 6 karakter olmalı
//parolada harfler olmalı
//rakamlar olmalı
//özel karakterler olmalı
//Örnek; abcd1234?
int harfler = 0, rakamlar = 0, ozelKar = 0;

if(parola.Length>=6)
{
    foreach(char c in parola)
    {
        if(char.IsLetter(c))
            harfler++;
        else if(char.IsDigit(c))
            rakamlar++;
        else if(char.IsSymbol(c))
            ozelKar++;
    }

    if(rakamlar > 0 && harfler > 0 && ozelKar > 0)
    {
        Console.WriteLine("Parola Uygun...");
    }
    else
    {
        Console.WriteLine("Parolanızın içinde harf, rakam ve" +
                            "özel karakterler olmalı!");
    }
}
else 
{
    Console.WriteLine("Parolanız en az 6 karakter olmalı.");
}


