using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {
        static void WriteUserPrompt()
        {
            Console.WriteLine("Enter Text to See if it's a Palidrome:");
        }

        static string GetWord()
        {
            string inputWord = Console.ReadLine();
            return inputWord;
        }

        static bool CheckForExit(ref string inputWord)
        {
            bool timeToExit = false;
            inputWord = inputWord.Trim();
            if (inputWord.ToLower() == "exit")
                timeToExit = true;
            return timeToExit; 
        }
                    
        static string FlipWord(string inputWord) { 
            char[] inputChars = inputWord.ToCharArray();//convert input to array of characters
            char[] outputChars = new char[inputChars.Length];//new array w #cells = wordlength

            int i, j;
            j = inputChars.Length;//note: if length =3, the 3rd char is in array[2]-0 based idx

            for (i = 0; i < inputChars.Length; i++)
            {
                --j;
                outputChars[j] = inputChars[i];
                /*Console.WriteLine($" { outputChars[j]} { inputChars[1]}");*/
            }
            string outputWord = new string(outputChars);//convert array to string
            return outputWord;
        }

        static void WriteYesOrNoPalidrome(string outputWord, string inputWord)
        {
            if (outputWord == inputWord)
                Console.WriteLine("Yes, this is a Palindrome!");
            else
                Console.WriteLine("No, this is not a Palindrome!");
        }

        static void WriteTryAgainOrExit()
        {
            Console.WriteLine("Enter Text to Try Again, or Exit to End");
        }
        

        static void Main(string[] args)
        {
            WriteUserPrompt();
            bool exit = false;
            int ctr = 0;

            do
            {
                string inputWord = GetWord();
                Console.WriteLine($"after GetWord():  { inputWord}");

                bool timeToExit = CheckForExit(ref inputWord);
                if (timeToExit == true)
                    exit = true;

                string outputWord = FlipWord(inputWord);
                Console.WriteLine($"after FlipWord():  {outputWord}");

                WriteYesOrNoPalidrome(outputWord, inputWord);

                WriteTryAgainOrExit();

                /*Console.ReadKey();*/
                ctr++;
                if (ctr == 15)//cut off the user afters 15 X
                    exit = true;

            }
            while (exit == false);
           

        }//end of Main
    }
}
