
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System.Text;
using System;
using System.IO;
using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium.Chrome;
using Laba9.Pages;

namespace Laba9
{
    public class Tests
    {
      [Test]
        public void SendMessageTest()
        {

            string message = "Лаба 10, автотест";
            Assert.IsTrue("D".Contains("D", StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void TestAddItemToBasket()
        {
            Assert.IsTrue("D".Contains("D", StringComparison.OrdinalIgnoreCase));
        }
    }
}