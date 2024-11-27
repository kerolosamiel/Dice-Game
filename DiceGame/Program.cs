StartApp();
void StartApp()
{
    Message("Please Enter your name:");
    string sName = Console.ReadLine()!;
    sName = String.IsNullOrEmpty(sName) ? "player" : sName; 
    Console.Clear();
    
    bool bCheck = true;
    while (bCheck)
    {
        Message($"""
                Hello {sName}, Welcome to the Dice Game: 
                    - When you roll the dice, the enemy will roll as well.
                    - After 10 round the game will calculate the score.
                    - After that, the winner will be determined.
                """);
        Message("Press any key to start game :)");
        Console.ReadKey();
        Console.Clear();
        
        Looping(out int nPlayerScore, out int nEnemyScore, sName);
        CheckWinner(nPlayerScore, nEnemyScore, sName);
        Message("Do you want to try again? (Y/N)");

        bCheck = CheckContinue();
        Console.Clear();
    }
}

#region Methods

void Message (string message)
{
    Console.WriteLine(message);
}

void Looping(out int player, out int enemy, string name)
{
    Random rRandom = new Random();
    int nPlayer = 0;
    int nEnemy = 0;
    
    for (int i = 0; i < 10; i++)
    {
        Message("Please, press any key to roll the dice");
        Console.ReadKey();
        nPlayer += GameConcept(rRandom, name);
        Message("--------------");
        nEnemy += GameConcept(rRandom, "Enemy");
        Message("");
    }

    player = nPlayer;
    enemy = nEnemy;
}

int GameConcept(Random random, string player)
{
    int nRandom = random.Next(1, 7);
    Message($"{player} get: {nRandom}");
    return nRandom;
}

void CheckWinner(int player, int enemy, string name)
{
    Message($"{name} Score: {player}");
    Message($"Enemy Score: {enemy}");
    Message(player > enemy ? $"{name} is the winner :)" : "Enemy is the winner :(");
}

bool CheckContinue()
{
    string sUserAnswer = Console.ReadLine()!;

    switch (sUserAnswer.ToLower())
    
    {
        case "yes":
        case "y":
            return true;
        default:
            return false;
    }
}
#endregion