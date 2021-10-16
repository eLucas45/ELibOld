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
            ELib.NewTitle("Main Console Window");
            Console.WriteLine($"Code is live now.");
            run();
            while (ELib.AskUserIfYesOrNo("Möchten sie fortfahren?"))
            {
                run();
            }
        }
        public static void run()
        {
            Console.WriteLine("Input something (number)");
            string input = Console.ReadLine();
            if (ELib.IsConvertableToInt(input))
            {
                Console.WriteLine($"The input '{input}' can be converted to an int");
            }
            else
            {
                Console.WriteLine($"The input '{input}' can't be converted into an int");
            }
            if(ELib.UserChoosesbetween2Posibilitys("1 oder 2?????!??"))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }
        }
    }
}
