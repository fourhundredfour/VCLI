using System;
using VCLI.Registry;

namespace VCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Preconditions.Check.NotEmpty(args, String.Empty);
            new StartUp(new CommandRegistry()).Run(args);
        }
    }
}