using System;

Random random = new Random(); // to generate random value
bool playAgain = true;
int min = 1; // minimum value to guess
int max = 100; // maximum value to guess
int guess; // the guessed value from the user
int number; // random number to be guessed or number we generate for user to guess
int guesses; // number of guesses by user
String response;

while (playAgain) // as long as a user wants to play again , the while loop keeps running
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
    while (guess != number) // if the number the user guessed is not the same as the randomly generated number, run a while loop
    {
        Console.WriteLine("Guess a number between " + min + " and " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your guess is : " + guess);
        if (guess > number)
        {
            Console.WriteLine(guess + " is too high");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is too low");
        }
        guesses++;
    }
    Console.WriteLine("Number is actually : " + number);
    Console.WriteLine("You are CORRECT!");
    Console.WriteLine("You guessed " + guesses + " times");
    Console.WriteLine("Would you like to play again? (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();
    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}
Console.WriteLine("Thanks for playing");
Console.ReadKey();