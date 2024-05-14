using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChatbot
{
    public class BotToString
    {
        //method to write a string to the console in blue and with a delay
        public static void WriteBot(string text, int delay, string color)
        {
            Console.WriteLine("...");
            foreach (char c in text)
            {
                Console.Write(color + c);
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.WriteLine("...");
        }


        //this method checks if the user input contains any of the n-words and is only for sam and not for the average user
        //it is not used in the final version of the chatbot
        //Sam if you re
        public static bool CheckNWord(string text)
        {
            string[] nWords = { "nigger", "neger", "nigga", "monkey",  };
            foreach (string nWord in nWords)
            {
                if (text.ToLower().Contains(nWord))
                {
                    return true;
                }
            }
            return false; 
        }

        

    }
}
