StartApp();
void StartApp()
{
    bool bCheck = true;

    while (bCheck)
    {
        Message("Welcome to the Dice Game, please press any key to continue!");
        Console.ReadKey();
        Console.Clear();
        
        Looping(out int nPlayerScore, out int nEnemyScore);
        CheckWinner(nPlayerScore, nEnemyScore);
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

void Looping(out int player, out int enemy)
{
    Random rRandom = new Random();
    int nPlayer = 0;
    int nEnemy = 0;
    
    for (int i = 0; i < 10; i++)
    {
        Message("Please, press any key to throw the dice");
        Console.ReadKey();
        nPlayer += GameConcept(rRandom, "Player");
        Message("--------------");
        nEnemy += GameConcept(rRandom, "Enemy");
        Message("");
    }

    player = nPlayer;
    enemy = nEnemy;
}

int GameConcept(Random random, string player)
{
    int nRendom = random.Next(1, 7);
    Message($"{player} get: {nRendom}");
    return nRendom;
}

void CheckWinner(int player, int enemy)
{
    Message($"Player Score: {player}");
    Message($"Enemy Score: {enemy}");
    if (player > enemy)
        Message("Player is the winner :)");
    else
        Message("Enemy is the winner");
}

bool CheckContinue()
{
    string? sUserAnswer = Console.ReadLine()!.ToLower();

    switch (sUserAnswer)
    {
        case "yes":
        case "y":
            return true;
        default:
            return false;
    }
}
#endregion