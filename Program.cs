Console.WriteLine("===== C# DUNGEON CRAWLER GAME ====");
Console.WriteLine("Before we start, what's your name?");
string? heroName = Console.ReadLine() ?? "Hero";

Console.WriteLine("What a cool name! Nice to meet you {0}!", heroName);

Console.WriteLine("Ready to enter the dungeon? Y/n");
string? startGame = Console.ReadLine() ?? "y";
if (startGame == "n") return;

Character player = new(heroName, new CharacterStats(100, 15, 5));
Enemy enemy = new("Gurk", Enemy.EnemyType.Skeleton);

Console.Clear();

Console.WriteLine("Oh no! An enemy has appeared from the shadows. It's a {0} named {1}!", enemy.Type, enemy.Name);
while (player.IsAlive && enemy.IsAlive)
{
  string? move = "";
  bool validMove = false;
  while (move == "" || !validMove)
  {
    Console.WriteLine("Your HP: {0}       {1}'s HP: {2}", player.Stats.CurrentHP, enemy.Name, enemy.Stats.CurrentHP);
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
    int playerDamage = enemy.TakeDamage(player.Stats.Attack);
    Console.WriteLine("You attacked and dealt {0} damage.", playerDamage);

    int enemyDamage = player.TakeDamage(enemy.Stats.Attack);
    Console.WriteLine("{0} attacked and dealt {1} damage.", enemy.Name, enemyDamage);
  }
  if (move == "2")
  {
    int mitigatedDamage = 2;
    int enemyDamage = player.TakeDamage(enemy.Stats.Attack - mitigatedDamage);
    Console.WriteLine("You defended and mitigated {0} damage. You lost {1} HP.", mitigatedDamage, enemyDamage);
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
