using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class XCompany : Company
    {
        public XCompany(ITransfer transfer) : base(transfer)
        {
        }

        public override void StartToTransport()
        {
            Console.WriteLine("Bakidan eshyalar XCompany vasitesile yuklendi ");
            _transfer.TransferFurniture(this);
        }
    }
}
