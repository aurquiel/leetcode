// See https://aka.ms/new-console-template for more information
using ConsoleAppLeetCode;
using ConsoleAppLeetCode.Easy;

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

Console.WriteLine("=====================");
Console.WriteLine("RomanNumber");
Console.WriteLine(RomanToIntChallenge.RomanToInt("XX"));
Console.WriteLine(RomanToIntChallenge.RomanToInt("XCVI"));
Console.WriteLine(RomanToIntChallenge.RomanToInt("M"));
Console.WriteLine("=====================");

Console.WriteLine("=====================");
Console.WriteLine("LongestCommonPrefix");
Console.WriteLine(LongestCommonPrefixChallenge.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
Console.WriteLine(LongestCommonPrefixChallenge.LongestCommonPrefix(new string[] { "cir", "car" }));
Console.WriteLine("=====================");

Console.WriteLine("=====================");
Console.WriteLine("ValidParentheses");
Console.WriteLine(ValidParenthesesChallenge.IsValid("]"));
Console.WriteLine(ValidParenthesesChallenge.IsValid("(("));
Console.WriteLine(ValidParenthesesChallenge.IsValid("()[]{}"));
Console.WriteLine(ValidParenthesesChallenge.IsValid("(]")); 
Console.WriteLine(ValidParenthesesChallenge.IsValid("{[()]}"));
Console.WriteLine(ValidParenthesesChallenge.IsValid("{([{]])}"));
Console.WriteLine("=====================");

Console.WriteLine("=====================");
Console.WriteLine("MergeTwoSortedList");
Console.WriteLine(MergeTwoSortedListsChallenge.MergeTwoLists(
    new ListNode(1, new ListNode(2, new ListNode(4, null))),
    new ListNode(1, new ListNode(3, new ListNode(4, null)))
    ));
Console.WriteLine(MergeTwoSortedListsChallenge.MergeTwoLists(
    null, null
    ));
Console.WriteLine(MergeTwoSortedListsChallenge.MergeTwoLists(
    null,
    new ListNode(0, null)
    ));
Console.WriteLine("=====================");