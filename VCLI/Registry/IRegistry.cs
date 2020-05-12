using VCLI.Command;

namespace VCLI.Registry
{
    public interface IRegistry
    {
        public void Add(string name, ICommand command);
        public ICommand Load(string name);
    }
}