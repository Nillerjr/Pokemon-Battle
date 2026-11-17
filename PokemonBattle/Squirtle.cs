using System;
using System.Collections.Generic;
using System.Text;


public class Squirtle : Pokemon
{
    public Squirtle()
    {
        Name = "Squirtle";
        type = "Water";
        move1Name = "[1] Tackle";
        move2Name = "[2] Bubble";
        move3Name = "[3] Growl";
        move4Name = "[4] Tail Whip";
        maxDamageBoost = 0;
        maxLife = 24;
        life = 24;
        exp = 0;
        expNeeded = 100;
        expDropped = 150;
    }

    public override void move1()
    {
        damage = 7;

        if (damageBoost <= -7)
        {
            damageBoost = -6;
        }

        Console.WriteLine("Squirtle used Tackle");
        WaitTime();
        Console.WriteLine($"{Target} lost  {damage + damageBoost}  HP");
        WaitTime();
        Target.life -= damage + damageBoost;
    }

    public override void move2()
    {
        damage = 10;
        Console.WriteLine("Squirtle used Bubble");
        WaitTime();
        if(Target.type == "Fire")
        {
            typeBonus = 4;
            Console.WriteLine("It's super effective");
            WaitTime();
            Console.WriteLine($"{Target} lost  {damage + typeBonus}  HP");
            WaitTime();
            Target.life -= damage + typeBonus;
        }
        else
        {
            Console.WriteLine($"{Target} lost  {damage}  HP");
            WaitTime();
            Target.life -= damage;
        }
        
    }

    public override void move3()
    {
        damage = 7;
        Console.WriteLine("Squirtle used Growl");
        WaitTime();
        Console.WriteLine($"{Target} damage fell by 1 stage");
        WaitTime();
        Target.damageBoost -= 2;
    }

    public override void move4()
    {
        damage = 7;
        Console.WriteLine("Squirtle used Tail Whip");
        WaitTime();
        Console.WriteLine($"{Target} defence fell by 1 stage");
        WaitTime();
        damageBoost += 2;
    }

    void WaitTime()
    {
        Thread.Sleep(1500);
    }
}

