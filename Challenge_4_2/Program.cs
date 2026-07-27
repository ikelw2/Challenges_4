Console.WriteLine("Challenge 4_2 - Divisible by 2 and 3 return product, otherwise return sum of two numbers");
// 
// 2.Divisible by 2 or 3
// 
// Given two integers, write a method that returns their multiplication
// if they are both divisible by 2 or 3, otherwise returns their sum.
// 
// Expected input and output
// 
// DivisibleBy2Or3(15, 30) → 450
// DivisibleBy2Or3(2, 90) → 180
// DivisibleBy2Or3(7, 12) → 19
// 
while (true)
{





    // calculate random input
    Random random = new Random();
    int upperPowerOfTen = random.Next(1, 10);
    int highLimit = (int)Math.Pow(10, upperPowerOfTen);
    int randomPosNumber1 = random.Next(0, highLimit);
    int randomPosNumber2 = random.Next(0, highLimit);

    Console.WriteLine($"DivisibleBy2Or3({15}, {30}) --> {DivisibleBy2Or3(15, 30)}");
    Console.WriteLine($"DivisibleBy2Or3({2}, {90}) --> {DivisibleBy2Or3(2, 90)}");
    Console.WriteLine($"DivisibleBy2Or3({7}, {12}) --> {DivisibleBy2Or3(7, 12)}");
    // run the function (to see implementation of function scroll down)
    Console.WriteLine($"Random Test Numbers:\nDivisibleBy2Or3({randomPosNumber1}, {randomPosNumber2}) --> {DivisibleBy2Or3(randomPosNumber1, randomPosNumber2)}");





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





int DivisibleBy2Or3(int number1, int number2)  
{
    // if divisible by 2 and 3
    if ((number1 % 2 == 0) || (number1 % 3 == 0))
    {
        if ((number2 % 2 == 0) || (number2 % 3 == 0))
        {
            return number1 * number2;
        }
    }
    return number1 + number2;
}