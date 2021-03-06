﻿using System;
using System.Collections.Generic;


/**
    Task: •	Change by places first and last letters in each second string of list or array 
*/

namespace LettersSwapper
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            ConsoleUI.Run();
        }

        //Runs ui
        public static void Run()
        {
            List<string> listOfStrings = new List<string>();    //list of strings, for swapping
            Console.WriteLine("Type strings for swapping ('stop' - will stop typing).");
            
            //loop for strings input
            while (true)
            {
                string typedString = Console.ReadLine();

                if (typedString.Equals("stop"))
                {
                    break;
                }
                else
                    listOfStrings.Add(typedString);
            }

            Console.WriteLine("\nSwapper will swap first&last chars in every 2-nd string.");
            if (Swapper.StartSwapping(listOfStrings))
                printList(listOfStrings);
            else
                Console.WriteLine("String size must be > 2!");
            
        }

        //Prints list of pasted string on the screen
        public static void printList(List<string> list)
        {
            Console.WriteLine("\nList:");
            foreach(string str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}
