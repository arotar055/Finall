using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Serialization
{
    public class SoapSerialize : ISerialize
    {
        public void Save(string filePath, List<object> data)
        {
        }

        public List<object> Load(string filePath)
        {
            return new List<object>();
        }
    }
}
