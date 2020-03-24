using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_OOP
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ASQ - A Short Questionaire");
            Console.WriteLine("This questionaire is made up of 20 questions");
            Questions();
        }
        public void Questions()
        {
        start:
            //a couple of lines of code that will print a couple of messages on the screen also using "Environment.NewLine" to make a line break 
            
            Console.WriteLine("Options");
            Console.WriteLine("If you would like to start the program  press 1");
            Console.WriteLine("If you would like to see instructions   press 2");
            Console.WriteLine("If you would like to see the scoreboard press 3");
            Console.WriteLine("If you would like to quit               press 4");
        input:
            //creating variable and getting a response from user
            int option = Console.Read();
            if (option == 1)
            {
                Console.WriteLine("Before you start");
                Console.WriteLine("What is your name?");
                string Name = Console.ReadLine();
                Question1();
            }

            else if (option == 2)
            {
                Console.WriteLine("All of the questions inside of the quiz have multiple-choice answers");
                Console.WriteLine("To answer each question just write down a number corresponding to a specific answer");
                Console.WriteLine("BE CAREFUL! 1 Question wrong and you have to start from the beggining.");
                Console.WriteLine("Make sure you have fun.");
                goto start;
            }
            else if (option == 3)
            {

            }
            else if (option == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("That input Is Not Valid, Try Again.");
                goto input;
            }
        }
        public void Question1()
        {

        }
        public void Question2()
        {

        }
        public void Question3()
        {

        }
        public void Question4()
        {

        }
        public void Question5()
        {

        }
        public void Question6()
        {

        }
        public void Question7()
        {

        }
        public void Question8()
        {

        }
        public void Question9()
        {

        }
        public void Question10()
        {

        }
        public void Question11()
        {

        }
        public void Question12()
        {

        }
        public void Question13()
        {

        }
        public void Question14()
        {

        }
        public void Question15()
        {

        }
        public void Question16()
        {

        }
        public void Question17()
        {

        }
        public void Question18()
        {

        }
        public void Question19()
        {


        }
        public void Question20()
        {

        }
    }

}
