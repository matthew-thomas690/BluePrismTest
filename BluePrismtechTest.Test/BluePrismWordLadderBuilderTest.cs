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
    public class BluePrismWordLadderBuilderTest
    {
        private string[] input = new string[] { "bone", "zone", "bale", "cane", "bane", "xeno", "test", "hard" };

        [TestMethod]
        public void EdgeBuilderTest()
        {
            var graph = new WordGraph(input);
            var edgeBuilder = new BluePrismEdgeBuilder();
            edgeBuilder.BuildEdges(graph);
            var ladderBuilder = new BluePrismWordLadderBuilder();
            var wordLadder = ladderBuilder.getWordLadder("zone", "bale", graph);

            Assert.IsTrue(wordLadder.Count() == 4);
            Assert.IsTrue(wordLadder[0] == "zone");
            Assert.IsTrue(wordLadder[1] == "bone");
            Assert.IsTrue(wordLadder[2] == "bane");
            Assert.IsTrue(wordLadder[3] == "bale");
        }
    }
}
