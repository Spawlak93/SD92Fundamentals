using _09_Interfaces_Transactions.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _09_Interfaces_Transactions
{
    [TestClass]
    public class TransactionTests
    {
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(211.82m);
            var euro = new Euro();

            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);
            var thirdTransaction = new Transaction(euro);

            Assert.AreEqual(1m, firstTransaction.GetTransactionAmount());

            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());
            Assert.AreEqual(211.82m, secondTransaction.GetTransactionAmount());

        }

        [TestMethod]
        public void MyTestMethod()
        {
            Console.ReadLine();
        }
    }
}
