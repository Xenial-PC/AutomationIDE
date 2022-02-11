using System;
using AutomationIDELibrary.Compiler;

namespace AutomationIDECompiler
{
    internal class Program
    {
        private static void Main()
        {
            var compiler = new Compiler(); 
            compiler.ReadScript();

            if (Compiler.Lines.Contains("--firefox")) compiler.BuildFireFox(); 
            else if (Compiler.Lines.Contains("--chrome")) compiler.BuildChrome();

            Console.ReadKey();
        }
    }
}
