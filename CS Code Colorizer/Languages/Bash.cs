using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for the Bash language
    /// </summary>
    public class Bash
    {
        /// <summary>
        /// All keywords in Bash
        /// </summary>
        public string[] LanguageKeywords = { 
            "case",
            "do",
            "done",
            "elif",
            "else",
            "esac",
            "fi",
            "for",
            "function",
            "if",
            "in",
            "select",
            "then",
            "time",
            "until",
            "while"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "Bash is a shell for Linux, similar to something like MS-DOS. The bash script, or better - Shell script, contains commands that are interpreted by Linux Bash.";

        /// <summary>
        /// Characters
        /// </summary>
        public char[] Chars = { '(', ')', '{', '}', '[', ']', '@', '#', '$', '&', '\"', '\'', '\\' };
        
        /// <summary>
        /// Operators
        /// </summary>
        public string[] Operators = { "!", "*", "+", "-", "=", "/", "|", "^" };

        /// <summary>
        /// Escape sequences
        /// </summary>
        public string[] EscapeSequences = { "\\\"", "\\\'", "\\\\", "\\f", "\\n", "\\v", "\\x", "\\t" };
    }
}