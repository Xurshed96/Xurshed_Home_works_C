// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такой позиции нет.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции нет


Console.Clear();
Console.Write("Enter the dimension m of the array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter dimension n of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
Console.Write("Enter line position: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column position: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void InputArray(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.NextDouble();
Console.Write($"{randomArray[i,j]:F2} ");
}
Console.WriteLine();
}
}
InputArray(m,n);
if (m2<1 || n2<1)
Console.Write("Row positions cannot be negative.");
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($"The value of the element is {randomArray[m2-1,n2-1]:F2} ");
else Console.Write("There is no such element in the array");

