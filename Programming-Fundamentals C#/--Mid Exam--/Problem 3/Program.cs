using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> chatHistory = new List<string>();

            while (input != "end")
            {
                string[] chatCommmand = input.Split();
                string typeCommand = chatCommmand[0];

                if (typeCommand == "Chat")
                {
                    string message = chatCommmand[1];
                    chatHistory.Add(message);

                }
                else if (typeCommand == "Delete")
                {
                    string message = chatCommmand[1];
                    if (chatHistory.Contains(message))
                    {
                        chatHistory.Remove(message);
                    }
                }
                else if (typeCommand == "Edit")
                {
                    string message = chatCommmand[1];
                    string editedMessage = chatCommmand[2];
                    int indexOfMessage = -1;
                    if (chatHistory.Contains(message))
                    {
                        for (int i = 0; i < chatHistory.Count; i++)
                        {
                            if (chatHistory[i] == message)
                            {
                                indexOfMessage = i;
                                break;
                            }
                        }
                        chatHistory.RemoveAt(indexOfMessage);
                        chatHistory.Insert(indexOfMessage, editedMessage);
                    }
                }
                else if (typeCommand == "Pin")
                {
                    string message = chatCommmand[1];
                    if (chatHistory.Contains(message))
                    {
                        chatHistory.Remove(message);
                        chatHistory.Add(message);
                    }
                }
                else if (typeCommand == "Spam")
                {
                    List<string> spamedMessages = new List<string>();
                    for (int i = 1; i < chatCommmand.Length; i++)
                    {
                        spamedMessages.Add(chatCommmand[i]);
                    }
                    for (int i = 0; i < spamedMessages.Count; i++)
                    {
                        chatHistory.Add(spamedMessages[i]);
                    }
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < chatHistory.Count; i++)
            {
                Console.WriteLine(chatHistory[i]);
            }
        }
    }
}
