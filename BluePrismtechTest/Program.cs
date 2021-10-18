using BluePrismtechTest.WordLadder;
using BluePrismtechTest.Input;
using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BluePrismtechTest.Output;
using CommandLine;
using System.Collections;
using System.Collections.Generic;

namespace BluePrismtechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Parser.Default.ParseArguments<CommandLineOptions>(args).WithNotParsed(errors => ExitWithError(errors)).WithParsed(cmdOptions => RunProgram(cmdOptions));
        }

        static void ExitWithError(IEnumerable<Error> errors)
        {
            foreach(Error er in errors)
            {
                Console.WriteLine(er.Tag.ToString());
            }
        }

        static void RunProgram(CommandLineOptions cmdOptions)
        {
            IServiceProvider serviceProvider = Host.CreateDefaultBuilder().ConfigureServices((_, services) =>
                services.AddTransient<IFileParser>(s => new LocalFileParser(cmdOptions.DictionaryFile))
                .AddTransient<IInputFilter, BluePrismInputFilter>()
                .AddTransient<IWordLadderFileWriter>(s => new LocalFileWriter(cmdOptions.ResultFile))
                .AddTransient<IEdgeBuilder, BluePrismEdgeBuilder>()
                .AddTransient<IWordLadderBuilder, BluePrismWordLadderBuilder>()
                .AddTransient<WordLadderProgramRoot>()
                ).Build().Services;

            var wordLadderProgramRoot = serviceProvider.GetService<WordLadderProgramRoot>();
            wordLadderProgramRoot.Run(cmdOptions.StartWord, cmdOptions.EndWord);
        }


    }
}
