using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            CommunityCollecion communityCollection = new CommunityCollecion();
            communityCollection[0] = new Community("Ahmet","kara",35);
            communityCollection[1] = new Community("Melike", "Başar", 62);
            communityCollection[2] = new Community("Sezai", "Karakoç", 26);
            communityCollection[3] = new Community("Cahit", "Zarifoğlu",40);

            ICommunityIterator communityIterator = communityCollection.CreateIterator();

            Console.WriteLine("Toplulukta kayıtlı olan kişiler:");

            object item = communityIterator.First();
            while (item != null)
            {

                Console.WriteLine(item);
                item = communityIterator.Next();

            }
            Console.ReadKey();

        }

    }

}
