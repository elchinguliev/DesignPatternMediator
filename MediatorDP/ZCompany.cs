using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class ZCompany : Company
    {
        public ZCompany(ITransfer transfer) : base(transfer)
        {
        }

        public override void StartToTransport()
        {
            Console.WriteLine("Gubadan eshyalar ZCompany vasitesile  yuklendi ");
            _transfer.TransferFurniture(this);
        }
    }
}
