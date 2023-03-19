// See https://aka.ms/new-console-template for more information
try
{
    var array = new int[] { 7, 4, 8, 56, 13, 43 };
    var max = -10000;
    var secMax = 0;
    foreach (var item in array)
    {
        if (max < item)
        {
            max = item;
        }

    }
    foreach (var item in array)
    {
        if (secMax < item && item != max)
        {
            secMax = item;
        }
    }
    Console.WriteLine(secMax);
}
catch { 
    Console.WriteLine("Неверный тип данных");
}
