// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int InputNumber(string number)
{
  Console.Write(number);
  int result = int.Parse(Console.ReadLine());
  return result;
}

int SumOfElements(int n, int m)
{
  if (n == m) return n;
  else return SumOfElements(n + 1, m) + n;
}

int n = InputNumber("Enter N: ");
int m = InputNumber("Enter M: ");

Console.WriteLine(SumOfElements(n, m));