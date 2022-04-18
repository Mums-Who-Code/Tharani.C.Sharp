//Add decision logic to your code using the if-elseif -else statement
//5 players are playing a dice game.
//Each one rolls a dice, the players who get the same number move to the next level.
//Print the message displaying the players who moved to next level and players did not move to next level.


Random dice = new Random();
int player1 = dice.Next(1, 7);
int player2 = dice.Next(1, 7);
int player3 = dice.Next(1, 7);
int player4 = dice.Next(1, 7);
int player5 = dice.Next(1, 7);

Console.WriteLine($"Player1 Dice Roll Number : {player1}\nPlayer2 Dice Roll Number:{player2} " +
    $"\nPlayer3 Dice Roll Number : {player3} \nPlayer4 Dice Roll Number: {player4} \nPlayer5 Dice Roll Number: {player5}");

if (((player1 == player2) || (player1 == player3) || (player1 == player4) || (player1 == player5)) &&
        ((player2 == player3) || (player2 == player4) || (player2 == player5)) &&
        ((player3 == player4) || (player3 == player5)) &&
        (player4 == player5))
{
    Console.WriteLine("\nAll 5 players moved to next level.");

}

else if ((player1 == player2) || (player2 == player3) || (player3 == player4) ||
    (player4 == player5) || (player5 == player1) || (player2 == player5) || (player2 == player4)
    || (player3 == player5) || (player1 == player3) || (player4 == player1))
{
    if ((player1 == player2) || (player1 == player3) || (player1 == player4) || (player1 == player5))
    {
        Console.WriteLine("\nPlayer1 moved to next level.");
    }
    else
    {
        Console.WriteLine("\nPlayer1 did not move to next level.");
    }

    if ((player2 == player1) || (player2 == player3) || (player2 == player4) || (player2 == player5))
    {
        Console.WriteLine("\nPlayer2 moved to next level.");
    }
    else
    {
        Console.WriteLine("\nPlayer2 did not move to next level.");
    }

    if ((player3 == player1) || (player3 == player2) || (player3 == player4) || (player3 == player5))
    {
        Console.WriteLine("\nPlayer3 moved to next level.");
    }
    else
    {
        Console.WriteLine("\nPlayer3 did not move to next level.");
    }

    if ((player4 == player1) || (player4 == player2) || (player4 == player3) || (player4 == player5))
    {
        Console.WriteLine("\nPlayer4 moved to next level.");
    }
    else
    {
        Console.WriteLine("\nPlayer4 did not move to next level.");
    }

    if ((player5 == player1) || (player5 == player2) || (player5 == player3) || (player5 == player4))
    {
        Console.WriteLine("\nPlayer5 moved to next level.");
    }
    else
    {
        Console.WriteLine("\nPlayer5 did not move to next level.");
    }
}

else
{
    Console.WriteLine("\nNo one moved to next level.");
}

Console.ReadLine();