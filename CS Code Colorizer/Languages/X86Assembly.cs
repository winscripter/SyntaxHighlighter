using System;
using CodeColorizer;

namespace CodeColorizer.Languages
{
    /// <summary>
    /// Configuration for X86 Assembly Language
    /// </summary>
    public class X86Assembly
    {
        public string[] LanguageKeywords = {
            /* CPU Instructions */
            "aaa",
            "aad",
            "aam",
            "aas",
            "adc",
            "add",
            "and",
            "call",
            "cbw",
            "clc",
            "cld",
            "cli",
            "cmc",
            "cmp",
            "cmpsb",
            "cmpsw",
            "cwd",
            "daa",
            "das",
            "dec",
            "div",
            "esc",
            "hlt",
            "idiv",
            "imul",
            "in",
            "inc",
            "int",
            "into",
            "iret",
            "ja",
            "jae",
            "jb",
            "jbe",
            "jc",
            "jcxz",
            "je",
            "jg",
            "jge",
            "jl",
            "jle",
            "jmp",
            "jna",
            "jnae",
            "jnb",
            "jnbe",
            "jnc",
            "jne",
            "jng",
            "jnge",
            "jnl",
            "jnle",
            "jno",
            "jnp",
            "jns",
            "jnz",
            "jo",
            "jp",
            "js",
            "jz",
            "lahf",
            "lds",
            "lea",
            "les",
            "lock",
            "lodsb",
            "lodsw",
            "loop",
            "loope",
            "loopne",
            "loopnz",
            "loopz",
            "mov",
            "movsb",
            "movsw",
            "mul",
            "neg",
            "nop",
            "not",
            "or",
            "out",
            "pop",
            "popf",
            "push",
            "pushf",
            "rcl",
            "rcr",
            "ret",
            "retn",
            "rol",
            "ror",
            "sahf",
            "sal",
            "sar",
            "sbb",
            "scasb",
            "scasw",
            "shl",
            "shr",
            "stc",
            "std",
            "sti",
            "stosb",
            "stosw",
            "sub",
            "test",
            "wait",
            "xchg",
            "xlat",
            "xor",
            /* Language Directives */
            "%define",
            "%elif",
            "%else",
            "%endif",
            "%if",
            "%ifdef",
            "%ifndef",
            "%include",
            "%line",
            "%macro",
            "%pop",
            "%push",
            "%rep",
            "%rotate",
            "%undef"
        };

        /// <summary>
        /// Unused
        /// </summary>
        public string AboutLanguage = "Assembly is the world's first language. It was created in 1947 for the All-Purpose Electronic Computer (APEC). Before Assembly, people would have to flick buttons and levers to work with a computer, but in 1947 it was going to be much more convenient by simply executing code. Assembly consists of things like instructions, and instructions tell the CPU what to do. Assembly is quite complex and you should know the inner workings of the CPU to at least get started.";

        /*
                NOTICE:
                
                These fields are important to leave,
                even though Assembly doesn't have things
                like escape sequences.
        */
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