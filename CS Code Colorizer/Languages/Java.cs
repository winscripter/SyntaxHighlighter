using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for the Java language
    /// </summary>
    public class Java
    {
        /// <summary>
        /// All keywords in Java
        /// </summary>
        public string[] LanguageKeywords = { 
            "abstract",
            "assert",
            "boolean",
            "break",
            "byte",
            "case",
            "catch",
            "char",
            "class",
            "const",
            "continue",
            "default",
            "do",
            "double",
            "else",
            "enum",
            "extends",
            "final",
            "finally",
            "float",
            "for",
            "goto",
            "if",
            "implements",
            "import",
            "instanceof",
            "int",
            "interface",
            "long",
            "native",
            "new",
            "package",
            "private",
            "protected",
            "public",
            "return",
            "short",
            "static",
            "strictfp",
            "super",
            "switch",
            "synchronized",
            "this",
            "throw",
            "throws",
            "transient",
            "try",
            "void",
            "volatile",
            "while"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "Sorry Java developers, but a lot of developers absolutely hate Java. Java is a language originally created by Sun Microsystems in 1995, but then was bought by Oracle. It was originally created for a TV remote. Java is hated for multiple reasons. First, its configuration and setup. Second, it's UI. Third, every data type is lowercase (i.e. int or boolean), but String is the one capitalized. Fourth, each class seems to only be public. Fifth, the name of the class MUST match with the name of the source file. There are more reasons. However, there are some upvotes for Java, like Java being good for Android apps for example. The reason why Java is hated yet popular is due to a very popular game called Minecraft. You can use Java to create the so-called \"mods\", which are modifications to the game (example: summon an explosion on damage, can be done with Java). Java also runs on 8 billion devices at the moment. Another upvote for Java is, by default it is not compiled into an executable, but it is a compiled language. It can be compiled to a .class file, which is a class like an interface, class, or enum, in its binary format, and can be compiled to Java's own executable called JAR (Java ARchive), which can only open with Java. The reason this is an upvote is because this file can be run on any OS later, so Java is cross-platform and you can create cross-platform apps with it.";

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