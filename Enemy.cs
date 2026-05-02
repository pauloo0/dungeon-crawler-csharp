public class Enemy : Character
{
  public enum EnemyType
  {
    Goblin,
    Skeleton,
    Orc,
    Boss
  }


  private static readonly Dictionary<EnemyType, CharacterStats> StatsTable = new()
  {
    {EnemyType.Goblin, new CharacterStats(30,8,2 )},
    {EnemyType.Skeleton, new CharacterStats(45,12,4 )},
    {EnemyType.Orc, new CharacterStats(70,18,8 )},
    {EnemyType.Boss, new CharacterStats(150,25,15 )}
  };

  public EnemyType Type { get; private set; }

  public Enemy(string name, EnemyType type) : base(name, GetStatsForType(type))
  {
    Type = type;
  }


  private static CharacterStats GetStatsForType(EnemyType type)
  {
    return StatsTable.GetValueOrDefault(type, new CharacterStats(40, 10, 5));
  }
}