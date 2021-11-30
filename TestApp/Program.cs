using System;
using ELibCode;

namespace TestApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ELib.Init(true, true, "English");
            Console.ReadKey();
        }
    }
}