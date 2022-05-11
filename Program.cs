// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Text;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            // String to Array
            char[] tst = greetings.ToCharArray();
            Console.WriteLine(tst);

            //Methods in class String 
            string sentence = "the quick";
            bool doesContain = sentence.Contains("fox");
            Console.WriteLine(doesContain);

            string word = "Computer";
            int index = word.IndexOf('p');
            Console.WriteLine(index);

            string color = "Color";
            string strcChanged = color.Replace('o', '#');
            Console.WriteLine(strcChanged);

            // Concatination using two strings
            string fName, lName;
            fName = "Christian Paul";
            lName = " Flores";
            string fullName = string.Concat(fName, lName);
            Console.WriteLine("Full Name: {0}", fullName);

            /*  string strComputer = "Computer";
             strComputer += " is a great invention";
             Console.WriteLine(strComputer); */

            StringBuilder strComputer = new StringBuilder("Computer");
            strComputer.Append(" is a great invention");
            Console.WriteLine(strComputer);

            Console.WriteLine();

            // String Builder class 2 main  properties char and Length
            StringBuilder computer = new StringBuilder("Computer");
            computer[0] = '#';
            for (int i = 0; i < computer.Length; i++)
            {
                Console.Write(computer[i] + " + ");
            }

            Console.WriteLine();

            // Methods in the class StringBuilder

            // Equals 
            StringBuilder wordA = new StringBuilder("computer");
            StringBuilder wordB = new StringBuilder("computer");
            Console.WriteLine(wordA.Equals(wordB));

            // Clear
            StringBuilder worD = new StringBuilder("Computer");
            worD.Clear();
            Console.WriteLine(worD.Append("Ethics"));

            //Replace
            StringBuilder wordR = new StringBuilder("Color");
            wordR.Replace('o', '*');
            Console.WriteLine(wordR);

            //ToString
            StringBuilder wordC = new StringBuilder("computer");
            string Cword = wordC.ToString();
            Console.WriteLine(Cword);


        }
    }
}

