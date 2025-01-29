using System.Collections;

ArrayList arrayList = ["İzmir", 35, 3.14, true];
arrayList.Add("Btk");
arrayList.Insert(2, -1);
foreach(var i in arrayList)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();

List<int> liste = [5, 6, 2, 9, 7, 7];
liste.RemoveAt(liste.Count - 1);
liste.Add(3);
liste.AddRange([1, 8, 4]);
liste.Insert(0, 11);
foreach(var i in liste)
{
    Console.Write($"{i}, ");
}
