using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MediaDevices;
using Logging;
using PriceListApp;

class Program
{
    static void Main()
    {
        var priceList = new PriceList();
        var log = new ConsoleLog();

        priceList.AddDevice(new Flash { Manufacturer = "SanDisk", Model = "Cruzer", Name = "USB1", Capacity = 64, Quantity = 10, UsbSpeed = 480 });
        priceList.AddDevice(new DVD { Manufacturer = "Sony", Model = "RW", Name = "DVD1", Capacity = 4.7, Quantity = 20, WriteSpeed = 12 });
        priceList.AddDevice(new HDD { Manufacturer = "Seagate", Model = "Barracuda", Name = "HDD1", Capacity = 1024, Quantity = 5, SpindleSpeed = 7200 });

        priceList.PrintList(log);

        priceList.UpdateDevice("USB1", "UsbSpeed", 500);
        priceList.PrintList(log);
    }
}