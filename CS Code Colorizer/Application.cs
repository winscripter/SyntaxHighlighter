using System;
using System.IO;
using System.Diagnostics;
using CodeColorizer.Languages;
using CodeColorizer;
using static CodeColorizer.Filtering;

namespace CodeColorizer
{
    /// <summary>
    /// Application entry point class
    /// </summary>
    public class Application
    {
        /// <summary>
        /// The stopwatch
        /// </summary>
        private static Stopwatch sw = new Stopwatch();
        
        /// <summary>
        /// Colorizer class reference
        /// </summary>
        private static Colorizer c = new Colorizer();

        /// <summary>
        /// Is case sensitive?
        /// </summary>
        private static bool CaseSensitive = true;

        /// <summary>
        /// Help message
        /// </summary>
        public static void Help()
        {
            Console.WriteLine("Usage\nCodeColorizer helps you colorize the code\n\n<arg1> - Path to source file\n<arg2> - Language: [bash|sh|c|c++|cpp|c++20|cpp20|cs|csharp|css|go|golang|java|javascript|js|kotlin|kt|php|python|py|sql|swift|windowsbatch|batch|bat|windowscmd|cmd|cmd.exe|commandprompt|asm|assembly|s|x86asm|x86assembly]\n<arg3> - Enable Case Sensitivity (optional) (/noCaseSensitivity)");
            Environment.Exit(1);
        }

