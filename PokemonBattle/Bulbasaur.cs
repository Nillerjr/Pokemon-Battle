using System;
using System.Collections.Generic;
using System.Text;

public class Bulbasaur : Pokemon
{      

    public Bulbasaur()
        {
            Name = "Bulbasaur";
        type = "Grass";
        move1Name = "[1] Tackle";
        move2Name = "[2] Razor Leaf";
        move3Name = "[3] Growl";
        move4Name = "[4] Absorb";
        maxDamageBoost = 0;
        maxLife = 25;
        life = 25;
        exp = 0;
        expNeeded = 100;
        expDropped = 150;
    }

        public override void move1()
        {
            damage = 10;

        if (damageBoost <= -10)
        {
            damageBoost = -9;
        }

        Console.WriteLine("Bulbasaur used Tackle");
            WaitTime();
            Console.WriteLine($"{Target} lost  {damage + damageBoost}  HP");
            WaitTime();
            Target.life -= damage + damageBoost;
        }

        public override void move2()
        {
            damage = 9;

        if (damageBoost <= -9)
        {
            damageBoost = -8;
        }

        Console.WriteLine("Bulbasaur used Razor Leaf");
            WaitTime();
        if (Target.type == "Water")
        {
            typeBonus = 4;
            Console.WriteLine("It's super effective");
            WaitTime();
            Console.WriteLine($"{Target} lost  {damage + typeBonus + damageBoost}  HP");
            WaitTime();
            Target.life -= damage + typeBonus + damageBoost;
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
            Console.WriteLine("Bulbasaur used Growl");
            WaitTime();
            Console.WriteLine(Target + " attack was lowered by 1");
            WaitTime();
            Target.damageBoost -= 2;
        }

        public override void move4()
        {
        damage = 6;
        Console.WriteLine("Bulbasaur used Absorb");
        WaitTime();

        if (Target.type == "Water")
        {
            typeBonus = 4;
            Console.WriteLine("It's super effective");
            WaitTime();
            Console.WriteLine($"{Target} lost  {damage + typeBonus}  HP");
            WaitTime();
            Console.WriteLine($"Bulbasaur gained {(damage + typeBonus)  / 3} HP");
            WaitTime();
            Target.life -= damage + typeBonus;
            life += (damage + typeBonus) / 3;
            if (life >= 26)
            {
                life = 25;
            }
        }
        else
        {
            Console.WriteLine($"{Target} lost  {damage}  HP");
            WaitTime();
            Console.WriteLine($"Bulbasaur gained {(damage) / 3} HP");
            WaitTime();
            Target.life -= damage;
            life += damage / 3;
            if (life >= 26)
            {
                life = 25;
            }
        }
        }

        void WaitTime()
        {
            Thread.Sleep(1500);
        }
}

