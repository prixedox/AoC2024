using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    public class FileService
    {
        private readonly string _directoryPath = @"..\..\..\Data\";

        public string[] GetLineContent(string fileName)
        {
            string filePath = getFilePath(fileName);

            string[] content = File.ReadAllLines(filePath);
            return content;
        }

        private string getFilePath(string fileName)
        {
            string filePath = Path.Combine(_directoryPath, fileName);

            return filePath;
        }
    }
}
