using System;

namespace Test_Libary
{
    public class TestsMethods : ITest
    {
        public static void Simple_ConsoleWrite1()
        {
            Console.WriteLine(string.Format("I have written : {0}", 1));
        }

        public static void Simple_ConsoleWrite2()
        {
            Console.WriteLine(string.Format("I have written : {0}", 2));
        }

        public static void Simple_ConsoleWrite3()
        {
            Console.WriteLine(string.Format("I have written : {0}", 3));
        }

        public static void Simple_ConsoleWrite4()
        {
            Console.WriteLine(string.Format("I have written : {0}", 4));
        }

        public static void Count_to_1000()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(string.Format("I have written : {0}", i));
            }
        }

        public static void Simple_ConsoleWrite(string s)
        {
            Console.WriteLine(string.Format("I have written : {0}", s));
        }

        public static void Increment(int i)
        {
            int j = i + 1;
            Console.WriteLine(string.Format("I have Incremented : {0} -> {1}", i ,j));
        }

        public static void Add_Two_Ints(int i, int j)
        {
            int k = i + j;
            Console.WriteLine(string.Format("I have added : {0} + {1} -> {2}", i, j, k));
        }



        public void Testclass()
        { 
        
        }
    }
}
