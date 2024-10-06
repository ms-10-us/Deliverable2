

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("Welcome " + name + ". Do you want to do the Coin FLIP CHALLENGE? Yes/No");
string answer = Console.ReadLine();

if (answer == "No")
{
    Console.WriteLine("You are a coward " + name);
}
else if (answer == "Yes")
{
    int score = 0;

    for (int i = 1; i <= 5; i++)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 2);
        //Console.WriteLine(randomNumber);

        Console.WriteLine("Heads or Tails?");
        string guessString = Console.ReadLine();

        if (guessString == "Heads")
        {
            int guess = 1;

            if (guess == randomNumber)
            {
                score += 1;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
        else if (guessString == "Tails")
        {
            int guess = 0;

            if (guess == randomNumber)
            {
                score += 1;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
    }

    Console.WriteLine("Thank you " + name + ". You got a score of " + score + "!");
}

