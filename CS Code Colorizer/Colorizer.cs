using System;
using CodeColorizer;

namespace CodeColorizer
{
    /// <summary>
    /// Main class to output code in a colorized format.
    /// </summary>
    internal class Colorizer
    {
        /// <summary>
        /// Begins colorize process.
        /// </summary>
        /// <param name="code">The code</param>
        /// <param name="filter">The keyword filtering</param>
        /// <param name="EnableCaseSensitivity">Enable filtering case sensitivity?</param>
        public void Colorize(string code, string filter, bool EnableCaseSensitivity)
        {
            string[] lineByLine = code.Split('\n');
            string[] filters = filter.Split(';');

            for (int i = 0; i < lineByLine.Length; i++)
            {
                string[] Words = lineByLine[i].Split(' ');
                bool has = false;
                string color = default(string);
                foreach (string Word in Words)
                {
                    foreach (string flt in filters)
                        if (EnableCaseSensitivity)
                        {
                            if (flt.Split(' ')[1].ToLower() == Word.ToLower())
                            {
                                has = true;
                                color = flt.Split(' ')[0].ToLower();
                            }
                        }
                    
                    if (has)
                    {
                        ConsoleColor? targetColor;
    
                        switch (color)
                        {
                            case "black": targetColor = ConsoleColor.Black; break;
                            case "blue": targetColor = ConsoleColor.Blue; break;
                            case "cyan": targetColor = ConsoleColor.Cyan; break;
                            case "darkblue": targetColor = ConsoleColor.DarkBlue; break;
                            case "darkcyan": targetColor = ConsoleColor.DarkCyan; break;
                            case "darkgray": targetColor = ConsoleColor.DarkGray; break;
                            case "darkgreen": targetColor = ConsoleColor.DarkGreen; break;
                            case "darkmagenta": targetColor = ConsoleColor.DarkMagenta; break;
                            case "darkred": targetColor = ConsoleColor.DarkRed; break;
                            case "darkyellow": targetColor = ConsoleColor.DarkYellow; break;
                            case "gray": targetColor = ConsoleColor.Gray; break;
                            case "green": targetColor = ConsoleColor.Green; break;
                            case "magenta": targetColor = ConsoleColor.Magenta; break;
                            case "red": targetColor = ConsoleColor.Red; break;
                            case "white": targetColor = ConsoleColor.White; break;
                            case "yellow": targetColor = ConsoleColor.Yellow; break;
                            default: targetColor = null; break;
                        }

                        if (targetColor == null)
                        {
                            Console.ResetColor();
                            Console.Write(Word + " ");
                        }
                        else
                            Color(Word, (ConsoleColor)targetColor);
                        color = default(string);
                    } else Console.Write(Word + " ");
                }
                Console.WriteLine();
            }
        }

        private void Color(string message, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.Write(message + " ");
            Console.ResetColor();
        }
    }
}
