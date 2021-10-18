namespace BluePrismtechTest.WordLadder
{
    interface IWordLadderBuilder
    {
        string[] getWordLadder(string start, string end, WordGraph graph);
    }
}