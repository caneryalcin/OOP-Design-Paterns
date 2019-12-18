using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkerHandler firstWorker = new ConcreteFirstWorkerHandler();
            WorkerHandler secondWorker = new ConcreteSecondWorkerHandler();
            WorkerHandler thirdWorker = new ConcreteThirdWorkerHandler();

            //put in order 
            //Specify the order in which the request is passed to the ConcreteHandler classes
            firstWorker.nextHandler = secondWorker;
            secondWorker.nextHandler = thirdWorker;

            //send the firt chain
            firstWorker.isWorkerBusy(true);
            secondWorker.isWorkerBusy(true);
            thirdWorker.isWorkerBusy(false);
            Console.ReadKey();

        }
    }
}
