Console.WriteLine("===== C# DUNGEON CRAWLER GAME ====");
Console.WriteLine("Before we start, what's your name?");
string? heroName = Console.ReadLine();
if (heroName == "" || heroName is null) heroName = "Hero";

Console.WriteLine("What a cool name! Nice to meet you {0}!", heroName);

Console.WriteLine("Ready to enter the dungeon? Y/n");
string? startGame = Console.ReadLine();
if (startGame == "" || startGame is null) startGame = "y";
if (startGame == "n") return;

Console.Clear();
string? move = "";
bool validMove = false;
Console.WriteLine("Oh no! An enemy has appeared from the shadows. It's a Goblin!");

while (move == "" || !validMove)
{
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