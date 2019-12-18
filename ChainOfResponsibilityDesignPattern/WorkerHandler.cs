using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class WorkerHandler
    {

        protected WorkerHandler _nextHandler;
        public WorkerHandler nextHandler {
            set
            {
                _nextHandler = value;
            }
        }

        public abstract void isWorkerBusy(bool isBusy);
    }

    public class ConcreteFirstWorkerHandler : WorkerHandler
    {

        public override void isWorkerBusy(bool isBusy)
        {
            // if the worker is busy print he is busy
            if (isBusy == true)
            {

                Console.WriteLine("1. çalışan şu an meşgul");

            }
            else
            {
                // if the worker is available print he is busy

                if (_nextHandler != null)
                    _nextHandler.isWorkerBusy(false);
                Console.WriteLine("1. çalışan şu an müsait");

            }
        }

    }
    public class ConcreteSecondWorkerHandler : WorkerHandler
    {

        public override void isWorkerBusy(bool isBusy)
        {
            if (isBusy == true)
            {

                Console.WriteLine("2. çalışan şu an meşgul");

            }
            else
            {

                if (_nextHandler != null)
                    _nextHandler.isWorkerBusy(false);
                Console.WriteLine("2. çalışan şu an müsait");

            }
        }

    }
    public class ConcreteThirdWorkerHandler : WorkerHandler
    {

        public override void isWorkerBusy(bool isBusy)
        {
            if (isBusy == true)
            {

                Console.WriteLine("3. çalışan şu an meşgul");

            }
            else
            {

                if (_nextHandler != null)
                    _nextHandler.isWorkerBusy(false);
                Console.WriteLine("3. çalışan şu an müsait");

            }
        }

    }
}
