public class Enemy
{
  public string Name { get => name; set => name = value; }

  private int _hp = 100;

  public int Hp
  {
    get
    {
      Console.WriteLine("GET!");
      return Random.Shared.Next(100);
    }
    set
    {
      _hp = value;
      if (_hp < 0) _hp = 0;
      if (_hp > 100) _hp = 100;
    }
  }

  private int _xp;
  private string name;

  public int Level
  {
    get
    {
      return _xp / 10 + 1;
    }
    private set
    {

    }
  }


  public int GetHp()
  {
    return _hp;
  }

  public void SetHp(int value)
  {
    _hp = value;
    if (_hp < 0) _hp = 0;
  }

  public void Hurt(int amount)
  {
    SetHp(GetHp() - amount);
  }
}
