using System;
using System.Collections.Generic;
using VCLI.Command;

namespace VCLI.Registry
{
    public class CommandRegistry : IRegistry, IDisposable
    {
        private Dictionary<string, ICommand> _Dictionary { get; }

        public CommandRegistry()
        {
            _Dictionary = new Dictionary<string, ICommand>();
        }

        /// <inheritdoc />
        public void Add(string name, ICommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command",
                    "The passed argument for the parameter command contains null");
            }
            _Dictionary.TryAdd(name, command);
        }

        public ICommand Load(string name)
        {
            ICommand command;
            if (!_Dictionary.TryGetValue(name, out command))
            {
                throw new KeyNotFoundException($"{name} not found in Registry");
            }
            return command;
        }

        public void Dispose()
        {
            _Dictionary.Clear();
        }
    }
}