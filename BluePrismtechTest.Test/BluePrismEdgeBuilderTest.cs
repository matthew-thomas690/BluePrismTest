using BluePrismtechTest.WordLadder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.Test
{
    [TestClass]
    public class BluePrismEdgeBuilderTest
    {
        private string[] input = new string[] { "zone", "bone", "bane", "cane", "bale", "xeno", "test", "hard" };

        [TestMethod]
        public void EdgeBuilderTest()
        {
            var graph = new WordGraph(input);
            var edgeBuilder = new BluePrismEdgeBuilder();
            edgeBuilder.BuildEdges(graph);

            Assert.IsTrue(graph.Count == 5);
            Assert.IsTrue(graph["zone"].Neighbors.Count == 1);
            Assert.IsTrue(graph["bone"].Neighbors.Count == 2);
            Assert.IsTrue(graph["bane"].Neighbors.Count == 3);
            Assert.IsTrue(graph["cane"].Neighbors.Count == 1);
            Assert.IsTrue(graph["bale"].Neighbors.Count == 1);

            Assert.IsTrue(graph["bone"].Neighbors.ContainsKey("zone"));
            Assert.IsTrue(graph["bone"].Neighbors.ContainsKey("bane"));
        }
    }
}
