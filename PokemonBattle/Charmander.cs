using System;
using System.Collections.Generic;
using System.Text;

public class Charmander : Pokemon
{
        Random random = new Random();
        public Charmander()
        {
            Name = "Charmander";
        type = "Fire";
        move1Name = "[1] Tackle";
        move2Name = "[2] Ember";
        move3Name = "[3] Fury Attack";
        move4Name = "[4] Leer";
        maxDamageBoost = 0;
        maxLife = 23;
        life = 23;
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

        Console.WriteLine("Charmander used Tackle");
            WaitTime();
            Console.WriteLine($"{Target} lost {damage + damageBoost} HP");
            WaitTime();
        
            Target.life -= damage + damageBoost;
        }

        public override void move2()
        {
            damage = 11;
            Console.WriteLine("Charmander used Ember");
            WaitTime();
        if (Target.type == "Grass")
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
            damage = 3;

        if (damageBoost <= -3)
        {
            damageBoost = -2;
        }

        Console.WriteLine("Charmander used Fury Attack");
            WaitTime();
            int furyAttackHit = random.Next(2, 6);
            for (int i = 0; i < furyAttackHit; i++)
            {
                Console.WriteLine($"{Target} lost {damage + damageBoost} HP");
                WaitTime();
                Target.life -= damage + damageBoost;
            }
            Console.WriteLine(Target + " was hit " + furyAttackHit + " times");
            WaitTime();
        }

        public override void move4()
        {
            Console.WriteLine("Charmander used Leer");
            WaitTime();
            Console.WriteLine(Target + " defence fell by 1 stage");
            WaitTime();
            damageBoost += 2;
        }
        void WaitTime()
        {
            Thread.Sleep(1500);
        }
}



