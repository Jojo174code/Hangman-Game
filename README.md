# Hangman-Game



--Overview--

The game allows a player to guess letters of a randomly selected word from a predefined list. The game animates ASCII art before starting, provides a mechanism for the player to guess letters, and keeps score based on the correctness of the guesses. The game ends either when the player successfully guesses the word or exhausts the allowed number of attempts.

--Main Components--

1) ASCII Art Animation (splash.cs): This class handles the animation displayed at the beginning of the game. It animates ASCII art across the console screen by clearing the console and redrawing the ASCII art in new positions.

2) Game Logic (Program.cs): The main class orchestrates the game, including:

  --Welcoming the player and validating the player's name input.
  --Selecting a random word from a list of game words like "frogger", "doom", "joust", etc.
  --Encrypting this word (displayed as underscores initially).
  --Allowing the player to guess letters, updating the score and display based on correct or incorrect guesses.
  --Spinning a wheel to determine the point value of each guess.
  --Checking the game status after each guess to determine if the game continues or ends.



--How to Use--

1) Start the Game: Run the program. It begins with the ASCII art animation followed by prompting for the player's name.

2) Enter Your Name: Type your name when prompted. The game will check if the input is a valid string (not numbers).

3) Play the Game:

  --The game will display an encrypted version of the word (e.g., "______" for "frogger").
  
  --You will be prompted to guess a letter. If your guess is in the word, the corresponding underscores will be replaced with the guessed letter.
  
  --Points will be awarded based on a random spin wheel result for each correct guess.
  
  --You can continue guessing until the word is complete or you have made six incorrect guesses.
  
4) End of Game: The game concludes when you either guess the word completely or run out of attempts. A final score and the correct word (if not guessed) will be displayed.

To start the game, compile and execute the .cs files in a C# environment. Ensure both Program.cs and splash.cs are included in the same namespace to function correctly.


