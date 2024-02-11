
int randomNumber = new Random().Next(1, 11);

bool newGame = true;

while(true)
{
    if (newGame) {
        Console.WriteLine("Please enter your number. [1-11]");
        newGame = false;
    }

    uint userNumber = Convert.ToUInt32(Console.ReadLine());

    if (userNumber < randomNumber)
    {
        Console.WriteLine("Your number is less!");
    }
    else if (userNumber > randomNumber)
    {
        Console.WriteLine("Your number is greater!");
    }
    else 
    {
        Console.WriteLine("Currect!");

        Console.WriteLine("Do you want to play again? (y - yes | n - no)");

        if (Convert.ToChar(Console.ReadLine()) != 'y') break;

        randomNumber = new Random().Next(1, 11);
        newGame = true;
    }
}