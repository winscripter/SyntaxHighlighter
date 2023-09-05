using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for the Kotlin language
    /// </summary>
    public class Kotlin
    {
        /// <summary>
        /// All keywords in Kotlin
        /// </summary>
        public string[] LanguageKeywords = { 
            "as",
            "as?",
            "break",
            "class",
            "continue",
            "do",
            "else",
            "false",
            "for",
            "fun",
            "if",
            "in",
            "!in",
            "interface",
            "is",
            "!is",
            "null",
            "object",
            "package",
            "return",
            "super",
            "this",
            "throw",
            "true",
            "try",
            "typealias",
            "val",
            "var",
            "when",
            "while"
        };

        
        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "Kotlin is a language created by the JetBrains Company, which is known for releasing a lot of coding tools and over 10 IDEs to be exact. Kotlin was created in 2011, and became open source in February 2016. It is precompiled into Java bytecode, or, Java ARchive (JAR), and can have source code conversion to Java source. Kotlin is practically Java with its re-made syntax, which makes more sense. So if you dislike Java but you do need its possibilities, you could need to try out Kotlin.";

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