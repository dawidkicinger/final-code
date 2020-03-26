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
            //local variable made and some lines of code asking what the user wants to do
            Program p = new Program();
            Console.WriteLine("Welcome to File checker");
            p.CheckFiles();
            
        }

        public void CheckFiles()
        //this is checking for files, comparing them and then letting the user know if they are the same or different
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
        }
        public void CheckingFiles()
        {
            string file1 = File.ReadAllText(@"GitRepositories_1a.txt"); 
            string file2 = File.ReadAllText(@"GitRepositories_1b.txt");
            string file3 = File.ReadAllText(@"GitRepositories_2a.txt");
            string file4 = File.ReadAllText(@"GitRepositories_2b.txt");
            string file5 = File.ReadAllText(@"GitRepositories_3a.txt");
            string file6 = File.ReadAllText(@"GitRepositories_3b.txt");
            if(string.Equals(file1, file2))
            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are different");
            }
            if (string.Equals(file3, file4))
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are different");
            }
            if (string.Equals(file5, file6))
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
