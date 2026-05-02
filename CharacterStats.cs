public class CharacterStats
{
  public int MaxHP { get; set; }
  public int CurrentHP { get; set; }
  public int Attack { get; set; }
  public int Defence { get; set; }

  public CharacterStats(int maxHP, int attack, int defence)
  {
    MaxHP = maxHP;
    CurrentHP = maxHP;
    Attack = attack;
    Defence = defence;
  }
}