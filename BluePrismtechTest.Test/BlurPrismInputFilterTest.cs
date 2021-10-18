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
    public class BlurPrismInputFilterTest
    {
        [TestMethod]
        public void FilterTest()
        {
            var filter = new BluePrismInputFilter();
            string[] input = new string[] {"LongCharLength", "scl", "abc ", " abcd ", "EfGh", "ijkl", "ijkl"  };
            var output = filter.Filter(input);

            Assert.IsTrue(output.Count() == 3);
            Assert.AreEqual(output[0], "abcd");
            Assert.AreEqual(output[1], "efgh");
            Assert.AreEqual(output[2], "ijkl");
        }
    }
}
