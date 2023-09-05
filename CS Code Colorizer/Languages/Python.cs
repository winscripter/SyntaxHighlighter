using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for the Python scripting language
    /// </summary>
    public class Python
    {
        // All keywords in Python
        public string[] LanguageKeywords = { 
            "False",
            "None",
            "True",
            "and",
            "as",
            "assert",
            "async",
            "await",
            "break",
            "class",
            "continue",
            "def",
            "del",
            "elif",
            "else",
            "except",
            "finally",
            "for",
            "from",
            "global",
            "if",
            "import",
            "in",
            "is",
            "lambda",
            "nonlocal",
            "not",
            "or",
            "pass",
            "raise",
            "return",
            "try",
            "while",
            "with",
            "yield"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "Python is a weakly-typed scripting/interpreted language created back in 1990s. It is currently almost the most popular programming language. It can be used to build a lot of things. Python is very easy. It is very good for Machine Learning, but can also be used for different things, like Django language or Raspberry Pi computer.";

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