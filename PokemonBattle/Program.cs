string playerName;
string trainerName;
string playerPokeName;
string enemyPokeName;
bool beatRival = false;
List<string> Starter = new List<string>();
Starter.Add("Charmander");
Starter.Add("Bulbasaur");
Starter.Add("Squirtle");

Pokemon PlayerStarterPokemon;
Pokemon EnemyStarterPokemon;

Bulbasaur bulbasaur = new Bulbasaur();
Charmander charmander = new Charmander();
Squirtle squirtle = new Squirtle();


Random random = new Random();

charmander.moves.Add("[1] Tackle");
charmander.moves.Add("[2] Ember");
charmander.moves.Add("[3] Fury attack");
charmander.moves.Add("[4] Leer");
bulbasaur.moves.Add("[1] Tackle");
bulbasaur.moves.Add("[2] Razor Leaf");
bulbasaur.moves.Add("[3] Growl");
bulbasaur.moves.Add("[4] Absorb");
squirtle.moves.Add("[1] Tackle");
squirtle.moves.Add("[2] Bubble");
squirtle.moves.Add("[3] Growl");
squirtle.moves.Add("[4] Tail Whip");

//Console.CursorVisible = false;

Console.WriteLine("Professor: Welcome to the amazing world of pokemon");
WaitTime();
Console.WriteLine("Professor: What is your name:");
playerName = Console.ReadLine();
if (playerName == "Nigger" || playerName == "nigger")
{
    Console.WriteLine("Det må man ikke sige Magnus. Prøv igen");
    playerName = Console.ReadLine();
}
Console.WriteLine("Professor: Ahh " + playerName + ". Thats a good name");
WaitTime();
Console.WriteLine("Professor: This is your rival, what was his name again?:");
trainerName = Console.ReadLine();
Console.WriteLine("Professor: Of course. His name is " + trainerName + ". Why dont the two of you pick your starter pokemon and have a battle");
WaitTime();
Console.WriteLine("Professor: For your starter pokemon you may chose:");
WaitTime();
Console.WriteLine("[1] Bulbasaur");
Console.WriteLine("[2] Charmander");
Console.WriteLine("[3] Squirtle");
ChoseStarter();
Console.WriteLine(trainerName + ": heh. your on");
WaitTime();
Console.WriteLine("You are challenged by trainer " + trainerName + ":");
WaitTime();
Console.WriteLine("Trainer " + trainerName + " sent out " + enemyPokeName);
WaitTime();
Console.WriteLine("Trainer " + playerName + " sent out " + playerPokeName);
WaitTime();
Battle();

void ChoseStarter()
{
    int numberChosen = Convert.ToInt32(Console.ReadLine());
    if (numberChosen == 1)
    {
        PlayerStarterPokemon = new Bulbasaur();
        EnemyStarterPokemon = new Squirtle();
        PlayerStarterPokemon.Target = EnemyStarterPokemon;
        EnemyStarterPokemon.Target = PlayerStarterPokemon;
        playerPokeName = "Bulbasaur";
        enemyPokeName = "Squirtle";

        Console.WriteLine("Professor: What would you like your Bulbasaur to be named");
        playerPokeName = Console.ReadLine();

        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move1Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move2Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move3Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move4Name);
    }
    else if (numberChosen == 2)
    {
        PlayerStarterPokemon = new Charmander();
        EnemyStarterPokemon = new Bulbasaur();
        PlayerStarterPokemon.Target = EnemyStarterPokemon;
        EnemyStarterPokemon.Target = PlayerStarterPokemon;
        playerPokeName = "Charmander";
        enemyPokeName = "Bulbasaur";

        Console.WriteLine("Professor: What would you like your Charmander to be named");
        playerPokeName = Console.ReadLine();

        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move1Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move2Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move3Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move4Name);
    }
    else if (numberChosen == 3)
    {
        PlayerStarterPokemon = new Squirtle();
        EnemyStarterPokemon = new Charmander();
        PlayerStarterPokemon.Target = EnemyStarterPokemon;
        EnemyStarterPokemon.Target = PlayerStarterPokemon;
        playerPokeName = "Squirtle";
        enemyPokeName = "Charmander";

        Console.WriteLine("Professor: What would you like your Squirtle to be named");
        playerPokeName = Console.ReadLine();

        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move1Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move2Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move3Name);
        PlayerStarterPokemon.moves.Add(PlayerStarterPokemon.move4Name);
    }
    else
    {
        Console.WriteLine("Stupid, thats not a pokemon. Try again");
        ChoseStarter();
    }

}

