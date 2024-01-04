//Guessing game

int LuckyNumber = 6;
int guess = 0;
int guessCount = 0;
int guessLimit = 3;
bool outOfGame = false;

while (guess != LuckyNumber && !outOfGame)
{
    if(guessCount < guessLimit)
    {
        Console.Write("Enter a number between 1 and 10: ");
        guess = Convert.ToInt32(Console.ReadLine());
        guessCount++;
    }
    else
    {
        outOfGame = true;
    }
}

if (outOfGame)
{
    Console.WriteLine("You lost the game");
}
else
{
    Console.WriteLine("You won the game!");
}