int m = 4;
int n = 4;
int[,] matrix = new int[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
for (int j = 0; j < m; j++)
{
    int s = 0;
    for (int i = 0; i < n; i++)
    {
        s = s + matrix[i, j];
    }
    Console.WriteLine("Сумма столбца " + (j + 1) + "=" + s);
}
