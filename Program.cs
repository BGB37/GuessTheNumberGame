using System;

namespace isim_uzayı

{
    class GuessTheNumberGame
    {
        static int UserGuess;
        static int RandomNumber;
        static string YesOrNo = "Y";
        static int count = 0;
        static bool ValidAnswer = false;

        static void WelcomeMessage()
        {
            Console.WriteLine("\tWelcome to the \"Guess The Number\" game.");
            Console.WriteLine("\tTry to guess the number in my mind from 1 to 10. If you know, you win.");
        }

        public static void GeneratingTheNumber()
        {
            Random rand = new Random();  // I've created an object from random class. I used the Random class' constructor.
            RandomNumber = rand.Next(1, 11);

        }

        static void AskForAGuess()
        {
            ValidAnswer = false;

            while (ValidAnswer == false)
            {
                try
                {
                    ValidAnswer = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tMake your guess!");
                    Console.ResetColor();
                    UserGuess = Convert.ToInt16(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\t{e.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ResetColor();
                    ValidAnswer = false;

                }

            }

        }

        static void ShowResult()
        {
            if (UserGuess == RandomNumber)
            {
                Console.WriteLine($"\n\tYes the number in my mind was: {RandomNumber}.");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\t YOU WON!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"\n\tThe number in my mind was: {RandomNumber}. Maybe next time.");

            }
        }

        static void PlayAgain()
        {
            while (YesOrNo != "Y" || YesOrNo != "N")
            {
                
                    Console.WriteLine("\n\tWould you like to play again? Type Y for yes and N for no.");
                    YesOrNo = Console.ReadLine();
                    YesOrNo = YesOrNo.ToUpper();
                    
                if(YesOrNo != "Y" || YesOrNo != "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tYou entered: {0}",YesOrNo);
                    Console.WriteLine("\tYou should enter Y or N.");
                    Console.ResetColor();   
                }
            }
        }

        static void ProgramEnded()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\tPROGRAM ENDED");
            Console.ResetColor();
        }

        class Program
        {
            static void Main(string[] args)
            {
                while (YesOrNo == "Y")
                {
                    if (count == 0)
                    {
                        WelcomeMessage();
                    }
                    GeneratingTheNumber();
                    AskForAGuess();
                    ShowResult();
                    PlayAgain();
                    count++;
                }

                ProgramEnded();

            }
        }
    }
}
