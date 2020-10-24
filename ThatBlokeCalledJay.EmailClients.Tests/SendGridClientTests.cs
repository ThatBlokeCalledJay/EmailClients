using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThatBlokeCalledJay.EmailClients.SendGrid;

namespace ThatBlokeCalledJay.EmailClients.Tests
{
    [TestClass]
    public class SendGridClientTests
    {
        [TestMethod]
        public void Test_OptionsRequired()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var client = new SendGridEmailClient(null);
            });
        }

        [TestMethod]
        public void Test_ApiKeyRequired()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var client = new SendGridEmailClient(new SendGridOptions());
            });
        }
    }
}