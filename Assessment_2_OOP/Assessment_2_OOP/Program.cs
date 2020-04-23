using System;
using System.IO;

namespace Assessment_2_OOP
{
    class Program
    {   
        //a couple of variables that I am going to use throughout the program, and I have added one variable to make NewLine(to simplify command and to reduce amount of repetition of long command)
        public string NewLine = Environment.NewLine;
        public string answer;
        
        static void Main(string[] args)
        {
            //local variable made and some lines of code asking what the user wants to do and a bit of code telling the user what the program is then going to function CheckFiles()
            Program p = new Program();
            Console.WriteLine("Welcome to File checker");
            p.CheckFiles();
            
        }

        public void CheckFiles()
        //this is checking for user input, if it is a "yes" it will check if the files are the same, if it is "no" it will quit.
        {
            Console.WriteLine("Would you like to start the program?" + NewLine);
            Console.WriteLine("Options");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            answer = Console.ReadLine();
            if (answer == "Yes")
            {
                CheckingFiles();
            }
            else if (answer == "yes")
            {
                CheckingFiles();
            }
            else if (answer == "No")
            {
                return;
            }
            else if (answer == "no")
            {
                return;
            }
            else
            {
                Console.WriteLine("Incorrect Input, " + NewLine + "try again." + NewLine);
                CheckFiles();
            }
        }
        public void CheckingFiles()
        {
            // some variables with txt files and then the code checking if they are the same and outputs it to the user then loops back to function CheckFiles()
            string GitRespositories_1a = System.IO.File.ReadAllText("\\GitRepositories_7a.txt"); 
            string GitRespositroeis_1b = System.IO.File.ReadAllText("GitRepositories_1b.txt");
            string GitRespositroeis_2a = System.IO.File.ReadAllText("GitRepositories_2a.txt");
            string GitRespositroeis_2b = System.IO.File.ReadAllText("GitRepositories_2b.txt");
            string GitRespositroeis_3a = System.IO.File.ReadAllText("GitRepositories_3a.txt");
            string GitRespositroeis_3b = System.IO.File.ReadAllText("GitRepositories_3b.txt");
            if(string.Equals(GitRespositories_1a, GitRespositroeis_1b))

            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are different");
            }
            if (string.Equals(GitRespositroeis_2a, GitRespositroeis_2b))
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are different");
            }
            if (string.Equals(GitRespositroeis_3a, GitRespositroeis_3b))
            {
                Console.WriteLine("GitRepositories_3a and GitRepositories_3b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_3a and GitRepositories_3b are different"  + NewLine);
            }
            CheckFiles();
        }
        
    }

}
