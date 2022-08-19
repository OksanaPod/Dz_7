Console.WriteLine("Задайте двухмерный массив m x n");
Console.Write("Введите m =");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n =");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.NextDouble() * 10;
        Console.Write("{0,6:F2}", matrix[i, j]);
    }
    Console.WriteLine();
}