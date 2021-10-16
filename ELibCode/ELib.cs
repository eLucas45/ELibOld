using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ELibCode
{
    public class ELib
    {
        //Code by limited-dev (c) 2021
        public static bool Initd = false;
        public static bool disDebugInfo = false;
        public static void Init(bool enableDebugInfo)
        {
            // ---- Inits the lib ----
            Console.Write($"ELib init.");
            Console.Title = $"{Console.Title} using ELibCode";
            Console.Write($".");
            Initd = true;
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
                        //Console.WriteLine($"DEBUG: {iscorrect}(iscorrect) | {key} input | {allowedYesNo[i]} allowedSymbol");
                        break;
                    }
                    //Console.WriteLine($"DEBUG: {iscorrect}(iscorrect) | {key} input | {allowedYesNo[i]} allowedSymbol");
                }
                if (!iscorrect)
                {
                    Console.Write($"Bitte benutzte nur [J/n]\nMöchten sie fortfahren? [J/n]: ");
                    key = Console.ReadLine();
                    Console.WriteLine("");
                }
            }
            return ContinueCheck(key, YesInput);
        }

        /// <summary>
        /// The accual Continue check
        /// </summary>
        /// <param name="key"></param>
        /// <param name="Yes"></param>
        /// <returns></returns>
        public static bool ContinueCheck(String key, string[] YesInput)
        {
            bool revalue = false;
            for (int i = 0; i < YesInput.Length; i++)
            {
                if (key == YesInput[i])
                {
                    //Console.WriteLine($"DEBUG: {key} input | {Yes[i]} allowedSymbol\n");
                    revalue = true;
                    break;
                }
                else
                {
                    //Console.WriteLine($"DEBUG: {key} input | {Yes[i]} allowedSymbol");
                    revalue = false;
                }
            }
            return revalue;
        }
    }
}
