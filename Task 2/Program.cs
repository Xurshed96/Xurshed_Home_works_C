//Программа которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Enter 1 number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2 number: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a>b)
    Console.WriteLine(a);
else if (a<b)
    Console.WriteLine(b);    