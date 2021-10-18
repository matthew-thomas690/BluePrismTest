using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.Input
{
    public class LocalFileParser : IFileParser
    {
        
        private string filePath;

        public LocalFileParser(string filePath)
        {
            this.filePath = filePath;
        }

        public string[] Parse()
        {
            return File.ReadAllLines(filePath);
        }
    }
}
