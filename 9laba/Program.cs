int[] a = Enumerable.Range(0, 11)
    .Select(i =>
    {
        Console.Write($"Введите a[{i}] = ");
        return int.Parse(Console.ReadLine());
    }).ToArray();

int sum = a.Where(x => x % 2 == 1).Sum();
foreach (int x in a)
{
    int b = x % 2;
    if (b != 0)
    {
        sum += x;

    }
}
    Console.WriteLine($"Сумма нечетных отрицательных чисел = {sum}");