void Battle()
{
    if (EnemyStarterPokemon.life > 0)
    {
        Console.WriteLine(enemyPokeName + " has " + EnemyStarterPokemon.life + " HP left");
        WaitTime();
        Console.WriteLine(playerPokeName + " has " + PlayerStarterPokemon.life + " HP left");
        WaitTime();
        Console.WriteLine("");
        Console.WriteLine("What will " + playerPokeName + " do:");

        for (int i = 0; i < PlayerStarterPokemon.moves.Count; i++)
        {
            Console.WriteLine(PlayerStarterPokemon.moves[i]);
        }

        PlayerStarterPokemon.PlayerMoveChosen = Convert.ToInt32(Console.ReadLine());

        PlayerMoveChosen();
        Console.WriteLine("");
        EnemyMoveChosen();
    }

    else if (PlayerStarterPokemon.life <= 0)
    {
        Console.WriteLine(playerName + " loses");
    }
}
    



void PlayerMoveChosen()
{
    if (PlayerStarterPokemon.PlayerMoveChosen == 1)
    {
        PlayerStarterPokemon.move1();
    }
    else if (PlayerStarterPokemon.PlayerMoveChosen == 2)
    {
        PlayerStarterPokemon.move2();
    }
    else if (PlayerStarterPokemon.PlayerMoveChosen == 3)
    {
        PlayerStarterPokemon.move3();
    }
    else if (PlayerStarterPokemon.PlayerMoveChosen == 4)
    {
        PlayerStarterPokemon.move4();
    }
    else
    {
        Console.WriteLine("Thats not a move, please choose either 1, 2, 3 or 4 ");
        PlayerStarterPokemon.PlayerMoveChosen = Convert.ToInt32(Console.ReadLine());
        PlayerMoveChosen();
    }

    return;
}

void EnemyMoveChosen()
{
    if (EnemyStarterPokemon.life > 0)
    {
        EnemyStarterPokemon.EnemyMoveChosen = random.Next(1, 4);

        if (EnemyStarterPokemon.EnemyMoveChosen == 1)
        {
            EnemyStarterPokemon.move1();
        }
        else if (EnemyStarterPokemon.EnemyMoveChosen == 2)
        {
            EnemyStarterPokemon.move2();
        }
        else if (EnemyStarterPokemon.EnemyMoveChosen == 3)
        {
            EnemyStarterPokemon.move3();
        }
        else if (EnemyStarterPokemon.EnemyMoveChosen == 4)
        {
            EnemyStarterPokemon.move4();
        }
        Console.WriteLine("");
        Battle();
    }
    
    else
    {
        Console.WriteLine(playerName + " wins");
        WaitTime();
        Console.WriteLine(playerPokeName + " gained " + EnemyStarterPokemon.expDropped + " exp");
        PlayerStarterPokemon.exp += EnemyStarterPokemon.expDropped;
        WaitTime();
        if (PlayerStarterPokemon.exp >= PlayerStarterPokemon.expNeeded)
        {
            Console.WriteLine(playerPokeName + " leveled up. " + playerPokeName + "s attack and health grew by 2");
            WaitTime();
            PlayerStarterPokemon.maxDamageBoost += 2;
            PlayerStarterPokemon.maxLife += 2;
            PlayerStarterPokemon.exp -= PlayerStarterPokemon.expNeeded;
            PlayerStarterPokemon.expNeeded += 25;
        }
        PlayerStarterPokemon.damageBoost = PlayerStarterPokemon.maxDamageBoost;
        if (!beatRival)
        {
            beatRival = true;
            PostRivalGame();
        }
        else if (beatRival)
        {
            FreeGame();
        }
        
    }
}

