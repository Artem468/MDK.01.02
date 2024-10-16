using TestingLab2;

int[,] data = Convertor.FromArrayToMatrix(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4)!;

foreach (var item in data)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(data[i, j] + " ");
    }
    Console.WriteLine();
}
