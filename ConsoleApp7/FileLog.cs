using System;
using System.IO;

namespace Logging
{
    public class FileLog : ILog
    {
        private string _filePath;

        public FileLog(string filePath)
        {
            _filePath = filePath;
        }

        public void Print(string message)
        {
            File.AppendAllText(_filePath, message + Environment.NewLine);
        }
    }
}
