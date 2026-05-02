public class Character
{
  public string Name { get; set; }
  public CharacterStats Stats { get; set; }

  public Character(string name, CharacterStats stats)
  {
    Name = name;
    Stats = stats;
  }

  public bool IsAlive => Stats.CurrentHP > 0;

  public int TakeDamage(int attackerAttack)
  {
    int baseDamage = attackerAttack - Stats.Defence;

    Random rnd = new();
    double multiplier = rnd.NextDouble() * (1.2 - 0.8) + 0.8;
    double damageMultipliedDouble = Math.Round(baseDamage * multiplier, 2);
    int damageDealt = (int)Math.Round(damageMultipliedDouble);

    Stats.CurrentHP = damageDealt > Stats.CurrentHP ? 0 : Stats.CurrentHP - damageDealt;

    return damageDealt;
  }
}