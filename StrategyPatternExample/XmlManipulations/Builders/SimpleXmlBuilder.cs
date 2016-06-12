using System.Collections.Generic;

namespace StrategyPatternExample.XmlManipulations.Builders
{
    public class SimpleXmlBuilder : BaseXmlBuilder
    {
        public virtual CustomerType[] BuildCustomers()
        {
            var customers = new List<CustomerType>();
            for (var i = 1; i <= 3; i++)
            {
                customers.Add(new CustomerType { CustomerID = i.ToString() });
            }

            return customers.ToArray();
        }

        public virtual OrderType[] BuildOrders()
        {
            var orders = new List<OrderType>();
            for (var i = 1; i <= 3; i++)
            {
                orders.Add(new OrderType { CustomerID = i.ToString() });
            }

            return orders.ToArray();
        }
    }
}