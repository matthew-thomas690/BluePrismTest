using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrismtechTest
{
    public class CommandLineOptions
    {
        [Option("DictionaryFile", Required =true )]
        public string DictionaryFile { get; set; }
        [Option("StartWord", Required = true)]
        public string StartWord { get; set; }
        [Option("EndWord", Required = true)]
        public string EndWord { get; set; }
        [Option("ResultFile", Required = true)]
        public string ResultFile { get; set; }
    }
}
