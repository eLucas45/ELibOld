using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Code by limited-dev (c) 2021

/*
 * This Code is not very good, but it'll do the job for now.
 * Will rework it someday (hopefully).
 */
namespace ELibCode
{
    public class ELib
    {
        private static bool Initd = false;
        private static bool disDebugInfo;
        /// <summary>
        /// Inits the Lib (Run @ startup of your program)
        /// </summary>
        /// <param name="enableDebugInfo"></param>
        public static void Init(bool enableDebugInfo)
        {
            // ---- Inits the lib ----
            Initd = true;
            Console.Write($"ELib init.");
            Console.Title = $"{Console.Title} using ELib";
            Console.Write($".");
            Console.Write($".");
            if (enableDebugInfo)
            {
                disDebugInfo = true;
            }
            Console.Write($".");
            Console.Write($". Done\n");
            if (enableDebugInfo)
            {
                Console.WriteLine($"[Debug] disDebugInfo = {disDebugInfo}");
                Console.WriteLine($"ELib will display Debug Output in the console.");
            }
            Console.WriteLine($"\nThis Program is using ELibCode\n(c) limited_dev 2021");
            Thread.Sleep(1100);
            Console.WriteLine($"Clearing...");
            Thread.Sleep(200);
            Console.Clear();
        }

