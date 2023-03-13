// Программа котое но вход принимает число N а на выходе показывает все чётные число от 1 до N.

Console.Clear();
Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine ()!);
for(int i=1; i<n; i++) {
  if(i%2==0)
 Console.Write($"{i} ");
}