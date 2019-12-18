using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern
{
    
        class Playstation
        {

            public static int ObjectCounter = 0;

            public String s;

            public Playstation()
            {
                s = "Playstation is rented";
                ObjectCounter++;

            }

        }

        class Pool
        {

            private static int _PoolMaxSize = 3;
            private static readonly Queue objPool = new
         Queue(_PoolMaxSize);

            public Playstation GetPlaystation()
            {
                Playstation playstation;
                if (Playstation.ObjectCounter >= _PoolMaxSize && objPool.Count > 0)
                {
                    playstation = null;

                    if (RentPlayStation.takeGive == "Take")
                    {

                        playstation = RetrieveFromPool();
                        Console.WriteLine("Playstation is taken back ");

                    }
                    return playstation;
                }
                else
                {

                    playstation = GetNewPlaystation();
                    Console.WriteLine(playstation.s);
                    return playstation;



                }


            }
            private Playstation GetNewPlaystation()
            {

                Playstation playstation = new Playstation();
                objPool.Enqueue(playstation);
                return playstation;
            }
            protected Playstation RetrieveFromPool()
            {

                Playstation playstation;
                if (objPool.Count > 0)
                {

                    playstation = (Playstation)objPool.Dequeue();
                    Playstation.ObjectCounter--;
                }
                else
                {

                    playstation = new Playstation();

                }
                return playstation;
            }

        }
        class RentPlayStation
        {

            public static string takeGive;
            static int playstationNum = 0;
            static void Main(string[] args)
            {

                Pool p = new Pool();

                for (int i = 0; i < 10; i++)
                {
                    if (playstationNum > 3 && Playstation.ObjectCounter >= 3)
                    {
                        takeGive = Console.ReadLine();
                        playstationNum--;
                        i--;
                    }

                    Playstation playstation = p.GetPlaystation();
                    playstationNum++;
                }
                Console.Read();

            }
        }
}

