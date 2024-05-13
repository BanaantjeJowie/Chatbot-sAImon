using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Threading;
using ClassLibraryChatbot;

namespace Console_Chatbot
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool restartConversation = true;

            while (restartConversation)
            {
                BotToString.WriteBot("Welcome to the first version of...", 10, "\u001b[34m");
                BotToString.WriteBot(".", 10, "\u001b[34m");
                Thread.Sleep(1000);
                BotToString.WriteBot(".", 10, "\u001b[34m");
                Thread.Sleep(1000);
                BotToString.WriteBot(".", 10, "\u001b[34m");
                Thread.Sleep(1000);
                Console.WriteLine("\u001b[32m ________  ________  ___  _____ ______   ________  ________      ");
                Console.WriteLine("\u001b[32m |\\   ____\\|\\   __  \\|\\  \\|\\   _ \\  _   \\|\\   __  \\|\\   ___  \\    ");
                Console.WriteLine("\u001b[32m \\ \\  \\___|\\ \\  \\|\\  \\ \\  \\ \\  \\\\\\__\\ \\  \\ \\  \\|\\  \\ \\  \\\\ \\  \\   ");
                Console.WriteLine("\u001b[32m  \\ \\_____  \\ \\   __  \\ \\  \\ \\  \\\\|__| \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\  ");
                Console.WriteLine("\u001b[32m   \\|____|\\  \\ \\  \\ \\  \\ \\  \\ \\  \\    \\ \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ ");
                Console.WriteLine("\u001b[32m     ____\\_\\  \\ \\__\\ \\__\\ \\__\\ \\__\\    \\ \\__\\ \\_______\\ \\__\\\\ \\__\\");
                Console.WriteLine("\u001b[32m    |\\_________\\|__|\\|__|\\|__|\\|__|     \\|__|\\|_______|\\|__| \\|__|");
                Console.WriteLine("\u001b[32m    \\|_________|  Your best AI friend!                        ");
                Console.WriteLine("\u001b[32m    \u001b[0m                                                                   ");
                Thread.Sleep(3000);
                BotToString.WriteBot("Hi, my name is sAImon.\n Remember to answer simple.\n Say 'Hi' to start!", 10, "\u001b[34m");

                bool greetResponse = false;

                System.Threading.Thread.Sleep(2000);

                // Loop for the greeting part of the conversation
                while (!greetResponse)
                {
                    string UserInput = Console.ReadLine();

                    // Check if the user wants to exit
                    if (UserInput.ToLower() == "bye")
                    {
                        BotToString.WriteBot("Exiting chatbot. Goodbye!", 10, "\u001b[34m");
                        return; // Exit the entire program
                    }

                    // Check for greetings
                    if (UserInput.ToLower() == "hello" || UserInput.ToLower() == "hi" || UserInput.ToLower() == "yoo")
                    {
                        BotToString.WriteBot("Hello, my name is sAImon, how are you doing today?", 10, "\u001b[34m");
                        greetResponse = true;
                    }
                    else
                    {
                        BotToString.WriteBot("Dummy you have to say something.", 10, "\u001b[34m");
                    }
                }

                // Adding a delay with "..." while waiting
                Thread.Sleep(1000);
                BotToString.WriteBot("...", 10, "\u001b[34m");

                bool responseReceived = false;

                // Loop for the response part of the conversation
                while (!responseReceived)
                {
                    string UserInput = Console.ReadLine();

                    // Check if the user wants to exit
                    if (UserInput.ToLower() == "bye")
                    {
                        BotToString.WriteBot("Exiting chatbot. Goodbye!", 10, "\u001b[34m");
                        return; // Exit the entire program
                    }

                    // Check how the user is doing
                    if (UserInput.ToLower() == "good" || UserInput.ToLower() == "fine" || UserInput.ToLower() == "great")
                    {
                        BotToString.WriteBot("That's great to hear!", 10, "\u001b[34m");
                        responseReceived = true;
                    }
                    else if (UserInput.ToLower() == "bad" || UserInput.ToLower() == "not good" || UserInput.ToLower() == "not well")
                    {
                        BotToString.WriteBot("I'm sorry to hear that.", 10, "\u001b[34m");
                        responseReceived = true;
                    }
                    else
                    {
                        BotToString.WriteBot("I'm sorry, I didn't catch that. How are you doing today?", 10, "\u001b[34m");
                    }
                }

                // Adding a delay with "..." while waiting
                Thread.Sleep(1000);
                BotToString.WriteBot("...", 10, "\u001b[34m");
                BotToString.WriteBot("What is your name?", 10, "\u001b[34m");

                // Loop for asking what the user's name is
                bool nameReceived = false;
                while (!nameReceived)
                {
                    
                    string UserInput = Console.ReadLine();

                    // Check if the user wants to exit
                    if (UserInput.ToLower() == "bye")
                    {
                        BotToString.WriteBot("Exiting chatbot. Goodbye!", 10, "\u001b[34m");
                        return; // Exit the entire program
                    }

                    // Check if the user has entered a name and check if the name is the nword using the CheckNWord method
                    if (UserInput.Length > 0)
                    {
                        if (BotToString.CheckNWord(UserInput))
                        {
                            BotToString.WriteBot("Sam, behave and talk to me like a decent human being...", 10, "\u001b[31m");
                        }
                        else if (UserInput.ToLower() == "sam")
                        {
                            BotToString.WriteBot("NIGGER? Thats a weird name? But sure i guess...", 10,"\u001b[34m");
                            break;
                        }
                        else
                        {
                            BotToString.WriteBot("Nice to meet you, " + UserInput + "!", 10, "\u001b[34m");
                            nameReceived = true;
                        }
                    }
                    else
                    {
                        BotToString.WriteBot("I'm sorry, I didn't catch that. Could you please tell me your name?", 10, "\u001b[34m");
                    }

                }

                // Adding a delay with "..." while waiting
                Thread.Sleep(1000);
                BotToString.WriteBot("...", 10, "\u001b[34m");
                BotToString.WriteBot("How is the weather today?", 10, "\u001b[34m");
                // loop for asking what weather the user is experiencing 
                bool weatherReceived = false;

                while (!weatherReceived)
                {
                    
                    string UserInput = Console.ReadLine();

                    // Check if the user wants to exit
                    if (UserInput.ToLower() == "bye")
                    {
                        BotToString.WriteBot("Exiting chatbot. Goodbye!", 10, "\u001b[34m");
                        return; // Exit the entire program
                    }

                    // Check if the user has entered weather
                    if (UserInput.Length > 0)
                    {
                        if (UserInput.ToLower() == "sunny" || UserInput.ToLower() == "nice")
                            BotToString.WriteBot("That's nice to hear it's " + UserInput + " today! \n Enjoy the sunshine but don't forget to wear sunscreen!", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "rainy" || UserInput.ToLower() == "cloudy" || UserInput.ToLower() == "windy")
                            BotToString.WriteBot("I'm sorry to hear it's " + UserInput + " today.", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "snowy" || UserInput.ToLower() == "hail")
                            BotToString.WriteBot("I hope you're staying warm and cozy!", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "foggy")
                            BotToString.WriteBot("Be careful while driving in the fog!", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "stormy" || UserInput.ToLower() == "hurricane")
                            BotToString.WriteBot("Stay safe and indoors!", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "thunderstorm")
                            BotToString.WriteBot("Stay safe and indoors! Don't forget to unplug your electronics!", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "tornado")
                            BotToString.WriteBot("Stay safe and indoors! Go to the basement or a small interior room!", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "bad")
                            BotToString.WriteBot("I'm sorry to hear the weather is bad.", 10, "\u001b[34m");
                        else if (UserInput.ToLower() == "apocalypse")
                            BotToString.WriteBot("RUN!!! \n ", 10, "\u001b[32m");
                      
                        weatherReceived = true;
                    }
                    else
                    {
                        BotToString.WriteBot("I'm sorry, I didn't catch that. Could you please tell me how the weather is today?", 10, "\u001b[34m");
                    }
                }
                // Ask if the user wants to restart the conversation
                BotToString.WriteBot("Do you want to restart the conversation? (yes/no)", 10, "\u001b[34m");
                string restartInput = Console.ReadLine().ToLower();

                restartConversation = restartInput == "yes";
            }
        }
    }
}