        /// <summary>
        /// Application entry point
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            if (args.Length == 0 ||
                args.Length == 1)
                Help();
            
            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"Error: Unable to find source file \"{args[0]}\".");
                Environment.Exit(1);
            }

            sw.Start();
            
            string code = default(string);
            try
            {
                code = File.ReadAllText(args[0]);
            }
            catch (Exception e)
            {
                Console.Write($"Unexpected Error: {e.Message}");
                Environment.Exit(1);
            }

            if (args.Length == 3)
                if (args[2].ToLower() == "/nocasesensitivity")
                    CaseSensitive = false;
                else
                    Console.WriteLine($"Warning: Invalid argument {args[2]}, this argument is ignored and the code is case sensitive.\n");

            switch (args[1].ToLower())
            {
                case "bash":
                case "sh":
                Console.WriteLine("Language: Bash\n\n");
                Bash sh = new Bash();
                c.Colorize(code, ApplyFilter(sh.LanguageKeywords, 
                                             sh.Chars, 
                                             sh.Operators, 
                                             sh.EscapeSequences), CaseSensitive);
                break;

                case "c":
                Console.WriteLine("Language: C\n\n");
                CLang cl = new CLang();
                c.Colorize(code, ApplyFilter(cl.LanguageKeywords, 
                                             cl.Chars, 
                                             cl.Operators, 
                                             cl.EscapeSequences), CaseSensitive);
                break;

                case "c++":
                case "cpp":
                case "c++20":
                case "cpp20":
                Console.WriteLine("Language: C++ version 20\n\n");
                CPP20 cpp = new CPP20();
                c.Colorize(code, ApplyFilter(cpp.LanguageKeywords, 
                                             cpp.Chars, 
                                             cpp.Operators, 
                                             cpp.EscapeSequences), CaseSensitive);
                break;

                case "cs":
                case "csharp":
                Console.WriteLine("Language: C# 7.x\n\n");
                CSharp cs = new CSharp();
                c.Colorize(code, ApplyFilter(cs.LanguageKeywords, 
                                             cs.Chars, 
                                             cs.Operators, 
                                             cs.EscapeSequences), CaseSensitive);
                break;

                case "css":
                Console.WriteLine("Language: CSS\n\n");
                CSS css = new CSS();
                c.Colorize(code, ApplyFilter(css.LanguageKeywords, 
                                             css.Chars, 
                                             css.Operators, 
                                             css.EscapeSequences), CaseSensitive);
                break;

                case "go":
                case "golang":
                Console.WriteLine("Language: Go\n\n");
                Go go = new Go();
                c.Colorize(code, ApplyFilter(go.LanguageKeywords, 
                                             go.Chars, 
                                             go.Operators, 
                                             go.EscapeSequences), CaseSensitive);
                break;

                case "java":
                Console.WriteLine("Language: Java\n\n");
                Java j = new Java();
                c.Colorize(code, ApplyFilter(j.LanguageKeywords, 
                                             j.Chars, 
                                             j.Operators, 
                                             j.EscapeSequences), CaseSensitive);
                break;

                case "javascript":
                case "js":
                Console.WriteLine("Language: JavaScript (with support for HTML, ECMAScript 6)\n\n");
                JavaScript js = new JavaScript();
                c.Colorize(code, ApplyFilter(js.LanguageKeywords, 
                                             js.Chars, 
                                             js.Operators, 
                                             js.EscapeSequences), CaseSensitive);
                break;

                case "kotlin":
                case "kt":
                Console.WriteLine("Language: Kotlin\n\n");
                Kotlin kt = new Kotlin();
                c.Colorize(code, ApplyFilter(kt.LanguageKeywords, 
                                             kt.Chars, 
                                             kt.Operators, 
                                             kt.EscapeSequences), CaseSensitive);
                break;

                case "php":
                Console.WriteLine("Language: PHP\n\n");
                PHP php = new PHP();
                c.Colorize(code, ApplyFilter(php.LanguageKeywords, 
                                             php.Chars, 
                                             php.Operators, 
                                             php.EscapeSequences), CaseSensitive);
                break;

                case "python":
                case "py":
                Console.WriteLine("Language: Python 3\n\n");
                Python py = new Python();
                c.Colorize(code, ApplyFilter(py.LanguageKeywords, 
                                             py.Chars, 
                                             py.Operators, 
                                             py.EscapeSequences), CaseSensitive);
                break;

                case "sql":
                Console.WriteLine("Language: SQL/Microsoft SQL Server\n\n");
                SQL sql = new SQL();
                c.Colorize(code, ApplyFilter(sql.LanguageKeywords, 
                                             sql.Chars, 
                                             sql.Operators, 
                                             sql.EscapeSequences), CaseSensitive);
                break;

                case "swift":
                Console.WriteLine("Language: Swift\n\n");
                Swift swift = new Swift();
                c.Colorize(code, ApplyFilter(swift.LanguageKeywords, 
                                             swift.Chars, 
                                             swift.Operators, 
                                             swift.EscapeSequences), CaseSensitive);
                break;

                case "windowsbatch":
                case "batch":
                case "bat":
                case "windowscmd":
                case "cmd":
                case "cmd.exe":
                case "commandprompt":
                Console.WriteLine("Language: Batch (Windows)\n\n");
                WindowsBatch wb = new WindowsBatch();
                c.Colorize(code, ApplyFilter(wb.LanguageKeywords, 
                                             wb.Chars, 
                                             wb.Operators, 
                                             wb.EscapeSequences), CaseSensitive);
                break;

                case "asm":
                case "assembly":
                case "s":
                case "x86asm":
                case "x86assembly":
                Console.WriteLine("Language: X86 (8086) Assembly\n\n");
                X86Assembly s = new X86Assembly();
                c.Colorize(code, ApplyFilter(s.LanguageKeywords, 
                                             s.Chars, 
                                             s.Operators, 
                                             s.EscapeSequences), CaseSensitive);
                break;

                default:
                    Console.WriteLine($"Unknown language: {args[1]}. For a list of possible languages and usage of the program, run the program without any command-line arguments.");
                    Environment.Exit(1);
                    break;
            }
            Console.WriteLine("\n\nCOLORIZE: Success");
            
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Completed in {ts.Minutes}m, {ts.Seconds}s, {ts.Milliseconds}ms.");
            return;
        }
    }
}