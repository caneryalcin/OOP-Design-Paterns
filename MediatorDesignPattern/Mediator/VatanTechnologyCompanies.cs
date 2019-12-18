using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class VatanATechnologyCompany : TechnologyCompany
    {
        
        public VatanATechnologyCompany(Mediator mediator)
            : base(mediator)
        {

        }

        public void Send(string message)
        {

            Console.WriteLine("VatanA şirketi mesajı:" + message);
            mediator.SendMessage(message, this);

        }

        public void Notify(string message)
        {

            Console.WriteLine("vatanA'den VatanB'ye gelen mesaj : " + message);

        }

    }
    class VatanBTechnologyCompany : TechnologyCompany
    {
        
        public VatanBTechnologyCompany(Mediator mediator)
            : base(mediator)
        {

        }

        public  void Send(string message)
        {
            
            Console.WriteLine("VatanB şirketi mesajı:" + message);
            mediator.SendMessage(message, this);

        }

        public void Notify(string message)
        {

            Console.WriteLine("vatanB'den VatanA ya gelen mesaj : " + message);

        }

    }


}
