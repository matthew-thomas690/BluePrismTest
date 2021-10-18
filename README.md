# BluePrismTest

To solve the problem i broke the problem into four discrete sub problems

1) Reading/Filtering the dictionary file. 

This consisted of two components, a file parser to turn the file into a string array. I also added a filter component to remove a lot of the words that didn’t fit the acceptance criteria, e.g. were greater than four characters.

2) Writing the word ladder

This consisted of a single component that just output the word ladder to a file.

3) Reading the command line arguments

I used the nuget package commandlineparser to streamline the reading and parsing of the command line.

4) Finding the shortest list of words to transform the start word into the end word.

There is a clear relationship between the worst as described in the problem, each word has a direct relationship with any other word it differs by one character.

Using this relationship you can build a graph, with each node represented as a word. I built the classes to represent the graph and the nodes and wrote a class to build relationships  between the nodes.

Did some more research into finding the shortest path between nodes, which I learnt was the Breadth-first search (BFS) algorithm. Which I implemented in it’s own class, which was able to find the shortest route between the end word and the start word. This path could then be reversed to provide a solution to the problem.

