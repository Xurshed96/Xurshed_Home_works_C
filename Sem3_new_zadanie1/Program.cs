// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter a five-digit number");
string x = Console.ReadLine()!;
char[] arr = x.ToCharArray();
Array.Reverse(arr);
string x2 = new String(arr);
if (x == x2) Console.WriteLine("palindrome");
else Console.WriteLine("no palindrome");
