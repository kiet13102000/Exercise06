using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestProblem1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBankAccount()
        {
            BankAccount acc  = new BankAccount(200000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(BankAccount));
            Assert.AreEqual(200000, acc.Balance());
        }
        [TestMethod]
        public void testWith()
        {
            BankAccount acc = new BankAccount(200000);
            acc.Withdraw(50000);
            Assert.AreEqual(150000, acc.Balance());
            acc.Withdraw(20000);
            Assert.AreEqual(130000, acc.Balance());
        }
        [TestMethod]
        public void Deposit()
        {
            BankAccount acc = new BankAccount(200000);
            acc.Deposit(50000);
            Assert.AreEqual(250000, acc.Balance());
            acc.Deposit(10000);
            Assert.AreEqual(260000, acc.Balance());
        }
       


    }
}
