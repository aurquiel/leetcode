// See https://aka.ms/new-console-template for more information
using ConsoleAppLeetCode;

Console.WriteLine("=====================");
Console.WriteLine("TwoSum");
var array = new int[] { 2, 4, 7, 8 };
int target = 9;
Console.WriteLine($"Array {array[0]}, {array[1]}, {array[2]}, {array[3]}, Target:{target}");
var result = TwoSumChallenge.TwoSum(array, target);
Console.WriteLine($"{result[0]}, {result[1]}");
Console.WriteLine("=====================");

Console.WriteLine("=====================");
Console.WriteLine("PalindromeNumber");
Console.WriteLine(PalindromeNumberChallenge.IsPalindrome(512225));
Console.WriteLine(PalindromeNumberChallenge.IsPalindrome(5225));
Console.WriteLine(PalindromeNumberChallenge.IsPalindrome(-121));
Console.WriteLine("=====================");