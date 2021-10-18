using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.WordLadder
{
    public class WordGraphNode
    {
        public WordGraphNode(string word)
        {
            Word = word;
            Neighbors = new Dictionary<string, WordGraphNode>();
        }

        public string Word { get; private set; }
        public Dictionary<string, WordGraphNode> Neighbors { get; private set; }

        public void AddNeighbor(WordGraphNode node)
        {
            Neighbors.TryAdd(node.Word, node);
        }
    }
}
