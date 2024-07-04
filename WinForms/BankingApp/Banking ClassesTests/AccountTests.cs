using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Classes.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void WithdrawTestSuccessAmountLessThanBalance()
        {
            // Arrange
            Account account = new Account(100);
            decimal amount = 20;
            decimal expectedBalance = 80;
            bool expectedResult = true;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = account.Withdraw(amount);
            actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void WithdrawTestSuccessAmountEqualBalance()
        {
            // Arrange
            Account account = new Account(100);
            decimal amount = 100;
            decimal expectedBalance = 0;
            bool expectedResult = true;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = account.Withdraw(amount);
            actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void WithdrawTestAmountNegative()
        {
            // Arrange
            Account account = new Account(100);
            decimal amount = -20; // want to change it to 20
            decimal expectedBalance = 80;
            bool expectedResult = true;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = account.Withdraw(amount);
            actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void WithdrawTestNSF()
        {
            // Arrange
            Account account = new Account(100);
            decimal amount = 150;
            decimal expectedBalance = 100;
            bool expectedResult = false;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = account.Withdraw(amount);
            actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void DepositTestPositiveAmount()
        {
            // Arrange
            Account account = new Account(100);
            decimal amount = 20;
            decimal expectedBalance = 120;     
            decimal actualBalance;

            // Act
            account.Deposit(amount);
            actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void DepositTestNegativeAmount()
        {
            // Arrange
            Account account = new Account(100);
            decimal amount = -20; // want to change it to 20
            decimal expectedBalance = 120;
            decimal actualBalance;

            // Act
            account.Deposit(amount);
            actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void ConstructorTestPositiveInit()
        {
            // Arrange
            decimal amount = 100;
            decimal expectedBalance = 100;
            decimal actualBalance;

            // Act
            Account acct = new Account(amount);
            actualBalance= acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void ConstructorTestNegativeInit()
        {
            // Arrange
            decimal amount = -100; // expect it to change to positive
            decimal expectedBalance = 100;
            decimal actualBalance;

            // Act
            Account acct = new Account(amount);
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void ConstructorNoInit()
        {
            // Arrange
            decimal expectedBalance = 0;
            decimal actualBalance;

            // Act
            Account acct = new Account();
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}