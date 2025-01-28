Console.WriteLine("Dönem sonu ortalamasını girin:");
int ort = Convert.ToInt32(Console.ReadLine());

string durum = ort switch 
{
    >= 85 => "TAKDİR", // => ise gibi düşün
    >= 70 => "TEŞEKKÜR",
    >= 50 => "SINIFI GEÇTİ",
    _ => "SINIFTA KALDI"
};

//durum = ort >= 85 ? "TAKDİR": ort>=70 ? "TEŞEKKÜR" : ort >=50 ? "SINIFI GEÇTİ":"SINIFTA KALDI";

Console.WriteLine(durum);