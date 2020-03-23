using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_OOP
{
    class Program
    {
        //implementing variable to make new line break everytime, to make getting a break easier and faster
        public string NewLine = Environment.NewLine;
        static void Main(string[] args)
        {
        start:
            //a couple of lines of code that will print a couple of messages on the screen also variable "NewLine" is used to make a line break 
            Console.WriteLine("Welcome to ASQ - A Short Questionaire");
            Console.WriteLine("This questionaire is made up of 20 questions" + NewLine);
            Console.WriteLine("If you would like to start the program press 1");
            Console.WriteLine("If you would like to see instructions press 2");
            Console.WriteLine("If you would like to quit press 3");
        input:
            //creating variable and getting a response from user
            int option = Console.Read();
            if (option == 1)
            {
                Question1();
            }
            else if (option == 2)
            {
                Console.WriteLine("");
                goto start;
            }
            else if (option == 3)
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
