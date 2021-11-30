using System;
using System.ComponentModel.Design.Serialization;
using System.Threading;

// ReSharper disable once CheckNamespace
namespace ELibCode
{
    public static class ELib
    {
        private static bool _debugOut = false;
        private static string _language;
        private static bool _debugCode = false;
        private static bool _initd = false;
        public static void Init(bool debugCode, bool enableDebugOutput, string outputLanguage)
        {
            _initd = true;
            _debugOut = enableDebugOutput;
            _language = outputLanguage;
            Console.WriteLine($"Different languages aren't supported yet.\n" +
                              $"Init  Args: debugCode: {debugCode}, enableDebugOutput: {enableDebugOutput}, language: {_language}");
            Console.WriteLine(!enableDebugOutput
                ? "Debug output will not be displayed."
                : "Debug output will be displayed.");
            Console.WriteLine("ELibCode by limited-dev. (c) 2021 limited-dev.de");
            Thread.Sleep(2000);
            if (!debugCode)
            {
                Console.Clear();
            }
        }

        /// <summary>
        /// Asks the user a yes / no question. //TODO: Do a better explaination.
        /// </summary>
        /// <param name="method"></param>
        public static bool AskUserIfYesOrNo(string question)
        {
            if (!_initd) return false;
            string[] allowedInput = { "Y", "N", "Yes", "No", "Ja", "Nein", "J", "n", "j", "y", "ja", "nein", "yes", "no" };
            string[] yesInput = { "Y", "Yes", "Ja", "J", "j", "y", "ja", "yes" };
            Console.Write($"\n{question} [Y/N]: ");
            var key = Console.ReadLine();
            Console.WriteLine("");
            // ReSharper disable once IdentifierTypo
            bool iscorrect = false;
            while (!iscorrect)
            {
                foreach (var allowed in allowedInput)
                {
                    if (key == allowed)
                    {
                        iscorrect = true;
                        if (_debugOut)
                        {
                            // ReSharper disable StringLiteralTypo
                            Console.WriteLine($"[Debug]: true (iscorrect) | {key} input | {allowed} allowedSymbol");
                                
                        }
                        break;
                    }
                    if (_debugOut)
                    {
                        Console.WriteLine($"[Debug]: false (iscorrect) | {key} input | {allowed} allowedSymbol");
                    } // ReSharper restore StringLiteralTypo
                }

                if (!iscorrect)
                {
                    // ReSharper disable StringLiteralTypo //what do you mean?? its German >:(
                    Console.Write($"Bitte benutzte nur [Y/N] | Please use [Y/N] \n{question} [Y/N]: ");
                    // ReSharper restore StringLiteralTypo
                    key = Console.ReadLine();
                    Console.WriteLine("");
                }
            }
            return ContinueCheck(key, yesInput);
        }
        private static bool ContinueCheck(String key, string[] yesInput)
        {
            foreach (var yes in yesInput)
            {
                if (key == yes)
                {
                    if (_debugOut)
                    {
                        Console.WriteLine($"[Debug]: {key} input | {yes} allowedSymbol");
                    }
                    return true;
                }
                else
                {
                    if (_debugOut)
                    {
                        Console.WriteLine($"[Debug]: {key} input | {yes} allowedSymbol");
                    }
                }
            }
            return false;
        }

        public static bool CanBeConvertedToType(string input, string type)
        {
            switch (input)
            {
                case "int":
                    return int.TryParse(input, out _);
                case "double":
                    return double.TryParse(input, out _);
                case "float":
                    return float.TryParse(input, out _);
                case "long":
                    return long.TryParse(input, out _);
                default:
                    return false;
            }
        }
        /// <summary>
        /// Returns the current UnixTime
        /// </summary>
        /// <returns></returns>
        public static long GetUnixTime()
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
        /// <summary>
        /// Requests a string for the user
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static string GetString(string question)
        {
            Console.Write($"{question}: ");
            return Console.ReadLine();
        }
    }
}