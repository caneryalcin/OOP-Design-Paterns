using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    abstract class Mediator
    {

        abstract public void SendMessage(string message, TechnologyCompany technologyCompany);

    }
}
