using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

        // Task 10: 
        //Create a program(game) Guess the number.
        //The game should be a Console application.
        //Game rules are for limited tries to guess the number that is randomly generated between two end points.

        //When the game start it should ask the user for difficulty.
        //- Easy
        //- In easy mode user should have 9 tries to guess the number between 0 - 100.
        //- Normal
        //- In normal mode user should have 7 tries to guess the number between 0 - 500.
        //- Hard
        //- In hard mode user should have 5 tries to guess the number between 0 - 1000.

        //Every guess should give the user hint if it is close and also should display the number that the user last entered.
        //Example:
        //If the number that should be guessed is 10 and the user enters 18 it should print out "Your guess is far to high, number entered: 18".
        //If the number that should be guessed is 10 and the user enters 2 it should print out "Your guess is far to low, number entered: 2".
        //If the number that should be guessed is 10 and the user enters 7 it should print out "Your guess is a little bit lower, number entered: 7".
        //If the number that should be guessed is 10 and the user enters 13 it should print out "Your guess is a little bit higher, number entered: 13".
        //If the number that should be guessed is 10 and the user enters 10 it should print out "Nailed it. number entered: 10".
        //You can add your kind of notifications if you like.

        //Based on how fast the user guessed the number it should display a proper title and the number that should be guessed.
        //Example:
        //If user nails it on the first try it should print out "Lucky guess.".
        //If user did not guess the number it should print out "Try again".

        //Optional: Give the user a chance to restart the game(ex Press 1 to start a new game, press 2 to quit game) without starting the project from scratch.




            int counter = 0;
            var computer = new Random();
            string high = "Your guess is far to high, number entered: ";
            string low = "Your guess is far to low, number entered: ";
            string littleBitLower = "Your guess is a little bit lower, number entered: ";
            string littleBithigher = "Your guess is a little bit higher, number entered: ";
            string NailedIt = "Nailed it! Number entered: ";
            
            Console.WriteLine("Choose your Difficuulty Player! Easy, Medium, Hard: ");
            var difficulty = Console.ReadLine().ToLower();
            if (difficulty == "easy")
            {
                int computerEasy = computer.Next(0, 100);
                while (counter <= 9)
                {
                    Console.WriteLine("Enter number your number: ");
                    int.TryParse(Console.ReadLine(), out int choice);
                    if (computerEasy == choice)
                    {
                        if (counter == 0)
                        {
                            Console.WriteLine($"You entered {choice} \nLucky guess.");
                            break;
                        }
                        else { Console.WriteLine(NailedIt + choice); break; }
                    }
                    if (computerEasy < choice)
                    {
                        if (computerEasy + 3 >= choice || computerEasy + 2 >= choice || computerEasy + 1 >= choice || computerEasy - 3 >= choice || computerEasy - 2 >= choice || computerEasy - 1 >= choice)
                        {
                            Console.WriteLine(littleBithigher + choice);
                        }
                        else if (computerEasy > choice) { Console.WriteLine(high + choice); }
                    }
                    if (computerEasy > choice)
                    {
                        if (computerEasy + 3 <= choice || computerEasy + 2 <= choice || computerEasy + 1 <= choice || computerEasy - 3 <= choice || computerEasy - 2 <= choice || computerEasy - 1 <= choice)
                        {
                            Console.WriteLine(littleBitLower + choice);
                        }
                        else if (computerEasy > choice) { Console.WriteLine(low + choice); }
                    }
                    else { Console.WriteLine($"Your guess is {choice}. Try again"); }
                    counter++;
                }
            }

            if (difficulty == "medium")
            {
                int computerMedium = computer.Next(0, 500);
                while (counter <= 7)
                {
                    Console.WriteLine("Enter number");
                    int.TryParse(Console.ReadLine(), out int choice);
                    if (computerMedium == choice)
                    {
                        if (counter == 0)
                        {
                            Console.WriteLine($"You entered {choice} \nLucky guess.");
                            break;
                        }
                        else { Console.WriteLine(NailedIt + choice); break; }
                    }
                    if (computerMedium < choice)
                    {
                        if (computerMedium + 3 >= choice || computerMedium + 2 >= choice || computerMedium + 1 >= choice || computerMedium - 3 >= choice || computerMedium - 2 >= choice || computerMedium - 1 >= choice)
                        {
                            Console.WriteLine(littleBithigher + choice);
                        }
                        else if (computerMedium > choice) { Console.WriteLine(high + choice); }
                    }
                    if (computerMedium > choice)
                    {
                        if (computerMedium + 3 <= choice || computerMedium + 2 <= choice || computerMedium + 1 <= choice || computerMedium - 3 <= choice || computerMedium - 2 <= choice || computerMedium - 1 <= choice)
                        {
                            Console.WriteLine(littleBitLower + choice);
                        }
                        else if (computerMedium > choice) { Console.WriteLine(low + choice); }
                    }
                    else { Console.WriteLine($"Your guess is {choice}. Try again"); }
                    counter++;
                }
            }

            if (difficulty == "hard")
            {
                int computerHard = computer.Next(0, 1000);
                while (counter <= 5)
                {
                    Console.WriteLine("Enter number");
                    int.TryParse(Console.ReadLine(), out int choice);
                    if (computerHard == choice)
                    {
                        if (counter == 0)
                        {
                            Console.WriteLine($"You entered {choice} \nLucky guess.");
                            break;
                        }
                        else { Console.WriteLine(NailedIt + choice); break; }
                    }
                    if (computerHard < choice)
                    {
                        if (computerHard + 3 >= choice || computerHard + 2 >= choice || computerHard + 1 >= choice || computerHard - 3 >= choice || computerHard - 2 >= choice || computerHard - 1 >= choice)
                        {
                            Console.WriteLine(littleBithigher + choice);
                        }
                        else if (computerHard > choice) { Console.WriteLine(high + choice); }
                    }
                    if (computerHard > choice)
                    {
                        if (computerHard + 3 <= choice || computerHard + 2 <= choice || computerHard + 1 <= choice || computerHard - 3 <= choice || computerHard - 2 <= choice || computerHard - 1 <= choice)
                        {
                            Console.WriteLine(littleBitLower + choice);
                        }
                        else if (computerHard > choice) { Console.WriteLine(low + choice); }
                    }
                    else { Console.WriteLine($"Your guess is {choice}. Try again"); }
                    counter++;
                }
            }            
            Console.Read();
        }
    }
}



























