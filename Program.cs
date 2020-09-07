using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name;
            name = Console.ReadLine();
            
            Console.WriteLine("Hello, " + name);

            Console.WriteLine("How old are you");
                
            string Userinput;
            
          Userinput = Console.ReadLine();
            int YearOfBirth;



                YearOfBirth = Int32.Parse(Userinput);
            int age = -YearOfBirth + 2020;


                Console.WriteLine("You were born in " + age + "old.");
        }
    }
}
