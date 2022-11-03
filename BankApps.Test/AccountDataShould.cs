using BankApp.Data;
using BankApp.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApps.Test
{
    [TestFixture]
    public class AccountDataShould
    {
        [Test]
        public void CheckAccountNumberIsNotNull()
        {
            var systemUnderTest = new AccountData();
            var AccountNumber = systemUnderTest.GetAllAccountNo();
            var accountNumbersJson = JsonConvert.SerializeObject(AccountNumber);
            Assert.That(accountNumbersJson, Is.Not.Null);
        }
        [Test]
        public void CheckListOfAccountNotNll()
        {
            var systemUnderTest = new AccountData();
            var listOfAccountNumbers = systemUnderTest.GetAllAccounts();
            var accountNumbersJson = JsonConvert.SerializeObject(listOfAccountNumbers);
            Assert.That(accountNumbersJson, Is.Not.Null);
        }
        [Test]
        public void CheckGetAccountByUserId()
        {
            var account = new AccountModel
            {
                AccountNo = "04357977731",
                AccountType = "Savings",
                Balance = 4479.0,
                userId = 1
            };
            var list = new List<AccountModel>();
            list.Add(account);
            var systemUnderTest = new AccountData();
            var result = systemUnderTest.GetAccountsByUserId(account.userId);
            Assert.That(result, Is.Not.Null);

        }
        [Test]
        public void CheckGetAccountByAccountNumber()
        {
            var account = new AccountModel
            {
                AccountNo = "04357977731",
                AccountType = "Savings",
                Balance = 4479.0,
                userId = 1
            };
            var list = new List<AccountModel>();
            list.Add(account);
            var systemUnderTest = new AccountData();
            var result = systemUnderTest.GetAccountByAccountNo(account.AccountNo);
            var accountJson = JsonConvert.SerializeObject(result);
            Assert.That(account, Is.Not.Null);

        }
        [Test]
        public void CheckInsertAccount()
        {
            var account = new AccountModel
            {
                AccountNo = "04357977731",
                AccountType = "Savings",
                Balance = 4479.0,
                userId = 1
            };
            var systemUnderTest = new AccountData();
            var result =systemUnderTest.InsertAccount(account);
            Assert.That(result, Is.True);

        }
        [Test]
        public void CheckGetAccountByUserIdAndAccountNo()
        {
            var account = new AccountModel
            {
                AccountNo = "04357977731",
                AccountType = "Savings",
                Balance = 4479.0,
                userId = 1
            };
            var systemUnderTest = new AccountData();
            var result = systemUnderTest.GetAccountByUserIdAndAccountNo(account.userId, account.AccountNo);
            Assert.That(result, Is.Not.Null);
        }
        [Test]
        public void CheckUpdateAccount()
        {
            var account = new AccountModel
            {
                AccountNo = "04357977731",
                AccountType = "Savings",
                Balance = 4479.0,
                userId = 1
            };
            var systemUnderTest = new AccountData();
            var result = systemUnderTest.UpdateAccount(account.AccountNo, account);
            Assert.That(result, Is.True);
        }


    }
}
