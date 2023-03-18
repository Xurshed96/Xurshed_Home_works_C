// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Enter number: ");
string s =Console.ReadLine();
if (s[0] == s[4] || s[1] == s[3]) {
    Console.WriteLine($"{s} palindrome ");
}
else 
    Console.WriteLine($"{s} no palindrome ");{   
    }
