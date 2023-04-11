using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class Transfer : ITransfer
    {
        XCompany? xCompany;
        YCompany? yCompany;
        ZCompany? zCompany;

        public XCompany XCompany {set => xCompany=value;}
        public YCompany YCompany { set => yCompany=value; }
        public ZCompany ZCompany { set => zCompany=value;}


        public void TransferFurniture(Company company)
        {
            if (company is XCompany)
            {
                Console.WriteLine("Eshyalar Xachmazda tekrar dasinmaq uzere masindan cixarildi ");
                yCompany.StartToTransport();
            }
            else if (company is YCompany)
            {
                Console.WriteLine("Eshyalar Gubada  tekrar dasinmaq uzere masindan cixarildi ");
                zCompany.StartToTransport();
            }
            else
            {
                Console.WriteLine("Eshyalar Qusara catdirldi");
            }
        }
    }
}
