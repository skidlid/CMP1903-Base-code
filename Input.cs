using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        
        string text;
        string textfile;


        public string manualTextInput()
        {
            Console.WriteLine("Hello, Write and sentence you like! ");
            text = Console.ReadLine();
            return text;
        }




        public string fileTextInput(string fileName) 
        {
            string Error = ("wrong file. try again.");

            string file = File.ReadAllText(@$"../../../../{fileName}");
            
            return file;                       //Console.WriteLine(file);
        }


    }
}