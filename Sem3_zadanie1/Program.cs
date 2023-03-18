Console.Clear();
Console.Write("Enter number: ");
string s =Console.ReadLine();
if (s[0] == s[4] || s[1] == s[3]) {
    Console.WriteLine($"{s} palindrome ");
}
else 
    Console.WriteLine($"{s} no palindrome ");{   
    }