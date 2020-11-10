using System;
using AutomationIDELibrary.Compiler;

namespace AutomationIDECompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Compiler.Build();
            if (Compiler.Lines.Contains("--firefox")) Compiler.BuildFireFox();
            else if (Compiler.Lines.Contains("--chrome")) Compiler.BuildChrome();
            Console.ReadKey();
        }
    }
}
