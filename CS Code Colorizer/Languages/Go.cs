using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for Go language
    /// </summary>
    public class Go
    {
        /// <summary>
        /// All keywords in Golang
        /// </summary>
        public string[] LanguageKeywords = { 
            "break",
            "default",
            "func",
            "interface",
            "select",
            "case",
            "defer",
            "go",
            "map",
            "struct",
            "chan",
            "else",
            "goto",
            "package",
            "switch",
            "const",
            "fallthrough",
            "if",
            "range",
            "type",
            "continue",
            "for",
            "import",
            "return",
            "var"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "Go is a language created by Google in 2009. It was intended for its performance, minimal complexity. Learning Go can make you a worker at Google.";

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