Console.WriteLine("Welcome to DICE of FORTUNE");
Console.WriteLine("Push any key to roll the dice");

Console.ReadKey();

LoopStart:

//Generate a random role of the dice

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

//Display to the user their roll

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//Rule -  Doubles or Triples! 2 Bounus points for doubles and 3 Bonus points for triples

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if((roll1 == roll2) && (roll2 == roll3))
    {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;   
    }
    else
    { 
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
    }
}

//If statment to determine if the player wins a prize or not

if (total >= 16)
{
    Console.WriteLine("You win our Major Prize - Big Stuffed Bear!");
}
else if (total >= 10)
{
    Console.WriteLine("You win our Minor Prize - Little Stuffed Turtle!");
}
else if (total == 7)
{
    Console.WriteLine("You are still a winner! Your prize is a Monkey Keychain!");
}
else
{
    Console.WriteLine("You are not a winner!");
}


Console.WriteLine("Press 'X' to roll again, or any other key to exit.");
        
        // Read the user's input
        string input = Console.ReadKey(true).KeyChar.ToString().ToUpper();
        Console.WriteLine();

        // If 'X' is pushed, jump back to the 'LoopStart' label
        if (input == "X")
        {
            goto LoopStart;
        }