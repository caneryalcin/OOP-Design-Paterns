using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            CompanyMediator mediator = new CompanyMediator();

            VatanATechnologyCompany Acompany = new VatanATechnologyCompany(mediator);
            VatanBTechnologyCompany Bcompany = new VatanBTechnologyCompany(mediator);

            mediator.VatanATechComp = Acompany;
            mediator.VatanBTechComp = Bcompany;

            Acompany.Send("Elinizde Cat5 tipi kablo var mı?");
            Bcompany.Send("Elimizde Cat5 tipi kablo var,gönderiyoruz");

            Console.ReadKey();


        }
    }
}
