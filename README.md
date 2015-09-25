# ArgsManager
A simple way to parse command line arguments.

## Using
For the following startup parameters:
<pre>
<code>
	Program.exe /v /file file.txt
	Program.exe -v -file file.txt
	Program.exe /V /FILE file.txt
	Program.exe -V -FILE file.txt
</code>
</pre>

It is recommended to use the syntax:
<pre>
<code>
	using System;
	using AG23.ArgsManager;
	
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
</code>
</pre>

Output:
<pre>
<code>
	Verbose mode on.
	FileName = file.txt.
</code>
</pre>

Good luck!