using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class CompanyMediator : Mediator
    {

        private VatanATechnologyCompany _vatanAtechnologyCompany;
        private VatanBTechnologyCompany _vatanBtechnologyCompany;

        public VatanATechnologyCompany VatanATechComp
        {

            set { _vatanAtechnologyCompany = value; }

        }
        public VatanBTechnologyCompany VatanBTechComp
        {

            set { _vatanBtechnologyCompany = value; }

        }

        public override void SendMessage(string message, TechnologyCompany colleague)
        {

            if (colleague == _vatanAtechnologyCompany)
            {

                _vatanAtechnologyCompany.Notify(message);

            }
            else if(colleague == _vatanBtechnologyCompany)
            {

                _vatanBtechnologyCompany.Notify(message);

            }


        }

    }
}
