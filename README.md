# Dice Game

Welcome to the **Dice Game** – a simple console-based game where you roll dice against an enemy to determine the winner after 10 rounds. This project is implemented in C# and is a great demonstration of fundamental programming concepts like loops, conditional statements, and methods.

---

## Table of Contents
1. [Overview](#overview)
2. [Features](#features)
3. [How to Run](#how-to-run)
4. [How to Play](#how-to-play)
5. [Project Structure](#project-structure)

---

## Overview

The **Dice Game** challenges you to outscore an enemy in a dice-rolling competition over 10 rounds. Each player rolls a dice, with the scores tallied at the end to determine the winner. You can play multiple rounds and enjoy the randomness of the game.

This project serves as a foundation for beginners learning C# programming and for anyone looking to explore basic game logic.

---

## Features
- Interactive console-based gameplay.
- Randomized dice rolls for fair competition.
- Tracks scores for both the player and the enemy.
- Declares a winner after 10 rounds.
- Option to play multiple rounds by restarting the game.

---

## How to Run

### Prerequisites
- [Microsoft .NET SDK](https://dotnet.microsoft.com/en-us/download) installed on your machine.
- A code editor, such as [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/).

### Steps to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/DiceGame.git
2. Navigate to the project directory:
   ```bash
    cd DiceGame
3. Build and run the project using the .NET CLI:
   ```bash
    dotnet run

---

## How to Play
1. Start the game by entering your name (or leave blank to default to "Player").
2. Follow the on-screen instructions to roll the dice.
3. Compete against the enemy in 10 rounds of dice rolls.
4. After 10 rounds, the game will display the scores and announce the winner.
5. Choose whether to play again or exit the game.

---

## Project Structure
- Program.cs: Contains the entire logic of the Dice Game.
  - Key methods include:
    1. RunDiceGame: The entry point for the game.
    2. PlayRounds: Handles 10 rounds of gameplay.
    3. RollDice: Simulates rolling a dice.
    4. DetermineWinner: Calculates and announces the winner.
    6. ShouldRestartGame: Handles user input for restarting the game.

---

## Contributing
Contributions are welcome! If you'd like to improve the game or add features,
feel free to fork the repository and submit a pull request.

---

## Contact

If you have any questions or feedback,
please reach out via **kerolosamiel4@gmail.com** or open an issue in this repository.

---