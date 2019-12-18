using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {

            addNewOrderCommand addNewOrderCommand = new addNewOrderCommand(new OrderProcess());
            removeOrderCommand removeOrderCommand = new removeOrderCommand(new OrderProcess());

            CommandSender commandSender = new CommandSender();

            Console.WriteLine("if you want to add order write 'add'\n if you want to remove order write 'remove'");
            string answer  = "";
            answer = Console.ReadLine();
            if (answer == "add")
            {
                commandSender.Run(addNewOrderCommand);
            }
            else if (answer == "remove")
            {

                commandSender.Run(removeOrderCommand);

            }

            Console.WriteLine("To complete the process write 'complete'");
            string complete = "";
            complete = Console.ReadLine();
            if (complete == "complete")
            {

                Environment.Exit(0);

            }

            Console.ReadKey();
        }
    }
}
