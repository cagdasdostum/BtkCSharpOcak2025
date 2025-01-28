//kullanıcının girdiği yükseklik değerine göre
//ekrana üçgeni * karakteri ile çizsin
//     *                    genişlik=4
//     **                   yükseklik=4
//     ***
//     ****

int yuk = 4;

for(int i = 0; i < yuk; i++)//bir defa başladımı tekrar başlamaz
{
    for(int j = 0; j < i + 1; j++)//her seferinde baştan başlar ve tamamlanır
    {
        Console.Write("*");
    }

    Console.WriteLine();//alt satıra geçer
}