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
    {EnemyType.Goblin, new CharacterStats(30, 8, 1 )},
    {EnemyType.Skeleton, new CharacterStats(45, 10, 7 )},
    {EnemyType.Orc, new CharacterStats(60, 14, 4 )},
    {EnemyType.Boss, new CharacterStats(120, 18, 8 )}
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