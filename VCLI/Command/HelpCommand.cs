using System;

namespace VCLI.Command
{
    public class HelpCommand: ICommand
    {
        public void Run(string[] args)
        {
            Console.WriteLine("Usage:");
        }
    }
}