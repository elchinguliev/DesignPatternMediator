using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class YCompany : Company
    {
        public YCompany(ITransfer transfer) : base(transfer)
        {
        }

        public override void StartToTransport()
        {
            Console.WriteLine("Xachmazdan eshyalar YCompany vasitesile yuklendi ! ");
            _transfer.TransferFurniture(this);
        }
    }
}
