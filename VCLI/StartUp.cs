using System.Linq;
using System.Reflection.Metadata;
using VCLI.Command;
using VCLI.Registry;

namespace VCLI
{
    public class StartUp
    {
        private IRegistry _Registry { get; }

        public StartUp(IRegistry registry)
        {
            _Registry = registry;
        }

        public void Run(string[] args)
        {
            RegisterCommands();
            HandleCommand(args);
        }

        private void HandleCommand(string[] args)
        {
            _Registry.Load(args.First()).Run(args);
        }
        
        private void RegisterCommands()
        {
            _Registry.Add("help", new HelpCommand());
        }

    }
}