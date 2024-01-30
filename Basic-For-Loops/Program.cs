/* Basic For Loops Lab
 * Mattalynn Darden
 * GC C# Janurary 2024
 * 1/29/2024 */


static void BasicForLoop()
{
    string continueGame = "default";
    do
    {
        //Prompt the user to enter a number
        Console.Write("Enter a number: ");
        
        int userInput = int.Parse(Console.ReadLine());

        int sum = 0;

        //Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.
        for (int i = 1; i <= userInput; i++)
        {
            sum += i;
        }

        //Print user input to the screen and sum of numbers from 1 - {userInput}
        Console.WriteLine($"The sum of numbers from 1 to {userInput} is:  {sum}");

        //Ask the user if they still want to play
        Console.WriteLine("Would you like to continue (y/n) ?");
        continueGame = Console.ReadLine();
    }
    while (continueGame.ToLower().Trim() == "y");

    Console.WriteLine("Goodbye!");
}

BasicForLoop();