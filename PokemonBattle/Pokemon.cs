public abstract class Pokemon
{
    public Pokemon Target;
    public string Name;
    public string EnemyName;
    public string type;
    public int typeBonus;
    public int damage;
    public int maxDamageBoost = 0;
    public int damageBoost = 0;
    public int maxLife;
    public int life;
    public int exp;
    public int expNeeded;
    public int expDropped;

    public int PlayerMoveChosen;
    public int EnemyMoveChosen;

    public List<string> moves = new List<string>();

    public abstract void move1();
    public string move1Name;
    public abstract void move2();
    public string move2Name;
    public abstract void move3();
    public string move3Name;
    public abstract void move4();
    public string move4Name;

}