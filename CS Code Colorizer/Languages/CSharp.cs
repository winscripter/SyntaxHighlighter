using System;
using CodeColorizer;

namespace CodeColorizer
{
    /// <summary>
    /// Configuration for the C# programming language
    /// </summary>
    public class CSharp
    {
        /// <summary>
        /// All keywords in C#
        /// </summary>
        public string[] LanguageKeywords = { 
            "abstract",
            "as",
            "base",
            "bool",
            "break",
            "byte",
            "case",
            "catch",
            "char",
            "checked",
            "class",
            "const",
            "continue",
            "decimal",
            "default",
            "delegate",
            "do",
            "double",
            "else",
            "enum",
            "event",
            "explicit",
            "extern",
            "false",
            "finally",
            "fixed",
            "float",
            "for",
            "foreach",
            "goto",
            "if",
            "implicit",
            "in",
            "int",
            "interface",
            "internal",
            "is",
            "lock",
            "long",
            "namespace",
            "new",
            "null",
            "object",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "readonly",
            "ref",
            "return",
            "sbyte",
            "sealed",
            "short",
            "sizeof",
            "stackalloc",
            "static",
            "string",
            "struct",
            "switch",
            "this",
            "throw",
            "true",
            "try",
            "typeof",
            "uint",
            "ulong",
            "unchecked",
            "unsafe",
            "ushort",
            "using",
            "virtual",
            "void",
            "volatile",
            "while"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "C# (pronounced See Sharp) is a very popular and loved language created by Microsoft in January 2002. It runs on the Windows .NET Framework (as well as .NET Core). Initially it was critised as a language that inherits from Java, but has evolved into one of the most popular and loved languages. Today, it is capable to build practically anything: 2D/3D games with Unity, server-side development with ASP.NET, mobile apps with Xamarin, web apps with Blazor, cross-platform apps with .NET Core (as opposed to .NET Framework which is not cross-platform), machine learning with ML.NET, database management with Entity Framework, and a ton more. It is currently the best programming language for creating Windows applications, as C# and Windows are both Microsoft products. It became open-source since 2014, with their new compiler named Roslyn. It also has a core feature called LINQ, where you can execute a query. By the way, you're currently reading the source code of this program, which is written in C# ;).";

        /// <summary>
        /// Characters
        /// </summary>
        public char[] Chars = { '(', ')', '{', '}', '[', ']', '@', '#', '$', '&', '\"', '\'', '\\' };
        
        /// <summary>
        /// Operators
        /// </summary>
        public string[] Operators = { "!", "*", "+", "-", "=", "/", "|", "^", "<", ">", "==", "<=", ">=" };

        /// <summary>
        /// Escape sequences
        /// </summary>
        public string[] EscapeSequences = { "\\\"", "\\\'", "\\\\", "\\f", "\\n", "\\v", "\\x", "\\t" };
    }
}