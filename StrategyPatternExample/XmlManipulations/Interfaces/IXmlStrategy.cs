namespace StrategyPatternExample.XmlManipulations.Interfaces
{
    public interface IXmlStrategy
    {
        string CreateXml();
        string GetFileTypeName();
    }
}