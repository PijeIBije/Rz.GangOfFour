using System.Collections.Generic;

namespace Rz.GangOfFour.Behavioral.Command
{
    public class CommandInvoker
    {
        private readonly List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteAll()
        {
           commands.ForEach(x=>x.Execute());
        }
    }
}
