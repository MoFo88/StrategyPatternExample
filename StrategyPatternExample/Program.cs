using System;
using StrategyPatternExample.XmlManipulations;
using StrategyPatternExample.XmlManipulations.Interfaces;
using StrategyPatternExample.XmlManipulations.Strategies;

namespace StrategyPatternExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Select output version:\n\n" +
                              "Simple/s - Simple XML version\n" +
                              "Extended/e - Extended XML version");
            var version = Version.Unknown;
            var isVersionProvided = false;
            while (!isVersionProvided)
            {
                var selectedVersion = Console.ReadLine();

                if (Enum.TryParse(selectedVersion, true, out version))
                {
                    isVersionProvided = true;
                }
                else
                {
                    Console.WriteLine("Please select valid option...");
                }
            }

            if (version != Version.Unknown)
            {
                IXmlStrategy strategy = null;

                switch (version)
                {
                    case Version.S:
                    case Version.Simple:
                        strategy = new SimpleXmlStrategy();
                        break;
                    case Version.E:
                    case Version.Extended:
                        strategy = new ExtendedXmlStrategy();
                        break;
                }

                var x = new XmlCreator(strategy, @"C:\xmlOutput");
                x.GenerateFile();
            }
        }
    }
}