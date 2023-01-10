using System;
using System.Threading;

namespace Fibonacci{
    class Program{
        static void Main(string[] args){
            

            //Pluging creator/me
            Console.WriteLine("Fibonacci Number Checker");
            Console.WriteLine("v1.0");
            Console.WriteLine("By: Joseph Lavoie");
            Console.WriteLine("https://github.com/Vadenez");

            FibonacciAnswers();
        }
        static void FibonacciAnswers(){

            //Create variables, for holding Fibonacci numbers and its location
            long TwoBefore = 0, OneBefore = 1, CurrentNum = 1, CurrentNumPlace = 3, UsersNumber;
            //create a short to store the User's answer to questions
            short option;

            Console.WriteLine(" ");

            //informing the User what it's choice will do
            Console.WriteLine("Would you like to find what number is in your place [Option 1]?,");
            Console.WriteLine("What place holds your number in the \'Fibonacci Sequence\' [Option 2]?,");
            Console.WriteLine("Or just a Fibonacci list from 0 to about 7.5 Quintillion [Option 3]?");
            Console.WriteLine("Type 1 for Option 1 || Type 2 for Option 2 || Type 3 for Option 3 || or 404 to Exit.");

            //Making sure the User answers with one of the 4 answers
            while (true){
                option = Convert.ToInt16(Console.ReadLine());

                if (option == 1 || option == 2 || option == 3){break;}

                //End program if the User decides to
                else if (option == 404){End();}

                Console.WriteLine("Type 1 for Option 1 || Type 2 for Option 2 || Type 3 for Option 3 || or 404 to Exit.");
            }

            //information incase the User doesn't understand the basic pattern of Fibonacci
            Console.WriteLine("Fibonacci starts with: 0, 1, 1, 2, 3, 5, etc...");

            //Asking a question or just giving Fibonacci numbers based on the User's last choice
            if (option == 1){
                Console.WriteLine("So how many numbers in do you want to go?");
                UsersNumber = Convert.ToInt64(Console.ReadLine());
            }
            else if (option == 2){
                Console.WriteLine("So what number do you want to check, if and where it\'s in Fibonacci.");
                UsersNumber = Convert.ToInt64(Console.ReadLine());
            }
            else{
                Console.WriteLine("And the list starts:");
                Console.WriteLine("Current Number: 0 | It's Place: 1.");
                Console.WriteLine("Current Number: 1 | It's Place: 2.");
                UsersNumber = 0;
            }

            //Running through The Fibonacci Sequence based on "UsersNumber" and their "option"
            while (true){
                CurrentNum = TwoBefore + OneBefore;

                if (option == 1 && UsersNumber == 1){
                    Console.WriteLine("In the 1st place of Fibonacci the number is 0.");
                    break;
                }
                else if (option == 1 && UsersNumber == 2){
                    Console.WriteLine("In the 2nd place of Fibonacci the number is 1.");
                    break;
                }
                else if (option == 2 && UsersNumber == 0){
                    Console.WriteLine("Your number, being 0, is in the 1st place of Fibonacci.");
                    break;
                }
                else if (option == 2 && UsersNumber == 1){
                    Console.WriteLine("Your number, being 1, is in the 2nd and 3rd place of Fibonacci.");
                    break;
                }

                if (option == 1 && CurrentNumPlace == UsersNumber){
                    Console.WriteLine("In the {0}th place of Fibonacci the number is {1}.", UsersNumber, CurrentNum);
                    break;
                }
                else if (option == 2 && CurrentNum == UsersNumber){
                    Console.WriteLine("Your number, being {0}, is in the {1}th place of Fibonacci.", UsersNumber, CurrentNumPlace);
                    break;
                }
                else if (option == 2 && CurrentNum > UsersNumber){
                    Console.WriteLine("Your number, being {0}, is not in Fibonacci.", UsersNumber);
                    Console.WriteLine("The closest numbers to your number is {0} and {1}.", OneBefore, CurrentNum);
                    Console.WriteLine("Those two numbers being place at {0} and {1} respectivily in the \'Fibonacci Sequence.\'", CurrentNumPlace-1, CurrentNumPlace);
                    break;
                }
                else if (option == 3){
                    Console.WriteLine("Current Number: {0} | It's Place: {1}.", CurrentNum, CurrentNumPlace);
                }
                //This specific number is used to prevent going over the LONG or INT64 number limit
                if (option == 3 && CurrentNum > 7500000000000000000){
                    Console.WriteLine("Done.");
                    break;
                }

                CurrentNumPlace++;
                TwoBefore = OneBefore;
                OneBefore = CurrentNum;
            }

            Console.WriteLine(" ");

            //Getting User input to either end or rerun the program
            Console.WriteLine("Whould you like to run this program again [Option 1], or Exit [Option 2].");
            Console.WriteLine("Type 1 for Option 1 || Type anything other then \'1\' for Option 2.");

            option = Convert.ToInt16(Console.ReadLine());

            //Rerun program
            if (option == 1)
                FibonacciAnswers();
            //End program
            else{End();}
        }
        static void End(){
            Console.WriteLine("Goodbye");

            //Short delay, of 1.5 sec, so "Goodbye" is readable
            Thread.Sleep(1500);
            
            return;
        }
    }
}
