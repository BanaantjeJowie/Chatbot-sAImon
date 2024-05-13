using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Console_Chatbot
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool restartConversation = true;

            while (restartConversation)
            {
                Console.WriteLine("Welcome to my chatbot, say hi!");
                bool greetResponse = false;

                // Loop for the greeting part of the conversation
                while (!greetResponse)
                {
                    string UserInput = Console.ReadLine();

                    // Check if the user wants to exit
                    if (UserInput.ToLower() == "bye")
                    {
                        Console.WriteLine("Exiting chatbot. Goodbye!");
                        return; // Exit the entire program
                    }

                    // Check for greetings
                    if (UserInput.ToLower() == "hello" || UserInput.ToLower() == "hi" || UserInput.ToLower() == "yoo")
                    {
                        Console.WriteLine("Hi, how are you doing today?");
                        greetResponse = true;
                    }
                    else
                    {
                        Console.WriteLine("Dummy you have to say something.");
                    }
                }

                // Adding a delay with "..." while waiting
                Thread.Sleep(1000);
                Console.WriteLine("...");

                bool responseReceived = false;

                // Loop for the response part of the conversation
                while (!responseReceived)
                {
                    string UserInput = Console.ReadLine();

                    // Check if the user wants to exit
                    if (UserInput.ToLower() == "bye")
                    {
                        Console.WriteLine("Exiting chatbot. Goodbye!");
                        return; // Exit the entire program
                    }

                    // Check how the user is doing
                    if (UserInput.ToLower() == "good" || UserInput.ToLower() == "fine" || UserInput.ToLower() == "great")
                    {
                        Console.WriteLine("That's great to hear!");
                        responseReceived = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry to hear that.");
                        break;
                    }
                }

                // Adding a delay with "..." while waiting
                Thread.Sleep(1000);
                Console.WriteLine("...");

                // Loop for asking what the user's name is
                bool nameReceived = false;
                while (!nameReceived)
                {
                    Console.WriteLine("What is your name?");
                    string UserInput = Console.ReadLine();

                    // Check if the user wants to exit
                    if (UserInput.ToLower() == "bye")
                    {
                        Console.WriteLine("Exiting chatbot. Goodbye!");
                        return; // Exit the entire program
                    }

                    // Check if the user has entered a name
                    if (UserInput.Length > 0)
                    {
                        Console.WriteLine("Nice to meet you, " + UserInput + "!");
                        nameReceived = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I didn't catch that. Could you please tell me your name?");
                    }
                }

                // Adding a delay with "..." while waiting
                Thread.Sleep(1000);
                Console.WriteLine("...");

                // Ask if the user wants to restart the conversation
                Console.WriteLine("Do you want to restart the conversation? (yes/no)");
                string restartInput = Console.ReadLine().ToLower();

                restartConversation = restartInput == "yes";
            }
        }
    }
}
