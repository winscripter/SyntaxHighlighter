using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for Windows Batch language
    /// </summary>
    public class WindowsBatch
    {
        /// <summary>
        /// All keywords in Batch
        /// </summary>
        public string[] LanguageKeywords = { 
            "set",
            "if",
            "else",
            "for",
            "goto",
            "call",
            "echo",
            "exit",
            "and",
            "or",
            "not",
            "equ",
            "neq",
            "lss",
            "leq",
            "gtr",
            "geq"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "Windows Batch is simply a file extension (.bat, .cmd) containing commands that are interpreted by the Windows Command Prompt (C: Windows System32 Cmd.exe).";

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
        public string[] EscapeSequences = { "^>", "^<" };
    }
}