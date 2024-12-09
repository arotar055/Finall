using System.Collections.Generic;

namespace Serialization
{
    public class XMLSerialize : ISerialize
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
