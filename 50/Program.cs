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
Console.Write("Введите i массива =");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j массива =");
int k = Convert.ToInt32(Console.ReadLine());
if(k<m&&l<n)
{
for (int i = 0; i < m; i++)
{ 
    for (int j = 0; j < n; j++)
    {
        if (i == l && j == k)
            Console.Write("Ответ:"+matrix[i, j] + " ");
    }
}
}
else{
Console.WriteLine("такого числа в массиве нет");
}
