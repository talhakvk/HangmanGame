using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HangmanGame
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        // Array holding the different stages of the hangman graphic
        private string[] hangmanStages = new string[] 
        {
            @"
               --------
               |      |
               |      
               |    
               |      
               |     
               -",
            @"
               --------
               |      |
               |      O
               |    
               |      
               |     
               -",
            @"
               --------
               |      |
               |      O
               |      |
               |      
               |     
               -",
            @"
               --------
               |      |
               |      O
               |     \|
               |      
               |     
               -",
            @"
               --------
               |      |
               |      O
               |     \|/
               |      
               |     
               -",
            @"
               --------
               |      |
               |      O
               |     \|/
               |      |
               |     
               -",
            @"
               --------
               |      |
               |      O
               |     \|/
               |      |
               |     / 
               -",
            @"
               --------
               |      |
               |      O
               |     \|/
               |      |
               |     / \
               -"
        };

        // The player has a total of 8 guesses
        private int remainingGuesses = 8; 
        private string selectedWord; // The word to be guessed in the game
        private List<char> enteredLetters = new List<char>(); // List of entered letters
        private string[] guessProgress; // The current state of the word being guessed

        public Form1()
        {
            InitializeComponent();
            StartGame(); // Start the game
        }

        // Method to start the game
        private void StartGame()
        {
            // Select a random word
            string[] words = new string[] { "CLASS", "OBJECT", "DATA", "UNITY", "BACKEND", "FRONTEND" };
            Random random = new Random();
            selectedWord = words[random.Next(0, words.Length)]; // A random word is selected
            guessProgress = new string[selectedWord.Length]; // Create an empty guess state as long as the selected word

            // Initialize with underscores for each letter in the word
            for (int i = 0; i < guessProgress.Length; i++)
            {
                guessProgress[i] = "_";
            }

            // Reset the hangman graphic and the word progress
            labelHangman.Text = hangmanStages[0]; // Initial hangman graphic
            labelWordProgress.Text = string.Join(" ", guessProgress); // Show the word state as "_ _ _"
            enteredLetters.Clear(); // Clear the entered letters
            remainingGuesses = 8; // Reset remaining guesses
        }

        // Method executed when the guess button is clicked
        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string enteredLetterStr = textBoxLetter.Text.ToUpper(); // Convert entered letter to uppercase
            if (enteredLetterStr.Length == 1) // If a single letter is entered
            {
                char enteredLetter = enteredLetterStr[0];

                // If the letter was already entered, display a warning
                if (enteredLetters.Contains(enteredLetter))
                {
                    XtraMessageBox.Show("You have already entered this letter, try another.");
                    return;
                }

                // Add the entered letter to the list
                enteredLetters.Add(enteredLetter);

                // Check if the entered letter exists in the word
                bool letterFound = false;
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == enteredLetter)
                    {
                        guessProgress[i] = enteredLetter.ToString();
                        letterFound = true;
                    }
                }

                // If the letter is not found, decrease remaining guesses and update hangman graphic
                if (!letterFound)
                {
                    remainingGuesses--;
                    if (remainingGuesses > 0) // Check if any guesses remain
                    {
                        labelHangman.Text = hangmanStages[8 - remainingGuesses]; // Update hangman graphic after incorrect guesses
                    }
                }

                // If no guesses remain, the game ends
                if (remainingGuesses == 0)
                {
                    XtraMessageBox.Show($"Game Over! The word was: {selectedWord}"); // Notify the player of losing
                    StartGame(); // Restart the game
                }

                // Update the current word state
                labelWordProgress.Text = string.Join(" ", guessProgress);

                // If all letters are guessed correctly, the player wins
                if (string.Join("", guessProgress) == selectedWord)
                {
                    XtraMessageBox.Show("Congratulations, you won!"); // Notify the player of winning
                    StartGame(); // Restart the game
                }

                // Check again if no guesses remain and notify the player of losing
                if (remainingGuesses == 0)
                {
                    labelHangman.Text = hangmanStages[7]; // Show the final hangman graphic
                    XtraMessageBox.Show($"Game Over! The word was: {selectedWord}"); // Notify of the lost game
                    StartGame(); // Restart the game
                }
            }
            else
            {
                XtraMessageBox.Show("Please enter a single letter!"); // Warn if more than one character is entered
            }

            textBoxLetter.Text = string.Empty; // Clear the input field
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
