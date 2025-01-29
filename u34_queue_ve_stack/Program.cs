Queue<int> kuyruk = new ();

kuyruk.Enqueue(4);//ekle
kuyruk.Enqueue(3);
kuyruk.Enqueue(6);
kuyruk.Enqueue(9);

Console.WriteLine($"Kuyruk Elemanları ({kuyruk.Count})");
while(kuyruk.Count > 0)
{
    int eleman = kuyruk.Dequeue();//kuyruktan çıkar
    Console.Write($"{eleman}, ");
}

Stack<int> yigin = new ();
yigin.Push(4);//ekle
yigin.Push(3);
yigin.Push(6);
yigin.Push(9);

Console.WriteLine($"\nYığın Elemanları ({yigin.Count})");
while(yigin.Count > 0)
{
    int eleman = yigin.Pop();//yığından çıkar
    Console.Write($"{eleman}, ");
}