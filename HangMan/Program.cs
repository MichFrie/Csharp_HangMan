using System;

namespace HangMan
{
    class Program
    {

        public string missedLetters = "";
        public string correctLetters = "";
        public static string secretWord = "";



        static void Main(string[] args)
        {
            displayBoard("ddd", "", "wert");
        }

        public static string wordData = "ant baboon badger bat bear beaver camel cat clam cobra cougar coyote crow deer dog donkey duck eagle ferret fox frog goat goose hawk lion lizard llama mole monkey moose mouse mule newt otter owl panda parrot pigeon python rabbit ram rat raven rhino salmon seal shark sheep skunk sloth snake spider stork swan tiger toad trout turkey turtle weasel whale wolf wombat zebra";

        public static string[] words = wordData.Split(" ");

        public static string getRandomWord()
        {
            Random rnd = new Random();
            int wordIndex = rnd.Next(0, words.Length - 1);
            return words[wordIndex];
        }

        public static void displayBoard(string missedLetters, string correctLetters, string secretWord)
        {
            Console.WriteLine(hangManPics[missedLetters.Length]);
            Console.WriteLine("Missed Letters: " + missedLetters);

            int multiplier = secretWord.Length;
            string blanks = new string('_', multiplier);
            Console.WriteLine(blanks);

        }
        
        
        public static string[] hangManPics = new string[] {
            @"+---+
    |
    |
    |
   ===",
            @"+---+
  ° |
    |
    |
   ===",
           @"+---+
  ° |
  | |
    |
   ===",
           @"+---+
  ° |
 /| |
    |
   ===",
           @"+---+
  ° |
 /|\|
    |
   ===",
           @"+---+
  ° |
 /|\|
 /  |
   ===",
           @"+---+
  ° |
 /|\|
 / \|
   ==="
        };
    }

}
