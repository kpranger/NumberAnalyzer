//Start of loop to continue running program based on user input at end
while (true)
{

    //Get name
    Console.WriteLine("What is your name?");
    string name = (Console.ReadLine());

//Get integer
    Console.WriteLine(name + ", please enter an integer between 1 and 100");
    double integer = double.Parse(Console.ReadLine());

//Integer is between 1-100 statement
        if (integer > 1 && integer < 100)
        {
            Console.WriteLine("Thank you for choosing an integer between 1 and 100 " + name + "!");
        }
        else
        {
            Console.WriteLine("You did not follow the rules, we are done here!");
            break;
        }
//Integer is odd and less than 60
        if (integer % 2 > 0 && integer < 60)
        {
            Console.WriteLine("Your number, " + integer + ", is odd and less than 60.");
        }
//Integer is even and less than 25
        else if (integer % 2 == 0 && integer >= 2 && integer <= 24)
        {
            Console.WriteLine("Your number is even and less than 25.");
        }
//Integer is even and between 26 and 60 inclusive
        else if (integer % 2 == 0 && integer >= 26 && integer <= 60)
        {
            Console.WriteLine("Your number is even and between 26 and 60 inclusive.");
        }
//Integer is even and greater than 60
        else if (integer % 2 == 0 && integer > 60)
        {
            Console.WriteLine("Your number, " + integer + ", is even and greater than 60.");
        }
//Integer is odd and greater than 60
        else if (integer % 2 > 0 && integer > 60)
        {
            Console.WriteLine("Your number, " + integer + ", is odd and greater than 60.");
        }
    //Keep going?
    Console.WriteLine(name + ", would you like to try again? yes/no");
    string loopChoice = Console.ReadLine();
    if (loopChoice != "yes")
    {
        break;
    }
}