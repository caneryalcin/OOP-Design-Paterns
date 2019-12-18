using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //İmplement the order
    public class OrderProcess
    {

        public void addnewOrder()
        {

            Console.WriteLine("New order added");

        }
        public void removeOrder()
        {

            Console.WriteLine("Order removed");

        }

        
    }

    //it should be an interface for every command that will run
    public interface ICommand
    {
        void Run();
    }


    public class addNewOrderCommand : ICommand
    {

        private OrderProcess orderProcess;
        public addNewOrderCommand(OrderProcess orderProcess)
        {

            this.orderProcess = orderProcess;

        }

        public void Run()
        {

            orderProcess.addnewOrder();

        }

    }
    public class removeOrderCommand : ICommand
    {

        private OrderProcess orderProcess;
        public removeOrderCommand(OrderProcess orderProcess)
        {

            this.orderProcess = orderProcess;

        }

        public void Run()
        {

            orderProcess.removeOrder();

        }

    }

    public class CommandSender
    {

        public void Run(ICommand command)
        {

            command.Run();

        }

    }

}
