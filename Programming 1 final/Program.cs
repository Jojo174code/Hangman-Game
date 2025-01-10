using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Programming_1_final
{
    class Progam
    {


        static void Main(string[] args)
        {


            int Score = 0;
            int attempts = 0;
            string secretWord;
            char[] encryptWord;







           for (int i = 0; i < 5; i++)
            {
                splash.AnimateAsciiArt();
                Console.Clear();
            }

            Console.WriteLine("Hello player, enter your name: ");
            string userName = Console.ReadLine();
            UserGreeting(userName);
            
            secretWord = SelectRandomWord();
            encryptWord = new char[secretWord.Length];
            







            while (!IsWordSolved(encryptWord) && attempts < 6) // while the word is not solved and attempts amount isn't exceeded thios while loop will spin the wheel for points, ask the player to pick a letter, check if the letter is in the word and if so increase the score and then check the game status  
            {
                Console.Clear();
                DisplayScoreAndWord(Score, encryptWord);

                int pointValue = SpinWheel();
                Console.WriteLine($"{userName}, for {pointValue} points, pick a letter: ");
                char guessedLetter = Console.ReadKey().KeyChar;

                bool isCorrect = CheckGuess(guessedLetter, secretWord, encryptWord);

                if (isCorrect)
                {
                    Score += pointValue;
                }


                attempts++;
                CheckGameStatus(secretWord, encryptWord, attempts, Score);

            }

            Console.ReadKey();
        }

        static void UserGreeting(string userName) // This method Checks if the users input is valid then prints the user greeting 
        {
            


            if (int.TryParse(userName, out _) == false)
            {
                Console.WriteLine($"Hello, {userName}! Welcome to the game.");
                Console.WriteLine($"{userName}, press any key to spin");
                Console.ReadKey();
            }
            else
            {
                 Console.WriteLine("Error: Your name cannot be a number.");
                 Console.ReadLine();
                 Environment.Exit(0);
                
            }
        }

        static string SelectRandomWord() // This method selects a random word 
        {
            string[] words = { "frogger", "doom", "joust", "tetris", "tron" };
            Random random = new Random();
            int index = random.Next(words.Length);
            return words[index];
        }

        static int SpinWheel() // This method is for getting a random amout of points for each guess
        {
            Random random = new Random();
            return random.Next(100, 501);
        }

        static bool CheckGuess(char guessedLetter, string secretWord, char[] encryptWord) // This method checks to see if the users geussed letter is right or wronng and if its right this method runs the UpdateEncryptWord method
        {
            bool isCorrect = secretWord.Contains(guessedLetter);
            if (isCorrect)
            {
                UpdateEncryptWord(guessedLetter, secretWord, encryptWord);
                Console.WriteLine("\n");
                Console.WriteLine($"Correct!  {guessedLetter} is in the word.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Incorrect! {guessedLetter} is not in the word.");

            }

            return isCorrect;
        }

        static void DisplayScoreAndWord(int score, char[] encryptWord) /// This method displays the screen and "_" for each letter in the secret word 
        {
            Console.WriteLine($"Score: {score}");
            Console.Write($"Secret word: ");

            foreach (char letter in encryptWord)
            {
                Console.Write(letter == '\0' ? "_" : letter.ToString());
            }

            Console.WriteLine();
        }

        static void UpdateEncryptWord(char guessedLetter, string secretWord, char[] encryptWord) // This method is for updating the "_" to the letter if gussed right 
        {
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guessedLetter)
                {
                    encryptWord[i] = guessedLetter;
                }
            }
        }

        static void CheckGameStatus(string secretWord, char[] encryptWord, int attempts, int score) // This method checks to see if the player has solved the word or has went over the attemts amount ehich would mean they lost
        {
            if (IsWordSolved(encryptWord))
            {
                Console.WriteLine("\n");
                Console.WriteLine("Congratulations! You solved the word!");
                DisplayScoreAndWord(score, encryptWord);
            }
            else if (attempts == 6   )
            {
                Console.WriteLine("\n");

                Console.WriteLine("Sorry, you've run out of guesses. The word was: " + secretWord);
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        static bool IsWordSolved(char[] encryptWord)        
        {
            return !encryptWord.Contains('\0');
        }
    }
}
