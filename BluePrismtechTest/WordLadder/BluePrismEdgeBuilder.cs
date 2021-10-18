using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.WordLadder
{
    public class BluePrismEdgeBuilder : IEdgeBuilder
    {
        public void BuildEdges(WordGraph graph)
        {
            var wordNodesSubset = graph.Values.ToList();

            foreach (var wordNode in graph.Values)
            {
                wordNodesSubset.Remove(wordNode);

                var neighbors = wordNodesSubset.Where(x => isNeighbor(wordNode.Word, x.Word)).ToList();

                foreach (var neighbor in neighbors)
                {
                    graph.AddEdge(wordNode, neighbor);
                }

            }

            var keys = graph.Where(x => x.Value.Neighbors.Count() == 0).Select(x => x.Key).ToList();

            foreach (var key in keys)
            {
                graph.Remove(key);
            }
        }

        private bool isNeighbor(string one, string two)
        {
            if (one == two || one.Length != two.Length)
            {
                return false;
            }

            int mismatchCounter = 0;

            for (int i = 0; i < one.Length; i++)
            {
                mismatchCounter += one[i] == two[i] ? 0 : 1;

                if (mismatchCounter > 1)
                {
                    break;
                }
            }

            return mismatchCounter == 1;
        }
    }
}
