﻿using System;

namespace GitTestPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Version 10.0");
            TestMethodA();
        }

        static void TestMethodA()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Для каждой версии будем менять номер!");
            Console.WriteLine("=====================================");
        }
    }
}
