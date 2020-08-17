using System;
/* I would describe syntactic sugar as writing code in a way that makes thing easier, shorter or in other terms sweet*/
namespace optionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            BuddySaid("Henry", "I overcomplicated this in my head so much");
            Console.ReadLine();
        }
        //This code that is commented out is number one of Exercise 2B-C# 03 - Optional Parameters. Underneath that is the number two. Number three is above the namespace. 

        //public static void BuddySaid(string name = "Enrique", string statement = "'I hope i'm doing this right'")
        //{
        //    Console.WriteLine($"My buddy {name} said {statement}");
        //}
        public static void BuddySaid(string name, string statement)
        {
            Console.WriteLine($"My buddy {name} said {statement}!");
        }
        public static void BuddySaid(string name)
        {
            BuddySaid(name, "you're doing great");
        }
        public static void BuddySaid()
        {
            BuddySaid("Enrique");
        }
    }
}
