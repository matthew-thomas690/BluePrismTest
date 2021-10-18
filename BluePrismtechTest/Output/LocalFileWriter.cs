using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.Output
{
    public class LocalFileWriter : IWordLadderFileWriter
    {
        private string filePath;

        public LocalFileWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(string[] wordLadder)
        {
            File.WriteAllLines(filePath, wordLadder);
        }
    }
}
