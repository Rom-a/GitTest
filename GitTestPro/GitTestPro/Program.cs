﻿using System;

namespace GitTestPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Version 4.1");
            TestMethodA();
        }

        static void TestMethodA()
        {
            Console.WriteLine("Для каждой версии будем менять номер!");
            Console.WriteLine("=====================================");
        }
    }
}
