using System;
using AG23.ArgsManager;

namespace TestProgram
{
    class Program
    {
        public static readonly bool Verbose = ArgsManager.GetArg('v');
        public static readonly string FileName = ArgsManager.GetArg("file");

        static void Main()
        {
            if (Verbose)
                Console.WriteLine("Verbose mode on.");
            else
                Console.WriteLine("Verbose mode off.");

            Console.WriteLine("FileName = {0}.", FileName);
        }
    }
}
