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
	using AG23.ArgsManager;

	class Program {
		public static readonly bool Verbose = ArgsManager.GetArg('v');
		public static readonly string FileName = ArgsManager.GetArg("file");	 
	}
</code>
</pre>

Good luck!