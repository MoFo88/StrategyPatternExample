using System.IO;
using System.Xml.Serialization;
using StrategyPatternExample.XmlManipulations.Interfaces;

namespace StrategyPatternExample.XmlManipulations.Strategies
{
    public abstract class BaseStrategy : IXmlStrategy
    {
        public abstract string CreateXml();

        public abstract string GetFileTypeName();

        public string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new StringWriter();
                var serializer = new XmlSerializer(typeof (T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}