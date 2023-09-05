using System;
using System.Text;

namespace CodeColorizer
{
    /// <summary>
    /// Applies filter
    /// </summary>
    internal class Filtering
    {
        /// <summary>
        /// Set filter
        /// </summary>
        /// <param name="keywd">Keywords</param>
        /// <param name="chars">Characters</param>
        /// <param name="opers">Operators</param>
        /// <param name="esc">Escape Sequences</param>
        /// <returns></returns>
        public static string ApplyFilter(string[] keywd, 
                                        char[] chars, 
                                        string[] opers,
                                        string[] esc)
        {
            StringBuilder resbuf = new StringBuilder();

            foreach (string iter in keywd)
                resbuf.Append($"darkcyan {iter};");
            foreach (char ch in chars)
                resbuf.Append($"darkyellow {ch};");
            foreach (string op in opers)
                resbuf.Append($"green {op};");
            foreach (string e in esc)
                resbuf.Append($"red {e};");
            
            string filtered = resbuf.ToString();
            // Remove last semicolon
            filtered = filtered.Remove(filtered.Length - 1);
            return filtered;
        }
    }
}