using BluePrismtechTest.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.Test
{
    [TestClass]
    public class LocalFileParserTest
    {
        [TestMethod]
        public void FileParserTest()
        {
            var fileParser = new LocalFileParser("wordtestfile.txt");
            var fileContent = fileParser.Parse();
            Assert.IsTrue(fileContent.Length == 36);
        }
    }
}
