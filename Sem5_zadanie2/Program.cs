﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Enter the number of array elements: ");

int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void InputArray(int a)
{
  Console.Write("[");
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(randomArray[i] + " ");
}
  Console.Write("]");
}

int quantity(int[] randomArray)
{
int sum = 0;
int i = 1;
while (i < randomArray.Length)
{
sum = sum + randomArray[i];
i = i + 2;
}
return sum;
}

InputArray(a);
Console.Write($"\n The sum of elements in odd positions: {quantity(randomArray)}");
