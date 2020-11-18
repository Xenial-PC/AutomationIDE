using System;
using AutomationIDELibrary.Compiler;

namespace AutomationIDECompiler
{
    class Program
    {
        static void Main()
        {
            var compiler = new Compiler(); // Creates a new compiler
            compiler.ReadScript(); // Reads each line of the script

            // Sets the type of driver to be ran on load
            if (Compiler.Lines.Contains("--firefox")) compiler.BuildFireFox(); 
            else if (Compiler.Lines.Contains("--chrome")) compiler.BuildChrome();

            Console.ReadKey();
        }
    }
}
