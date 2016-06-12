using System.Linq;
using StrategyPatternExample.XmlManipulations.Builders;

namespace StrategyPatternExample.XmlManipulations.Strategies
{
    public class ExtendedXmlStrategy : BaseStrategy
    {
        public override string CreateXml()
        {
            var builder = new ExtendedXmlBuilder();
            var root = builder.BuildRoot();
            root.Customers = builder.BuildCustomers();
            root.Orders = builder.BuildOrders();
            var customers = root.Customers.ToList();
            customers.Add(builder.BuildRealCustomer());

            root.Customers = customers.ToArray();

            return Serialize(root);
        }

        public override string GetFileTypeName()
        {
            return "Extended";
        }
    }
}