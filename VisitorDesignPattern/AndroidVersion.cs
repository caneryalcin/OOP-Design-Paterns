using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class AndroidVersion
    {

        public string Version { get; set; }

        public AndroidVersion(string version)
        {

            Version = version;

        }


        public abstract void Controller(IVisitor visitor);

    }

    public class AndroidVersion_1 : AndroidVersion
    {

        public AndroidVersion_1(string version):base(version)
        {

        }

        public override void Controller(IVisitor visitor)
        {

            visitor.Visit(this);

        }

    }
    public class AndroidVersion_2 : AndroidVersion
    {

        public AndroidVersion_2(string version)
            : base(version)
        {

        }

        public override void Controller(IVisitor visitor)
        {

            visitor.Visit(this);

        }

    }

    public interface IVisitor
    {

        void Visit(AndroidVersion version);

    }

    public class VersionVisitor:IVisitor
    {

        public void Visit(AndroidVersion version)
        {

            if (version is AndroidVersion_1)
            {

                Console.WriteLine("You can not play that game with this version of android(1.0)");

            }
            else if (version is AndroidVersion_2)
            {

                Console.WriteLine("You can play that fame with this version of android(2.0)");

            }
            else
            {

                Console.WriteLine("This version of android does not support by that game");

            }

        }

    }

}
