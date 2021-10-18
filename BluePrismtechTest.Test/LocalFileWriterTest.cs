using BluePrismtechTest.Output;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BluePrismtechTest.Test
{
    [TestClass]
    public class  LocalFileWriterTest
    {
        private string[] input = new string[] { "zone", "bone", "bane" };

        [TestMethod]
        public void FileWriterTest()
        {
            var fileName = Guid.NewGuid().ToString() + ".txt";
            var fileWriter = new LocalFileWriter(fileName);
            fileWriter.Write(input);
            Assert.IsTrue(File.Exists(fileName));
            File.Delete(fileName);
        }
    }
}
