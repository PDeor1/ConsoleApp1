using System;

namespace ConsoleApp1
{
    class Program
    {
        private static string _strTest;
        
        static void Main(string[] args)
        {
            TestClass obj = new TestClass();
            obj.iCount = 100000;
            obj.sName = "SOmething tessssssssssssssssssssssssssssssssssssssssssssss";
            _strTest = "yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy";
            Console.WriteLine("Hello World!");
        }
    }

    class  TestClass
    {
        public int iCount;
        public string sName;
    }
}
