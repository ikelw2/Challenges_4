Console.WriteLine("Challenge 4_3 - function to reverse an array of chars");
// 
// 3. Write a function that reverses a string. The input string is given as an array of characters s.
// You must do this by modifying the input array in-place. (Problem 344 in leetcode)
// 
// Example 1:
// Input: s = ["h","e","l","l","o"]
// Output: ["o","l","l","e","h"]
// 
// Example 2:
// Input: s = ["H","a","n","n","a","h"]
// Output: ["h","a","n","n","a","H"]
// 
while (true)
{






    // accept user input to test character array reversal function
    Console.Write("Step 1. Enter a string: ");
    string inputString = Console.ReadLine();
    char[] s = inputString.ToCharArray();
    Console.WriteLine($"Input:  s = [{string.Join(", ",s)}]");

    // run character array reversal function and print output
    char[] r = ReverseCharArray(s); // <<<-------------------------- SCROLL DOWN FOR FUNCTION
    Console.WriteLine($"Output: r = [{string.Join(", ", r)}]");






    // ask if user wants to quit or continue again...
    Console.Write("\nEnter Q to quit or press ENTER to continue.");
    bool userWantsToQuit = (Console.ReadLine().Trim().Equals("q", StringComparison.OrdinalIgnoreCase) == true); // if user enters 'q' or 'Q'
    if (userWantsToQuit == true)
    {
        break; // exit from main program loop
    }
    Console.WriteLine("-----------------------------------------------------");
}
Console.WriteLine();




char[] ReverseCharArray(char[] s)
{
    // from 0 to halfway point...
    // and we can just use /2 to determine halfway point because it's an int
    char[] n = s;

    for (int i = 0; i < n.Length/2; i++)
    {
        char temp = n[(n.Length - 1) - i]; // reverse one by one...
        n[(n.Length - 1) - i] = n[i]; // need to use temp variable
        n[i] = temp;
    }

    return n;
}