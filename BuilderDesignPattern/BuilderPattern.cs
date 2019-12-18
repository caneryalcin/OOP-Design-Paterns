using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{

    public class Computer
    {

        public string ComputerName { get; set; }
        public string Usb { get; set; }
        public string Ram { get; set; }

        public string GraphicCard { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", ComputerName, Usb, Ram, GraphicCard);
        }
    }

    public abstract class ComputerBuilder
    {

        protected Computer computer;

        public Computer Computer
        {

            get { return computer; }

        }

        public abstract void ProduceUsb();
        public abstract void ProduceRam();

        public abstract void ProduceGraphicCard();

    }


    public class MonsterComputer : ComputerBuilder
    {

        public MonsterComputer()
        {

            computer = new Computer { ComputerName = "Monster" };
        }
        public override void ProduceUsb()
        {

            computer.Usb = "USB 3.0 mounted to computer\n";

        }

        public override void ProduceRam()
        {

            computer.Ram = "DDR5 8GB Ram mounted to computer\n";
        }

        public override void ProduceGraphicCard()
        {

            computer.GraphicCard = "Nvidia GTX 1050Ti Graphic card mounted to computer\n";

        }

    }


    public class SamsungNotebook : ComputerBuilder
    {

        public SamsungNotebook()
        {

            computer = new Computer { ComputerName = "Samsung" };

        }

        public override void ProduceUsb()
        {
            computer.Usb = "USB 3.1 mounted to computer\n";
        }
        public override void ProduceRam()
        {

            computer.Ram = "DDR4 8GB Ram mounted to computer\n";
        }

        public override void ProduceGraphicCard()
        {

            computer.GraphicCard = "Nvidia GTX 960 Graphic card mounted to computer\n";

        }

    }

    public class Producer
    {

        public void Produce(ComputerBuilder comBuilder)
        {

            comBuilder.ProduceRam();
            comBuilder.ProduceUsb();
            comBuilder.ProduceGraphicCard();

        }

    }
    class BuilderPattern
    {

        static void Main(string[] args)
        {

            ComputerBuilder comBuilder;

            Producer producer = new Producer();

            comBuilder = new MonsterComputer();
            producer.Produce(comBuilder);
            Console.WriteLine(comBuilder.Computer.ToString());

            comBuilder = new SamsungNotebook();
            producer.Produce(comBuilder);
            Console.WriteLine(comBuilder.Computer.ToString());

            Console.ReadKey();

        }

    }
}
