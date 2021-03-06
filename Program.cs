﻿using System;

namespace ChoosingAnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {//SETUP
            Console.WriteLine("Choose your own adventure!");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name} to Choose your own adventure!");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            Console.WriteLine("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
                noiseChoice = noiseChoice.ToUpper();
            Console.WriteLine(noiseChoice);
        //ADDING CONDITIONAL STATEMENTS
            if(noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            }
            else if(noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You walk towards it. Do you open it or knock?");
            }

            Console.WriteLine("Type OPEN or KNOCK");
            string doorChoice = Console.ReadLine();
            doorChoice = doorChoice.ToUpper();
            Console.WriteLine(doorChoice);

            if(doorChoice == "KNOCK")
            {
             Console.WriteLine("A voice behind the door speaks. It says,\"Answer this riddle: \"");
             Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?\"");

            }
            else if(doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
            }

            Console.WriteLine("Type your answer: ");
            string riddleAnswer = Console.ReadLine();
            riddleAnswer = riddleAnswer.ToUpper();
            Console.WriteLine(riddleAnswer);

            if(riddleAnswer == "NOTHING")
            {
                Console.WriteLine("The door opens and NOTHING is there.");
                Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                Console.WriteLine("THE END.");
            }
            else
            {
                Console.WriteLine("You answered incorrectly. The door doesn't open");
                Console.WriteLine("THE END.");
            }

            Console.WriteLine("Enter a number (1-3): ");
            string keyChoice = Console.ReadLine();
       

            switch (keyChoice)
            {
                case "1":
                    Console.WriteLine("You choose the first key. Lucky choice!");
                    Console.WriteLine("The door opens and NOTHING is there. Strange...");
                    Console.WriteLine("THE END.");
                    break;
                case "2":
                    Console.WriteLine("You choose the second key. The door doesn't open.");
                    Console.WriteLine("THE END.");
                    break;
                case "3":
                    Console.WriteLine("You choose the third key. The door doesn't open.");
                    Console.WriteLine("THE END.");
                    break;
            }
            
        }
    }
} 
