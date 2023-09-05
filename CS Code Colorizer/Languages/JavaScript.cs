using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for the JavaScript language
    /// </summary>
    public class JavaScript
    {
        /// <summary>
        /// All keywords in JavaScript (includes support for
        /// browsers AND ES6, and so is the reason why is there
        /// let, window, console, document, etc)
        /// </summary>
        public string[] LanguageKeywords = { 
            "break",
            "case",
            "catch",
            "class",
            "console",
            "const",
            "continue",
            "debugger",
            "default",
            "delete",
            "do",
            "document",
            "doc",
            "else",
            "export",
            "extends",
            "finally",
            "for",
            "function",
            "if",
            "import",
            "in",
            "instanceof",
            "let",
            "new",
            "return",
            "super",
            "switch",
            "this",
            "throw",
            "try",
            "typeof",
            "var",
            "void",
            "while",
            "window",
            "with",
            "yield"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "JavaScript is the world's most popular programming language. JavaScript is mostly used when it comes to working with websites, where JavaScript is a client-side language to handle website operators, for example, cookies, math, timing, etc. In that case, JavaScript is interpreted by the browser. JavaScript deals the best job at working with websites. JavaScript is easy to learn. It is a weakly-typed object-oriented language from 1995.";

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