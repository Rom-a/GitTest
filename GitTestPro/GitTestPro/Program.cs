using System;

namespace GitTestPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Version 9.0");
            TestMethodA();
            Console.WriteLine("Test");
        }

        static void TestMethodA()
        {
            Console.WriteLine("Для каждой версии будем менять номер!");
            Console.WriteLine("=====================================");
        }
    }
}
