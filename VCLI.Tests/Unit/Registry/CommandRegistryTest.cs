using System;
using VCLI.Command;
using VCLI.Registry;
using VCLI.Tests.Data.Command;
using Xunit;

namespace VCLI.Tests.Unit.Registry
{
    public class CommandRegistryTest
    {
        private CommandRegistry _Instance { get; }

        public CommandRegistryTest()
        {
            _Instance = new CommandRegistry();
        }
        [Fact]
        public void Add_InvalidArgument_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => _Instance.Add("test", null));
        }
        
        [Fact]
        public void Add_ValidCommand_StoresTheCommandInRegistry()
        {
            _Instance.Add("test", new TestCommand());
            Assert.IsType<TestCommand>(_Instance.Load("test"));
        }
    
    }
}