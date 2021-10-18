using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.WordLadder
{
    public class WordGraph : Dictionary<string, WordGraphNode>
    {
        public WordGraph(string[] nodeValues)
        {
            foreach(var nodeValue in nodeValues)
            {
                this.TryAdd(nodeValue, new WordGraphNode(nodeValue));
            }
        }

        public void AddEdge(WordGraphNode one, WordGraphNode two)
        {
            one.AddNeighbor(two);
            two.AddNeighbor(one);
        }

    }
}