void PostRivalGame()
{
    Console.WriteLine("Professor: That was a good fight, now let me heal your pokemon");
    PlayerStarterPokemon.life = PlayerStarterPokemon.maxLife;
    WaitTime();
    Console.WriteLine(playerPokeName + "s life was healed full");
    WaitTime();
    Console.WriteLine("Professor: Now that you've learned the ropes, you should go out into the world and explore");
    WaitTime();
    Console.WriteLine(trainerName + ": you can go into the tall grass to fight pokemon, if your pokemon get low on health, then you should visit the pokemon center and get your pokemon healed");
    WaitTime();
    FreeGame();
}

void FreeGame()
{
    Console.WriteLine("[1] Pokemon center");
    Console.WriteLine("[2] Tall grass");
    int choice = Convert.ToInt32(Console.ReadLine());
    if(choice == 1)
    {
        PokemonCenter();
    }
    else if (choice == 2)
    {
        WildBattleStart();
    }
    else
    {
        Console.WriteLine("That´s not an option, try again");
        FreeGame();
    }
}

void PokemonCenter()
{
    Console.WriteLine("Nurse Joy: Welcome to the pokemon center, may i heal your pokemon");
    WaitTime();
    PlayerStarterPokemon.life = PlayerStarterPokemon.maxLife;
    Console.WriteLine("Nurse Joy: Thank you for your patince, your pokemon are fully healed now");
    WaitTime();
    Console.WriteLine("Nurse Joy: We hope to see you again");
    WaitTime();
    FreeGame();
}

void WildBattleStart()
{
    int randomPoke = random.Next(1, 3);
    switch (randomPoke)
    {
        case 1:
            EnemyStarterPokemon = new Charmander();
            PlayerStarterPokemon.Target = EnemyStarterPokemon;
            EnemyStarterPokemon.Target = PlayerStarterPokemon;
            enemyPokeName = "Charmander";
            Console.WriteLine("You endountered a wild " + enemyPokeName);
            WildBattle();
            break;

        case 2:
            EnemyStarterPokemon = new Bulbasaur();
            PlayerStarterPokemon.Target = EnemyStarterPokemon;
            EnemyStarterPokemon.Target = PlayerStarterPokemon;
            enemyPokeName = "Bulbasaur";
            Console.WriteLine("You endountered a wild " + enemyPokeName);
            WildBattle();
            break;

        case 3:
            EnemyStarterPokemon = new Squirtle();
            PlayerStarterPokemon.Target = EnemyStarterPokemon;
            EnemyStarterPokemon.Target = PlayerStarterPokemon;
            enemyPokeName = "Squirtle";
            Console.WriteLine("You endountered a wild " + enemyPokeName);
            WildBattle();
            break;

        default:
            FreeGame();
            break;
    }
}

void WildBattle()
{
    if (EnemyStarterPokemon.life > 0)
    {
        Console.WriteLine(enemyPokeName + " has " + EnemyStarterPokemon.life + " HP left");
        WaitTime();
        Console.WriteLine(playerPokeName + " has " + PlayerStarterPokemon.life + " HP left");
        WaitTime();
        Console.WriteLine("");
        Console.WriteLine("What will " + playerPokeName + " do:");

        for (int i = 0; i < PlayerStarterPokemon.moves.Count; i++)
        {
            Console.WriteLine(PlayerStarterPokemon.moves[i]);
        }

        PlayerStarterPokemon.PlayerMoveChosen = Convert.ToInt32(Console.ReadLine());

        PlayerMoveChosen();
        Console.WriteLine("");
        EnemyMoveChosen();
    }

    else if (PlayerStarterPokemon.life <= 0)
    {
        Console.WriteLine(playerName + " loses");
    }

}

void WaitTime()
{
    Thread.Sleep(1000);
}