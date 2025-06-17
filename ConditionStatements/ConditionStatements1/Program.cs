Random dice = new Random();

int diceRoll1 = dice.Next(1, 7);
int diceRoll2 = dice.Next(1, 7);
int diceRoll3 = dice.Next(1, 7);

int totalRolls = diceRoll1 + diceRoll2 + diceRoll3;

System.Console.WriteLine($"Dice rolls: {diceRoll1} + {diceRoll2} + {diceRoll3} = {totalRolls}");

if ((diceRoll1 == diceRoll2) || (diceRoll2 == diceRoll3) || (diceRoll1 == diceRoll3))
{
    System.Console.WriteLine("You roled doubles. + 2 bonus to total!");
}

if (totalRolls > 14)
{
    System.Console.WriteLine("You win!");
}
if (totalRolls < 15)
{
    System.Console.WriteLine("You loose!");
}




