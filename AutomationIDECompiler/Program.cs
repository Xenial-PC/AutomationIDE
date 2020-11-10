using System;
using AutomationIDELibrary.Compiler;

namespace AutomationIDECompiler
{
    class Program
    {
        static void Main()
        {
            var compiler = new Compiler();
            compiler.Build();
            if (Compiler.Lines.Contains("--firefox")) compiler.BuildFireFox();
            else if (Compiler.Lines.Contains("--chrome")) compiler.BuildChrome();
            Console.ReadKey();
        }
    }
}
