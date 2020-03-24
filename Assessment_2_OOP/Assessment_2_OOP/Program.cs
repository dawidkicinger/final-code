using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_OOP
{
    class Program
    {   
        public string NewLine = Environment.NewLine;
        public string option;
        public string Name;
        public int score;
        public string answer;
        
        static void Main(string[] args)
        {   
            
            Program p = new Program();
            Console.WriteLine("Welcome to ASQ - A Short Questionaire");
            Console.WriteLine("This questionaire is made up of 20 questions");
            Console.WriteLine("Questionaire Made By: Dawid Kicinger");
            p.Questions();
        }
        public void Questions()
        {
            score = 0;
        start:
            //a couple of lines of code that will print a couple of messages on the screen
            
            Console.WriteLine(NewLine + "Options" + NewLine + "Make sure to press enter after you have chosen the number (every time)");
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
                Console.WriteLine("This is a multiple choice questionaire.");
                Console.WriteLine("Make sure you have fun." + NewLine);
                goto start;
            }
            else if (option == "3")
            {

            }
            else if (option == "4")
            {
                return;
            }
            else
            {
                Console.WriteLine("That input Is Not Valid, Try Again. ");
                goto input;
            }
        }
        public void Question1()
        {
            
            Console.WriteLine("What is 19+21?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("39");
            Console.WriteLine("40");
            Console.WriteLine("50");
            Console.WriteLine("49");
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
            Console.WriteLine("What is pi to 4 decimal places?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("3.1415");
            Console.WriteLine("3.1514");
            Console.WriteLine("3.1417");
            Console.WriteLine("3.1517");
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
            Console.WriteLine("In what city in England can you find home of George Boole?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("Boston");
            Console.WriteLine("Manchester");
            Console.WriteLine("London");
            Console.WriteLine("Lincoln");
            answer = Console.ReadLine();
            if (answer == "Lincoln")
            {
                score = +1;
                Question4();
            }
            else if (answer == "lincoln")
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
            Console.WriteLine("In what year did Princess Diana die?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("1996");
            Console.WriteLine("1997");
            Console.WriteLine("1998");
            Console.WriteLine("1999");
            answer = Console.ReadLine();
            if (answer == "1997")
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
            Console.WriteLine("What is the most fractured human bone?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("Brain");
            Console.WriteLine("Clavicle");
            Console.WriteLine("Finger");
            Console.WriteLine("Mandible");
            answer = Console.ReadLine();
            if (answer == "Clavicle")
            {
                score = +1;
                Question6();
            }
            else if (answer == "clavicle")
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
            Console.WriteLine("What is the National Symbol of Poland?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("White and Red");
            Console.WriteLine("Hawk");
            Console.WriteLine("Bear");
            Console.WriteLine("Eagle");

            answer = Console.ReadLine();
            if (answer == "Eagle")
            {
                score = +1;
                Question7();
            }
            else if (answer == "eagle")
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
            Console.WriteLine("What is Japanese sake made from" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("Pasta");
            Console.WriteLine("Noodles");
            Console.WriteLine("Rice");
            Console.WriteLine("Salad");
            answer = Console.ReadLine();
            if (answer == "Rice")
            {
                score = +1;
                Question8();
            }
            else if (answer == "rice")
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
            Console.WriteLine("What is the real meaning of the Greek word 'Pita'" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("Cake");
            Console.WriteLine("Bread");
            Console.WriteLine("Wheat");
            Console.WriteLine("Kebab");
            answer = Console.ReadLine();
            if (answer == "Bread")
            {
                score = +1;
                Question9();
            }
            else if (answer == "bread")
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
            Console.WriteLine("What country does the Peroni beer originate from?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("Italy");
            Console.WriteLine("Poland");
            Console.WriteLine("England");
            Console.WriteLine("Bulgaria");
            answer = Console.ReadLine();
            if (answer == "Italy")
            {
                score = +1;
                Question10();
            }
            else if (answer == "italy")
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
            Console.WriteLine("What is First Name of the creator of this quiz?" + NewLine);
            Console.WriteLine("Options" + NewLine);
            Console.WriteLine("Dawid");
            Console.WriteLine("David");
            Console.WriteLine("Kicinger");
            Console.WriteLine("Kissinger");
            answer = Console.ReadLine();
            if (answer == "Dawid")
            {
                score = +1;
                Congratulations();
            }
            else if (answer == "dawid")
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
