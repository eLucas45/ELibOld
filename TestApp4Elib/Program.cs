using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELibCode;

namespace TestApp4Elib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Main Window";
            ELib.Init(true);
            Console.WriteLine($"Code runs now.");
            Console.ReadKey();
            while (ELib.AskUserIfYesOrNo(""))
            {

            }
        }
        public static void run()
        {

        }
    }
}
