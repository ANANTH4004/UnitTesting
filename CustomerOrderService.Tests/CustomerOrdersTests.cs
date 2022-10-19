﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderService;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class CustomerOrdersTests
    {
        [TestCase]
        public void WhenPremium10Percent()
        {
            Customer c = new Customer();
            c.CustID = "samve";
            c.CustName = "Anand";
            c.CustomerType = CustomerType.Premium;
            Order order = new Order();
            order.OrderID = 102;
            order.ProdID = 103;
            order.Qty = 10;
            order.Amount = 1000;
            CustomerOrder customerOrder = new CustomerOrder();
            customerOrder.ApplyDiscount(c, order);
            Assert.AreEqual(order.Amount, 900);

        }
        [TestCase]
        public void WhenGold5Percent()
        {
            Customer c = new Customer();
            c.CustID = "atake";
            c.CustName = "Anand";
            c.CustomerType = CustomerType.Gold;
            Order order = new Order();
            order.OrderID = 102;
            order.ProdID = 103;
            order.Qty = 10;
            order.Amount = 1000;
            CustomerOrder customerOrder = new CustomerOrder();
            customerOrder.ApplyDiscount(c, order);
            Assert.AreEqual(order.Amount, 950);
            
        }
        [TestCase]
        public void FetchList() {
            CustomerOrder customerOrder = new CustomerOrder();
            Customer c1 = new Customer();
            
            customerOrder.GetCustomers(c1);
            List<Customer> custList1 = new List<Customer>();
            custList1.Add(new Customer() { CustID = "sk", CustName = "sk" });
            custList1.Add(new Customer() { CustID = "ab", CustName = "ab" });
            Assert.AreEqual(custList1, c1.Customers);
        }
    }
}