Console.WriteLine("Challenge 4_1 - determine if positive integer contains digit 3");


//
// 1.If number contains 3
// 
// Write a method that checks if given number (positive integer) contains
// digit 3. Do not convert number to other type. Do not use built-in
// functions like Contains(), StartsWith(), etc.
// 
// Expected input and output
// 
// IfNumberContains3(7201432) → true IfNumberContains3(87501) → false
//
while (true)
{





    // calculate random input
    Random random = new Random();
    int upperPowerOfTen = random.Next(1, 10);
    int highLimit = (int)Math.Pow(10, upperPowerOfTen);
    int randomPosNumber = random.Next(0, highLimit);

    // run the function (to see implementation of function scroll down)
    Console.WriteLine($"IfNumberContains3({randomPosNumber}) --> {IfNumberContains3(randomPosNumber)}");







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






bool IfNumberContains3(int number)  // had a more complex version of this, but used some 
    // details from the volunteer in class to improve upon it...
{
    //Console.Write($"TESTING '{number}'     ");
    while (number > 0)
    {
        //Console.Write($"remainder = {number % 10}   ");
        //Console.Write($"quotient = {number / 10}    \n");

        if (number % 10 == 3)
            return true;

        number = number / 10;  // could use " /= 10; " here
    }
    return false;
}