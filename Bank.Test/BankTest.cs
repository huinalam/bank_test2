using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Test
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void Bank_출금_제대로되는지_확인()
        {
            // Arrange
            int balance = 200;
            int amount = 100;
            var bank = new BankAccount(balance);
            int expected = 0;

            // Act
            bank.Withdraw(amount);

            // Assert
            Assert.AreEqual(expected, bank.Balance, "잔고가 0이 되어야 합니다.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "출금 값이 잘못됨")]
        public void Bank_출금_값이_잘못됨()
        {
            // Arrange
            int balence = 100;
            int amount = 200;
            var bank = new BankAccount(balence);

            // Act
            bank.Withdraw(amount);

            // Assert
        }
    }
}
