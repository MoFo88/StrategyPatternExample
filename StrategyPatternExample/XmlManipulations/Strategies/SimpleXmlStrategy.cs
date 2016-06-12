using StrategyPatternExample.XmlManipulations.Builders;

namespace StrategyPatternExample.XmlManipulations.Strategies
{
    public class SimpleXmlStrategy : BaseStrategy
    {
        public override string CreateXml()
        {
            var builder = new SimpleXmlBuilder();
            var root = builder.BuildRoot();
            root.Customers = builder.BuildCustomers();
            root.Orders = builder.BuildOrders();

            return Serialize(root);
        }

        public override string GetFileTypeName()
        {
            return "Simple";
        }
    }
}