using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MediaDevices;
using Logging;

namespace PriceListApp
{
    public class PriceList
    {
        private List<StorageDevice> _devices = new List<StorageDevice>();

        public void AddDevice(StorageDevice device)
        {
            _devices.Add(device);
        }

        public void RemoveDevice(string name)
        {
            _devices.RemoveAll(d => d.Name == name);
        }

        public StorageDevice FindDevice(string name)
        {
            return _devices.Find(d => d.Name == name);
        }

        public void PrintList(ILog log)
        {
            foreach (var device in _devices)
            {
                log.Print(device.GenerateReport());
            }
        }

        public void UpdateDevice(string name, string property, object value)
        {
            var device = FindDevice(name);
            if (device != null)
            {
                var prop = device.GetType().GetProperty(property);
                if (prop != null && prop.CanWrite)
                {
                    prop.SetValue(device, value);
                }
            }
        }
    }
}
