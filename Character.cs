public class Character
{
  public string Name { get; set; }
  public int MaxHP { get; set; }
  public int CurrentHP { get; set; }
  public int Attack { get; set; }
  public int Defence { get; set; }

  public Character(string name, int maxHP = 100, int attack = 15, int defence = 5)
  {
    Name = name;
    MaxHP = maxHP;
    CurrentHP = maxHP;
    Attack = attack;
    Defence = defence;
  }

  public bool IsAlive => CurrentHP > 0;

  public int TakeDamage(int attackerAttack)
  {
    int baseDamage = attackerAttack - this.Defence;

    Random rnd = new();
    double multiplier = rnd.NextDouble() * (1.2 - 0.8) + 0.8;
    double damageMultipliedDouble = Math.Round(baseDamage * multiplier, 2);
    int damageDealt = (int)Math.Round(damageMultipliedDouble);

    this.CurrentHP = damageDealt > this.CurrentHP ? 0 : this.CurrentHP - damageDealt;

    return damageDealt;
  }
}