IsPalindrome();

static void IsPalindrome()
{
    Console.WriteLine("Enter something to see if it is a palindrome (input all capital or small letters)");
    string UserInput = Console.ReadLine();
    int len = UserInput.Length; // Needed for itareting through the string elements
    bool test = true; // if it is not palindrome, this will be overwritten as "false"

    for (int i = 0; i < len / 2; i++)
    { // Checks if letters from the begining are not same as letter starting from the end and both indices move towards the center. If not same test = false and iteration stops
        if (UserInput[i] != UserInput[len - (i + 1)]) 
        {
            test = false;
            break;
        }
    }
    if (test)
    {
        Console.WriteLine($"{UserInput} is palindrome");
    }
    else
    {
        Console.WriteLine($"{UserInput} is not palindrome");
    }

}
