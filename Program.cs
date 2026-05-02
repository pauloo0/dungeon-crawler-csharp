Console.WriteLine("===== C# DUNGEON CRAWLER GAME ====");
Console.WriteLine("Before we start, what's your name?");
string? heroName = Console.ReadLine();
if (heroName == "" || heroName is null) heroName = "Hero";

Console.WriteLine("What a cool name! Nice to meet you {0}!", heroName);

Console.WriteLine("Ready to enter the dungeon? Y/n");
string? startGame = Console.ReadLine() ?? "y";
if (startGame == "n") return;

Character player = new(heroName);
Character enemy = new("Gurk", 100, 10, 2);
Console.Clear();

Console.WriteLine("Oh no! An enemy has appeared from the shadows. It's a Goblin named {0}!", enemy.Name);
while (player.IsAlive && enemy.IsAlive)
{
  string? move = "";
  bool validMove = false;
  while (move == "" || !validMove)
  {
    Console.WriteLine("Your HP: {0}       {1}'s HP: {2}", player.CurrentHP, enemy.Name, enemy.CurrentHP);
    Console.WriteLine("What do you wish to do?");
    Console.WriteLine("1: Attack   2: Defend");
    move = Console.ReadLine();
    validMove = new[] { "1", "2" }.Contains(move);

    if (!validMove)
    {
      Console.WriteLine("Invalid move. Try again!");
    }
  }

  if (move == "1")
  {
    Console.WriteLine("You attacked and dealt {0} damage.", "some");
  }
  if (move == "2")
  {
    Console.WriteLine("You defended and mitigated {0} damage. You lost {1} HP.", "some", "some");
  }
}

if (!player.IsAlive)
{
  Console.WriteLine("You died! Better luck next time.");
}

if (!enemy.IsAlive)
{
  Console.WriteLine("You defeated {0}. Congratiolations!", enemy.Name);
}
