using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
using BankApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankApps.Test
{
    public class AccountImplementationShould
    {
        private readonly IAccount _account;
        private readonly AccountModel _accountModel;
        private readonly TransactionModel _transactions;
        //public AccountImplementationShould(IAccount account)
        //{
        //    _account = account;
        //    _accountModel = new AccountModel();
        //    _transactions = new TransactionModel();
        //}

       // [Test]
        public void CheckCreateAccount()
        {
            var customerData = new CustomerData();
            
            var customer = new CustomerModel()
            {
                
                Name = "Abiodun Kazeem",
                Email = "harbbey@gmail.com",
                Password = "def234!"
            };
            
            customerData.AddCustomer(customer);
            var systemUnderTest = _account;
            double amount = 70000;
            var result = systemUnderTest.CreateAccount(customer.UserId, "Savings", amount);
            Assert.That(result, Is.Not.Null);
        }
        //[Test]
       // public void 
    }
}
