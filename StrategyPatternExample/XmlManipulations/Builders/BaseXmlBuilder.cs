namespace StrategyPatternExample.XmlManipulations.Builders
{
    public class BaseXmlBuilder
    {
        public Root BuildRoot()
        {
            return new Root();
        }
    }
}