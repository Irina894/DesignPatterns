using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.command
{
    public class RemoteControl
    {
        private ICommand? command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            if (command != null)
            {
                command.Execute();
            }
            else
            {
                Console.WriteLine("No command assigned to button.");
            }
        }
    }
}
