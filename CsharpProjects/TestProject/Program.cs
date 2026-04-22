using System.IO.Pipelines;

string[] orderStream = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
Array.Sort(orderStream);
foreach (var orders in orderStream)
{
    if(orders.Length == 4)
    {
        Console.WriteLine($"{orders}");
    }
    else
    {
        Console.WriteLine($"{orders} - Error");
    }
}

/*char[] orderArray = orderStream.ToCharArray();
string result = 
string[] items = result.Split(' ');


Console.WriteLine(orderArray);

/*string result = String.Join("",pangramArray);
Console.WriteLine(result);
string[] items = result.Split(' ');
foreach (string item in items)
{
    Console.WriteLine(item);
}

Console.WriteLine(result);*/