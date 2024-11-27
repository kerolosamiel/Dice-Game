// Entry point of the application
RunDiceGame();

// Starts the Dice Game application.
void RunDiceGame()
{
    DisplayMessage("Please Enter your name:");
    string sPlayerName = Console.ReadLine()!;
    sPlayerName = String.IsNullOrEmpty(sPlayerName) ? "player" : sPlayerName; 
    Console.Clear();
    
    bool bIsGameActive = true;
    
    // Main game loop
    while (bIsGameActive)
    {
        DisplayMessage($"""
                        Hello {sPlayerName}, Welcome to the Dice Game: 
                            - When you roll the dice, the enemy will roll as well.
                            - After 10 round the game will calculate the score.
                            - After that, the winner will be determined.
                        """);
        DisplayMessage("Press any key to start game :)");
        Console.ReadKey();
        Console.Clear();
        
        // Play the game for 10 rounds and calculate scores
        PlayRounds(out int nPlayerScore, out int nEnemyScore, sPlayerName);
        // Determine and display the winner
        CheckWinner(nPlayerScore, nEnemyScore, sPlayerName);
        // Ask the player if they want to play again
        DisplayMessage("Do you want to try again? (Y/N)");
        bIsGameActive = CheckContinue();
        
        Console.Clear();
    }
}

#region Methods

// Displays a message to the console.
void DisplayMessage (string message)
{
    Console.WriteLine(message);
}

// Executes 10 rounds of the dice game and calculates scores for both player and enemy.
void PlayRounds(out int playerScore, out int enemyScore, string playerName)
{
    Random randomGenerator = new Random();
    int nTotalPlayerScore = 0;
    int nTotalEnemyScore = 0;
    
    for (int i = 0; i < 10; i++)
    {
        DisplayMessage("Please, press any key to roll the dice");
        Console.ReadKey();
        
        // Player rolls the dice
        nTotalPlayerScore += GameConcept(randomGenerator, playerName);
        DisplayMessage("--------------");
        
        // Enemy rolls the dice
        nTotalEnemyScore += GameConcept(randomGenerator, "Enemy");
        DisplayMessage("");
    }

    playerScore = nTotalPlayerScore;
    enemyScore = nTotalEnemyScore;
}

// Simulates a dice roll and returns the rolled value.
// <param name="randomGenerator">Random number generator instance.</param>
// <param name="rollerName">The name of the roller (Player or Enemy).</param>
int GameConcept(Random randomGenerator, string rollerName)
{
    int nRolledValue = randomGenerator.Next(1, 7);
    DisplayMessage($"{rollerName} get: {nRolledValue}");
    return nRolledValue;
}

// Determines and announces the winner based on the scores.
void CheckWinner(int playerScore, int enemyScore, string playerName)
{
    DisplayMessage($"{playerName} Score: {playerScore}");
    DisplayMessage($"Enemy Score: {enemyScore}");
    
    // Compare scores and declare the winner
    DisplayMessage(playerScore > enemyScore ? $"{playerName} is the winner :)" : "Enemy is the winner :(");
}

// Asks the user if they want to restart the game and returns their decision.
bool CheckContinue()
{
    string sUserInput = Console.ReadLine()!;

    // Interpret user input
    switch (sUserInput.ToLower())
    {
        case "yes":
        case "y":
            return true;
        default:
            return false;
    }
}
#endregion