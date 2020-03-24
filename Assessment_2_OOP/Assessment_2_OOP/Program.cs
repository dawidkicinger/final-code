using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_OOP
{
    class Program
    {
        public string option;
        public string Name;
        public int score;
        public string answer;
        
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Welcome to ASQ - A Short Questionaire");
            Console.WriteLine("This questionaire is made up of 20 questions");
            p.Questions();
        }
        public void Questions()
        {
            score = 0;
        start:
            //a couple of lines of code that will print a couple of messages on the screen
            
            Console.WriteLine("Options");
            Console.WriteLine("If you would like to start the program       press 1");
            Console.WriteLine("If you would like to see instructions        press 2");
            Console.WriteLine("If you would like to see the scoreboard      press 3");
            Console.WriteLine("If you would like to quit                    press 4");
            option = Console.ReadLine();
        input:
            //creating variable and getting a response from user
            
            if (option == "1")
            {
                Console.WriteLine("Before you start");
                Console.WriteLine("What is your name?");
                Name = Console.ReadLine();
                Question1();
            }

            else if (option == "2")
            {
                Console.WriteLine("To answer each question just write down a number corresponding to a specific answer");
                Console.WriteLine("BE CAREFUL! 1 Question wrong and you have to start from the beggining.");
                Console.WriteLine("Make sure you have fun.");
                goto start;
            }
            else if (option == "3")
            {

            }
            else if (option == "4")
            {
                Questions();
            }
            else
            {
                Console.WriteLine("That input Is Not Valid, Try Again. ");
                goto input;
            }
        }
        public void Question1()
        {
            
            Console.WriteLine("What is 19+21");
            answer = Console.ReadLine();
            if (answer == "40")
            {
                score = +1;
                Question2();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
            
        }
        public void Question2()
        {
            Console.WriteLine("What is pi to 4 decimal places");
            answer = Console.ReadLine();
            if (answer == "3.1415")
            {
                score = +1;
                Question3();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }

        }
        public void Question3()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Question4();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Question4()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Question5();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Question5()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Question6();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Question6()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Question7();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Question7()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Question8();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Question8()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Question9();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Question9()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Question10();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Question10()
        {
            Console.WriteLine("");
            answer = Console.ReadLine();
            if (answer == "")
            {
                score = +1;
                Congratulations();
            }
            else
            {
                Console.WriteLine("Answer incorrect your final score is " + score);
                Questions();
            }
        }
        public void Congratulations()
        {
            Console.WriteLine("Congratulations, you have completed the quiz with " + score + "points");
            Questions();
        }
    }

}
