int[] a = Enumerable.Range(0, 11)
    .Select(i =>
    {
        Console.Write($"Введите a[{i}] = ");
        return int.Parse(Console.ReadLine());
    }).ToArray();
int sum = a.Where(x => x % 2 == 1).Sum();
Console.WriteLine($"Сумма нечетных чисел = {sum}");