        /// <summary>
        /// Asks the user a yes / no question. //TODO: Do a better explaination.
        /// </summary>
        /// <param name="method"></param>
        public static bool AskUserIfYesOrNo(string question)
        {
            if (Initd)
            {
                string[] allowedInput = { "Y", "N", "Yes", "No", "Ja", "Nein", "J", "n", "j", "y", "ja", "nein", "yes", "no" };
                string[] YesInput = { "Y", "Yes", "Ja", "J", "j", "y", "ja", "yes" };
                Console.Write($"\n{question} [Y/N]: ");
                var key = Console.ReadLine();
                Console.WriteLine("");
                bool iscorrect = false;
                while (!iscorrect)
                {
                    for (int i = 0; i < allowedInput.Length; i++)
                    {
                        if (key == allowedInput[i])
                        {
                            iscorrect = true;
                            if (disDebugInfo)
                            {
                                Console.WriteLine($"[Debug]: {iscorrect}(iscorrect) | {key} input | {allowedInput[i]} allowedSymbol");
                            }
                            break;
                        }
                        if (disDebugInfo)
                        {
                            Console.WriteLine($"[Debug]: {iscorrect}(iscorrect) | {key} input | {allowedInput[i]} allowedSymbol");
                        }
                    }
                    if (!iscorrect)
                    {
                        Console.Write($"Bitte benutzte nur [Y/N] | Please use [Y/N] \n{question} [Y/N]: ");
                        key = Console.ReadLine();
                        Console.WriteLine("");
                    }
                }
                return ContinueCheck(key, YesInput);
            }
            return false;
        }
        public static bool ContinueCheck(String key, string[] YesInput)
        {
            bool revalue = false;
            for (int i = 0; i < YesInput.Length; i++)
            {
                if (key == YesInput[i])
                {
                    if (disDebugInfo)
                    {
                        Console.WriteLine($"[Debug]: {key} input | {YesInput[i]} allowedSymbol");
                    }
                    revalue = true;
                    break;
                }
                else
                {
                    if (disDebugInfo)
                    {
                        Console.WriteLine($"[Debug]: {key} input | {YesInput[i]} allowedSymbol");
                    }
                    revalue = false;
                }
            }
            return revalue;
        }
        /// <summary>
        /// Gets special type of Symbol from the user
        /// </summary>
        /// <param name="Question"></param>
        /// <param name="allowedSymbols"></param>
        /// <returns></returns>
        public static string getSym(string Question, string[] allowedSymbols)
        {
            Console.Write($"{Question}: ");
            String input = Console.ReadLine();
            bool iscorrect = false;
            while (!iscorrect)
            {
                for (int i = 0; i < allowedSymbols.Length; i++)
                {
                    if (input == allowedSymbols[i])
                    {
                        iscorrect = true;
                        if (disDebugInfo)
                        {
                            Console.WriteLine($"[Debug]: {iscorrect}(iscorrect) | {input} input | {allowedSymbols[i]} allowedSymbol");
                        }
                        break;
                    }
                    if (disDebugInfo)
                    {
                        Console.WriteLine($"[Debug]: {iscorrect}(iscorrect) | {input} input | {allowedSymbols[i]} allowedSymbol");
                    }
                }
                if (!iscorrect)
                {
                    Console.Write($"{Question}: ");
                    input = Console.ReadLine();
                }
            }
            return input;
        }
        /// <summary>
        /// Requests & gets a number (long) from the user
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public static long getLong(string Question)
        {
            Console.Write($"{Question}: ");
            String input = Console.ReadLine(); //lol why didn't I think of that earlier
            while (!IsConvertableToLong(input))
            {
                input = Console.ReadLine();
            }
            return long.Parse(input);
        }
        /// <summary>
        /// Requests & gets a number (int) from the user
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public static int getInt(string Question)
        {
            Console.Write($"{Question}: ");
            String input = Console.ReadLine(); //lol why didn't I think of that earlier
            while (!IsConvertableToInt(input))
            {
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
        /// <summary>
        /// Checks if a String / User input can be converted to an int32
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsConvertableToInt(string input)
        {
            if (int.TryParse(input, out _))
                return true;
            else return false;
        }
        /// <summary>
        /// Checks if a String / User input can be converted to an int64
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsConvertableToLong(string input)
        {
            if (long.TryParse(input, out _))
                return true;
            else return false;
        }
        /// <summary>
        /// Gets any type of string from the user
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public static string getString(string Question)
        {
            Console.Write($"{Question}: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// returns the current Unix time
        /// </summary>
        /// <returns></returns>
        public static long getUnixTime()
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
        /// <summary>
        /// Calculates the result of 2 nums. Returns 0 if not possible
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputMathSymbol"></param>
        /// <returns></returns>
        public static double CalculateTwoNum(double[] input, string inputMathSymbol)
        {
            long timebeforecalc = 0;
            if (disDebugInfo)
            {
                timebeforecalc = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            double result = 0;
            switch (inputMathSymbol)
            {
                case "+":
                    result = input[0] + input[1];
                    break;
                case "-":
                    result = input[0] - input[1];
                    break;
                case "*":
                    result = input[0] * input[1];
                    break;
                case "/":
                    result = input[0] / input[1];
                    break;
                case "x":
                    result = input[0] * input[1];
                    break;
                case ":":
                    result = input[0] / input[1];
                    break;
                case "Pow": //case "Pow":
                    result = Math.Pow(input[0], input[1]);
                    break;
                case "^":
                    result = Math.Pow(input[0], input[1]);
                    break;
                default:
                    break;

            }
            if (disDebugInfo)
            {
                long time2calc = DateTimeOffset.Now.ToUnixTimeMilliseconds() - timebeforecalc;
                Console.WriteLine($"It took {time2calc}ms to calculate this.");
            }
                return result;
        }
        /// <summary>
        /// Makes the User choose between 1 and 2, returns true (for 1) and false (for 2)
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public static bool UserChoosesbetween2Posibilitys(string Question)
        {
            string[] possibleInputs = { "1", "2" };
            string firstWay = "1";
            Console.Write($"\n{Question} [1/2]: ");
            var key = Console.ReadLine();
            Console.WriteLine("");
            bool iscorrect = false;
            while (!iscorrect)
            {
                for (int i = 0; i < possibleInputs.Length; i++)
                {
                    if (key == possibleInputs[i])
                    {
                        iscorrect = true;
                        if (disDebugInfo)
                        {
                            Console.WriteLine($"[Debug]: {iscorrect}(iscorrect) | {key} input | {possibleInputs[i]} allowedSymbol");
                        }
                        break;
                    }
                    if (disDebugInfo)
                    {
                        Console.WriteLine($"[Debug]: {iscorrect}(iscorrect) | {key} input | {possibleInputs[i]} allowedSymbol");
                    }
                }
                if (!iscorrect)
                {
                    Console.Write($"Bitte benutzte nur [1/2] | Please use [1/2]\n{Question} [1/2]: ");
                    key = Console.ReadLine();
                    Console.WriteLine("");
                }
            }
            return Way2(key, firstWay);
        }
        public static bool Way2(string key, string twoWay)
        {
            bool revalue = false;
            if (key == twoWay)
            {
                revalue = true;
            }
            return revalue;
        }

        public static void NewTitle(string title)
        {
            Console.Title = $"{title} using ELib";
        }
    }
}