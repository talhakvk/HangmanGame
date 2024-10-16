# Hangman Game (C# - DevExpress)
This repository contains a Hangman Game developed using C# and the DevExpress library. The game is a simple implementation of the classic word-guessing game "Hangman," where the player must guess the hidden word by suggesting letters, one at a time, within a limited number of guesses.
## Features
- **Random Word Selection:** The game randomly selects a word from a predefined list of words for the player to guess.
- **Limited Guesses:** The player has 8 guesses to figure out the word. Incorrect guesses reduce the remaining chances.
- **Visual Hangman Display:** For every incorrect guess, a visual representation of a hangman progresses through 8 stages until the game is lost.
- **Win/Loss Conditions:** If the player guesses all letters correctly, they win. If they run out of guesses, they lose.
- **User-friendly Interface:** The game uses DevExpress components for a clean and responsive UI

## How to Play
1. **Start the Game:** When the game starts, a random word will be selected, and each letter will be represented by underscores (_).
2. **Guess a Letter:** The player can input a letter into the provided text box and click the "Guess" button.
3. **Correct Guess:** If the guessed letter is in the word, it will appear in the correct position(s).
4. **Incorrect Guess:** If the guessed letter is not in the word, the hangman visual will progress, and the number of remaining guesses will decrease.
5. **Game Over:** The game ends when the player either guesses the word correctly or runs out of guesses.

## Project Structure
- **Form1.cs:** Contains the main logic for the game, including word selection, guess checking, and win/loss logic.
- **Form1.Designer.cs:** Manages the layout and design of the form, including buttons, labels, and text input fields using DevExpress components.
- **Resources:** ASCII-style hangman graphics are used to visually show the player's progress.

## Prerequisites
To run this project, you need:
- **Visual Studio** (or any compatible IDE)
- **.NET Framework 4.5+**
- **DevExpress** libraries installed in your development environment.

## Installation and Setup
1. Clone the repository:
```
git clone https://github.com/talhakvk/HangmanGame.git
```
2. Open the solution in **Visual Studio.**
3. Make sure the **DevExpress** components are correctly installed in your environment.
4. Run the project to start playing the Hangman Game.

## Screenshots
![hangman game image](https://github.com/talhakvk/HangmanGame/blob/main/HangmanGame/HangmanGame/image/Hangman-Game-%C4%B0mage.png)

## License
This project is open-source and available under the [MIT License.](https://opensource.org/licenses/MIT)

  
