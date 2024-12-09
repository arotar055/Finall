using System.Collections.Generic;

namespace Serialization
{
    public interface ISerialize
    {
        void Save(string filePath, List<object> data);
        List<object> Load(string filePath);
    }
}
