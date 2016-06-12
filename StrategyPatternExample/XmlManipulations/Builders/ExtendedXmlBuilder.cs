using System;

namespace StrategyPatternExample.XmlManipulations.Builders
{
    public class ExtendedXmlBuilder : SimpleXmlBuilder
    {
        public override CustomerType[] BuildCustomers()
        {
            var customers = base.BuildCustomers();

            var i = 1;
            foreach (var customer in customers)
            {
                customer.CompanyName = $"Customer_{i}";
                customer.Phone = $"{i}{i}{i}-{i}{i}{i}-{i}{i}{i}";
                customer.FullAddress = new AddressType
                {
                    Address = $"{i} Street",
                    City = $"City_{i}"
                };
                ++i;
            }

            return customers;
        }

        public override OrderType[] BuildOrders()
        {
            var orders = base.BuildOrders();

            var i = 1;
            foreach (var order in orders)
            {
                order.OrderDate = DateTime.Now.AddDays(-i);
                order.RequiredDate = DateTime.Now.AddDays(i);
                order.ShipInfo = new ShipInfoType
                {
                    ShipAddress = $"Ship_Address_{i}",
                    ShipCity = $"Ship_City_{i}",
                    ShipCountry = $"Ship_Country_{i}",
                    Freight = i
                };
                ++i;
            }

            return orders;
        }

        public CustomerType BuildRealCustomer()
        {
            var customerId = "REAL_CUSTOMER";
            return new CustomerType
            {
                CompanyName = "Real Customer",
                ContactName = "Real Contact",
                ContactTitle = "Sir",
                CustomerID = customerId,
                FullAddress = new AddressType
                {
                    Address = "Real Address",
                    City = "Real City",
                    Country = "Real Country",
                    CustomerID = customerId,
                    PostalCode = "90210",
                    Region = "Real Region"
                },
                Fax = "123-456-7890",
                Phone = "987-654-3210"
            };
        }
    }
}