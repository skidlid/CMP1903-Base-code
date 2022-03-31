using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();


            //Create 'Input' object
            string text = "hello";

            Console.WriteLine("Welcome, to the sentence analyser");
            Console.WriteLine("1) From your own sentence");
            Console.WriteLine("2) From a file");
            string userchoice = Console.ReadLine();

            if (userchoice == "1")
            {
                Input userInput = new Input();
                text = userInput.manualTextInput();

            }
            else if (userchoice == "2")
            {
                Input userInput = new Input();
                Console.WriteLine("Please name the file");
                string filename = Console.ReadLine();
                text = userInput.fileTextInput(filename);

            }

            else
            {
                Console.WriteLine("Not a valid file");
            }


            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Analyse statistics = new Analyse();
            statistics.analyseText(text);

            Console.WriteLine("  ");

            //Report the results of the analysis
            Report LongWords = new Report();
            LongWords.outputConsole(text);

            Console.WriteLine("");

            //TO ADD: Get the frequency of individual letters?
            Analyse Letters = new Analyse();
            Letters.FrequencyLetters(text);

          


        }



    }
}
