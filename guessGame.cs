using System.Collections;
using System.Text;

namespace laptopBrand
{
    public class guessGame
    {
        public void Play()
        {
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            Console.WriteLine("------------------------------ Welcome to Word Guessing Game ------------------------------");
            Console.Write("Before we start, Enter your name first: ");
            string userName = Console.ReadLine();

            Console.WriteLine("------------------------------ Welcome to Word Guessing Game {0} ------------------------------", userName);

            // List all the computer brands in ArrayList
            ArrayList computerBrands = new ArrayList();
            computerBrands.Add("Asus");
            computerBrands.Add("MSI");
            computerBrands.Add("Alienware");
            computerBrands.Add("Microsoft");
            computerBrands.Add("Samsung");
            computerBrands.Add("Apple");
            computerBrands.Add("Acer");
            computerBrands.Add("Huawei");
            computerBrands.Add("Dell");
            computerBrands.Add("Lenovo");

            // Checks the correct computer brand using StringBuilder
            StringBuilder brandCheck = new StringBuilder((string?)computerBrands[6]);


            Console.Write("Here are the lists of computer brands: ");
            foreach (string brands in computerBrands)
            {
                Console.Write(brands + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Note: you will only have three(3) guesses! ");
            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Guess my laptop's Brand: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    if (guessCount == 2)
                    {
                        Console.WriteLine("1 guess left!");
                    }
                }
                else
                {
                    outOfGuesses = true;
                }

            }

            while (guess != brandCheck.ToString() && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Play();

            }
            else
            {
                Console.WriteLine("\nYou Win!");

                StringBuilder greetUser = new StringBuilder("\nThank your for playing the Guessing Game ");
                greetUser.Append(userName + "!");
                Console.WriteLine(greetUser);
            }

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            guessGame guessingGame = new guessGame();
            guessingGame.Play();

        }

    }


}