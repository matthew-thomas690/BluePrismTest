using BluePrismtechTest.Input;
using BluePrismtechTest.Output;
using BluePrismtechTest.WordLadder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest
{
    class WordLadderProgramRoot
    {
        private IWordLadderFileWriter wordLadderFileWriter;
        private IFileParser fileParser;
        private IInputFilter inputFilter;
        private IEdgeBuilder edgeBuilder;
        private IWordLadderBuilder wordLadderBuilder;

        public WordLadderProgramRoot(IWordLadderFileWriter wordLadderFileWriter, IFileParser fileParser, IInputFilter inputFilter, IEdgeBuilder edgeBuilder, IWordLadderBuilder wordLadderBuilder)
        {
            this.wordLadderFileWriter = wordLadderFileWriter;
            this.fileParser = fileParser;
            this.inputFilter = inputFilter;
            this.edgeBuilder = edgeBuilder;
            this.wordLadderBuilder = wordLadderBuilder;
        }

        public void Run(string startWord, string endWord)
        {
            var wordList = fileParser.Parse();
            wordList = inputFilter.Filter(wordList);
            var graph = new WordGraph(wordList);
            edgeBuilder.BuildEdges(graph);
            var wordLadder = wordLadderBuilder.getWordLadder(startWord, endWord, graph);
            wordLadderFileWriter.Write(wordLadder);
        }
    }
}