using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest.WordLadder
{
    public class BluePrismWordLadderBuilder : IWordLadderBuilder
    {

        private Dictionary<WordGraphNode, WordGraphNode> visitedNodes = new Dictionary<WordGraphNode, WordGraphNode>();
        public string[] getWordLadder(string start, string end, WordGraph graph)
        {
            if (!(graph.ContainsKey(start) && graph.ContainsKey(end)))
            {
                return new string[] { };
            }

            var foundEnd = runBFS(graph[start], graph[end]);

            if (!foundEnd)
            {
                return new string[] { };
            }

            var nodePath = getShortestPath(graph[start], graph[end]);
            return nodePath.Select(x => x.Word).ToArray();
        }

        private bool runBFS(WordGraphNode start, WordGraphNode end)
        {
            var nodeQueue = new Queue<WordGraphNode>();
            nodeQueue.Enqueue(start);
            bool foundEnd = false;

            //use BFS uptil we find the end
            while (nodeQueue.Count > 0 && foundEnd == false)
            {
                var vertex = nodeQueue.Dequeue();

                foreach (var neighbor in vertex.Neighbors)
                {
                    if (visitedNodes.ContainsKey(neighbor.Value))
                    {
                        continue;
                    }

                    visitedNodes[neighbor.Value] = vertex;
                    nodeQueue.Enqueue(neighbor.Value);
                    if (neighbor.Value == end)
                    {
                        foundEnd = true;
                    }
                }
            }

            return foundEnd;
        }

        private List<WordGraphNode> getShortestPath(WordGraphNode start, WordGraphNode end)
        {
            var path = new List<WordGraphNode> { };
            var current = end;

            while (current != start)
            {
                path.Add(current);
                current = visitedNodes[current];
            };

            path.Add(start);
            path.Reverse();
            return path;
        }
    }
}
