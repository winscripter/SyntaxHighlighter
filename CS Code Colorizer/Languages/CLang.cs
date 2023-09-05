using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for the C programming language
    /// </summary>
    public class CLang
    {
        /// <summary>
        /// All keywords in ANSI C.
        /// </summary>
        public string[] LanguageKeywords = { 
            "auto",
            "double",
            "int",
            "struct",
            "break",
            "else",
            "long",
            "switch",
            "case",
            "enum",
            "register",
            "typedef",
            "char",
            "extern",
            "return",
            "union",
            "const",
            "float",
            "short",
            "unsigned",
            "continue",
            "for",
            "signed",
            "void",
            "default",
            "goto",
            "sizeof",
            "volatile",
            "do",
            "if",
            "static",
            "while"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "C is the strong typed general purpose programming language created in 1972 by Dennis Ritchie for the UNIX OS. It is not Object-Oriented, but is known for making the world go around. 2 more languages were inherited from C - C++ and C#, whereas C# doesn't fit into the C/C++ category. It can however be used to build almost anything because of how many tools created by different providers it serves.";

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