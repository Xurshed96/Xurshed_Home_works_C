// Программа которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Enter 1 number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2 number: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 3 number: ");
int c=Convert.ToInt32(Console.ReadLine());
if ((a>b) && (a>c)) 
{
    Console.WriteLine(a);
}
    else 
if (b>c)
    Console.WriteLine(b);
    else
    {
      Console.WriteLine(c);
    }