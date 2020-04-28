using System;

namespace Test_Libary
{
    public class TestsMethods : ITest
    {
        public void Simple_ConsoleWrite(string Args)
        {
            Console.WriteLine(string.Format("I have written :", Args));
        }
    }
}
