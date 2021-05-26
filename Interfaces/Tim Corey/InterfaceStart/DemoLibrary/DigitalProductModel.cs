using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class DigitalProductModel : IDigitalProductModel1
    {
        public int TotalDownloadsLeft { get; private set; } = 5;

        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
           
        }
    }
}
