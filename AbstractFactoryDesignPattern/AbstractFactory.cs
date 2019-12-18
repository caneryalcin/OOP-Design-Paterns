using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasarım_Desneleri_Odev2
{
    class AbstractFactory
    {

        abstract class ConcretePhoneFactory
        {

            abstract public ConcretePhoneCase ProducePhoneCase();
            abstract public ConcretePhoneMotherBoard ProducePhoneMotherBoard();
            abstract public ConcretePhoneCamera ProucePhoneCamera();
        }

        class AppleFactory : ConcretePhoneFactory{

            public override  ConcretePhoneCase ProducePhoneCase(){

                return new Iphone10();

            }

            public override  ConcretePhoneMotherBoard ProducePhoneMotherBoard(){

                return new IphoneMoherBoard();

            }

            public override ConcretePhoneCamera ProucePhoneCamera()
            {

                return new IphoneCamera();

            }


        }

        class SamsungFactory : ConcretePhoneFactory{


            public override  ConcretePhoneCase ProducePhoneCase(){

                return new SamsungS10();

            }

            public override ConcretePhoneMotherBoard ProducePhoneMotherBoard(){

                return new IphoneMoherBoard();

            }

            public override ConcretePhoneCamera ProucePhoneCamera()
            {

                return new SamsungCamera();

            }
        }

        abstract class ConcretePhoneCase{

            abstract public void MountMotherBoard(ConcretePhoneMotherBoard a);

            abstract public void MountCamera(ConcretePhoneCamera a);

        }

        abstract class ConcretePhoneMotherBoard{}

        abstract class ConcretePhoneCamera{}

        class Iphone10 : ConcretePhoneCase{

            public override void MountMotherBoard(ConcretePhoneMotherBoard motherBoard)
            {

                Console.WriteLine(motherBoard + " " +"succesfully mounted to Iphone10");

            }

            public override void MountCamera(ConcretePhoneCamera camera)
            {

                Console.WriteLine(camera + " " + "succesfully mounted to Iphone10\n");

            }

        }

        class SamsungS10 : ConcretePhoneCase{

           public override void MountMotherBoard(ConcretePhoneMotherBoard motherBoard)
            {

                Console.WriteLine(motherBoard + "mounted to SamsungS10");

            }
           public override void MountCamera(ConcretePhoneCamera camera)
           {

               Console.WriteLine(camera + " " + "succesfully mounted to SamsungS10\n");

           }
        }

        class IphoneMoherBoard : ConcretePhoneMotherBoard{}
        class IphoneCamera : ConcretePhoneCamera {}
        
        class SamsungMotherBoard : ConcretePhoneMotherBoard{}
        class SamsungCamera : ConcretePhoneCamera {}

        class ProducePhone
        {

            private ConcretePhoneCase phoneCase;
            private ConcretePhoneMotherBoard motherBoard;
            private ConcretePhoneCamera camera;

            public ProducePhone(ConcretePhoneFactory factory)
            {

                phoneCase = factory.ProducePhoneCase();
                motherBoard = factory.ProducePhoneMotherBoard();
                camera = factory.ProucePhoneCamera();
            }

            public void MountMotherBoard()
            {

                phoneCase.MountMotherBoard(motherBoard);

            }

            public void MountCamera()
            {

                phoneCase.MountCamera(camera);

            }

        }

        class Client
        {

            public void Main()
            {

                ConcretePhoneFactory concretePhoneFactory = new AppleFactory();
                ProducePhone producePhone = new ProducePhone(concretePhoneFactory);
                producePhone.MountMotherBoard();
                producePhone.MountCamera();

                ConcretePhoneFactory concretePhoneFactory2 = new SamsungFactory();
                ProducePhone producePhone2 = new ProducePhone(concretePhoneFactory);
                producePhone2.MountMotherBoard();
                producePhone2.MountCamera();

            }

        }

        public static void Main()
        {

            new Client().Main();
            Console.ReadKey();

        }
    }
}