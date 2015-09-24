using System;
using System.Linq;

namespace AG23.ArgsManager
{
    public static class ArgsManager
    {
        public static bool GetArg(char name)
        {
            return Environment.GetCommandLineArgs().Any(arg => arg.TrimStart('/', '-').Equals($"{name}", StringComparison.InvariantCultureIgnoreCase));
        }

        public static string GetArg(string name, string @default = null)
        {
            var flag = false;
            foreach (var arg in Environment.GetCommandLineArgs())
            {
                if (flag)
                    return arg;
                if (arg.TrimStart('/', '-').Equals(name, StringComparison.InvariantCultureIgnoreCase))
                    flag = true;
            }
            return @default;
        }
    }
}
