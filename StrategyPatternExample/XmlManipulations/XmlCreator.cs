using System;
using System.IO;
using StrategyPatternExample.XmlManipulations.Interfaces;

namespace StrategyPatternExample.XmlManipulations
{
    public class XmlCreator
    {
        private readonly string _directory;
        private readonly IXmlStrategy _strategy;

        public XmlCreator(IXmlStrategy strategy, string directory)
        {
            _strategy = strategy;
            _directory = directory;
        }

        public void GenerateFile()
        {
            var contents = _strategy.CreateXml();

            var filePath = Path.Combine(_directory,
                $"{_strategy.GetFileTypeName()}_{DateTime.Now:yyyyMMddHHmmssfff}.xml");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.AppendAllText(filePath, contents);
        }
    }
}