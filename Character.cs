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

  public void TakeDamage(int damage)
  {
    this.CurrentHP = damage > this.CurrentHP ? 0 : this.CurrentHP - damage;
  }
}