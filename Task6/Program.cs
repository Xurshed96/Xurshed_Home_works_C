// Программа которая на вход принимает число и выдаёт является ли число четным ( делится ли оно на два без остатка)
Console.Clear();
Console.WriteLine("Enter number");
int a = Convert.ToInt32(Console.ReadLine()!);
if (a%2 == 0)
{
  Console.WriteLine("chetnoe");
}
else
{
  Console.WriteLine("nechetnoe");
}
