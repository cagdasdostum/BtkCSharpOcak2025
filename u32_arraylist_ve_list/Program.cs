
using System.Collections;

ArrayList arrayList = ["İzmir", 35, 3.14, true];
arrayList.Add("Btk");
arrayList.Insert(2, -1);
foreach(var i in arrayList)
{
    Console.Write($"{i}, ");
}